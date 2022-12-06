using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class ProductFather
    {
        public double price { get; set; }
        public string name  { get; set; }
        public string id    { get; set; }

        public ProductFather(string id, double price, string name)
        {
            this.price = price;
            this.name  = name;
            this.id    = id;
        }
    }
}
