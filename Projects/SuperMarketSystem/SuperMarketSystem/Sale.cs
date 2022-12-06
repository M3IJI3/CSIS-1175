using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class Sale
    {
        Warehouse wh = new Warehouse();

        public Sale()
        {
            wh.StockInProducts("Acer", 100);
            wh.StockInProducts("Samsung", 200);
            wh.StockInProducts("Soysauce", 300);
            wh.StockInProducts("Banana", 400);
        }

        public void AskBuy()
        {
            Console.WriteLine("What u need?");
            Console.WriteLine("we have Acer, Samsung, Soysauce, Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("How many u need?");
            int count = int.Parse(Console.ReadLine());

            // 去仓库取货
            ProductFather[] pros = wh.StockOutProducts(strType, count);

            // 算钱
            double money = GetMoney(pros);
            Console.WriteLine("Total: {0:C}", money);
            Console.WriteLine("Select your discount methods: " +
                              "1. no discount." +
                              "2. 10% discount." +
                              "3. 15% discount." +
                              "4. 300 and 50 back." +
                              "5. 500 and 100 back.");
            string input = Console.ReadLine();
            DiscountFather discount = GetDiscountMethod(input);
            double total = discount.GetTotalPrice(money);
            Console.WriteLine("After discount: {0:C}", total);
        }

        public DiscountFather GetDiscountMethod(string input)
        {
            DiscountFather discount = null;
            switch( input)
            {
                case "1":
                    discount = new NoDiscount();
                    break;
                case "2":
                    discount = new DiscountAsRate(0.9);
                    break;
                case "3":
                    discount = new DiscountAsRate(0.85);
                    break;
                case "4":
                    discount = new CashBack(300, 50);
                    break;
                case "5":
                    discount = new CashBack(500, 50);
                    break;
                default:
                    break;
            }
            return discount;
        }

        public double GetMoney(ProductFather[] pros)
        {
            double sum = 0;

            for(int i = 0; i < pros.Length; i++)
            {
                sum += pros[i].price;
            }

            return sum;
        }

        public void DisplayPros()
        {
            wh.DisplayProducts();
        }
    }
}
