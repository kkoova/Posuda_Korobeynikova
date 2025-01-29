using DemoPosuda.Models;
using System;

namespace DemoPosuda.Logick
{
    /// <summary>
    /// Класс расчета скидки
    /// </summary>
    public class SaleRachet
    {
        /// <summary>
        /// Расчет скидки товара
        /// </summary>
        public double SaleSet(Tovar tovar)
        {
            var sale = Convert.ToDouble(tovar.cost_tovar * (tovar.curent_sale_tovar / 100));

            return sale;
        }
    }
}
