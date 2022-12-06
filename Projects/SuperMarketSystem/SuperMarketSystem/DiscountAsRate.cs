using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class DiscountAsRate : DiscountFather
    {
        public double rate { get; set; }

        public DiscountAsRate(double rate)
        {
            this.rate = rate;
        }

        public override double GetTotalPrice(double beforeDiscount)
        {
            return beforeDiscount * rate;
        }
    }
}
