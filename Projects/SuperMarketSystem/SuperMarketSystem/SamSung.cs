using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class SamSung : ProductFather
    {
        public SamSung(string id, double price, string name) 
            : base(id, price, name)
        {

        }
    }
}
