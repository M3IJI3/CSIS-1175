using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal abstract class DiscountFather
    {
        public abstract double GetTotalPrice(double beforeDiscount);
    }
}
