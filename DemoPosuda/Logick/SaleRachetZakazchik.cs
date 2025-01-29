using DemoPosuda.Models;
using System.Linq;

namespace DemoPosuda.Logick
{
    /// <summary>
    /// Класс для расчета скики по <see cref="Postavchik"/>
    /// </summary>
    public class SaleRachetZakazchik
    {
        /// <summary>
        /// Расчет скидки
        /// </summary>
        public int SaleRachet(string client)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var colvo = context.Zakaz
                    .Where(p => p.Clietn.directort_client == client)
                    .Select(p => p.Tovar.cost_tovar * p.kolvo_tovar_in_zakaz)
                    .Sum();

                var sale = 0;

                if (colvo < 50000) sale = 0;
                else if (colvo < 100000) sale = 1;
                else if (colvo < 300000) sale = 3;
                else if (colvo > 300000) sale = 5;

                return sale;
            }
        }
    }
}
