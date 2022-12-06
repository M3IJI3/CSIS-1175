using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class CashBack : DiscountFather
    {
        public double buy { get; set; }
        public double back { get; set; }
        public CashBack(double buy, double back)
        {
            this.buy = buy;
            this.back = back;
        }

        public override double GetTotalPrice(double beforeDiscount)
        {
            if(beforeDiscount >= buy)
            {
                return beforeDiscount - (int)(beforeDiscount / buy) * back;
            }
            else
            {
                return beforeDiscount;
            }
        }
    }
}
