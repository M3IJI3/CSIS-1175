using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 分别提示用户输入用户名和密码
            // 判断用户输入的是否正确
            // 返回给用户的登录结果, 并且单独返回给用户的一个登录信息
            // 如果用户名错误, 除了返回登录结果之外, 还要返回一个"用户名错误"
            // "密码错误"

            string msg;

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool b = isLogin(username, password, out msg);

            Console.WriteLine("Result: {0}", b.ToString());
            Console.Write("Message: {0}", msg);

            Console.ReadKey();

        }

        public static bool isLogin(string name, string pwd, out string msg)
        {
            if(name == "admin" && pwd == "123456")
            {
                msg = "Succeed!";
                return true;
            }
            else if(name == "admin")
            {
                msg = "Password error!";
                return false;
            }
            else if(pwd == "123456")
            {
                msg = "Account name error!";
                return false;
            }
            else
            {
                msg = "Unknown result!";
                return false;
            }
        }
    }
}
