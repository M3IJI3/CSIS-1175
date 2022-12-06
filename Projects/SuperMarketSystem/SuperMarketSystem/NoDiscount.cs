using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class NoDiscount : DiscountFather
    {
        public override double GetTotalPrice(double beforeDiscount)
        {
            return beforeDiscount;
        }
    }
}
