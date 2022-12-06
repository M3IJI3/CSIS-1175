using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class Warehouse
    {
        // 存储货物
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        public void DisplayProducts()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item[0].name + "\t\t" + item.Count + "\t\t" + item[0].price); ;
            }
        }

        public Warehouse()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        public void StockInProducts(string strType, int count)
        {
            for(int i = 0; i < count; i++)
            {
                
                switch(strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "Acer laptop"));
                        break;
                    case "Samsung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 1200, "Samsung Phone"));
                        break;
                    case "Banana":
                        list[2].Add(new Banana(Guid.NewGuid().ToString(), 1.2, "Banana"));
                        break;
                    case "Soysauce":
                        list[3].Add(new Soysauce(Guid.NewGuid().ToString(), 3.4, "Soysauce"));
                        break;
                    default:
                        break;
                }

                //Console.WriteLine(list[0][0].name);
            }
            
        }

        public ProductFather[] StockOutProducts(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];

            for (int i = 0; i < count; i++)
            {
                switch(strType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Samsung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Soysauce":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }

            return pros;
        }
    }
}
