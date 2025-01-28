using DemoPosuda.Models;
using System;

namespace DemoPosuda.Logick
{
    public class SaleRachet
    {
        public double SaleSet(Tovar tovar)
        {
            var sale = Convert.ToDouble(tovar.cost_tovar * (tovar.curent_sale_tovar / 100));

            return sale;
        }
    }
}
