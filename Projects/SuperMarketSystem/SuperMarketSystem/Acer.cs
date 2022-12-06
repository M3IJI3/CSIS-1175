using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class Acer : ProductFather
    {
        public Acer(string id, double price, string name)
            : base(id, price, name)
        {

        }
    }
}
