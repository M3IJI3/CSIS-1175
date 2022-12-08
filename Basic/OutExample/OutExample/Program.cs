using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExample
{
    // 如果在一个方法中, 返回多个相同类型的值的时候, 可以考虑返回一个数组
    // 但是, 如果返回多个不同类型的值的时候, 但会数组就不可以了
    // out参数侧重于在一个方法中可以返回多个不同类型的值
    internal class Program
    {
        static void Main(string[] args)
        {
            // 写一个方法 求一个数组中的最大值,最小值,总和,平均值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// 将要返回的四个值, 放到一个数组中返回
            //int[] res = GetMaxMinSumAvg(numbers);
            //Console.WriteLine("Max: {0}, Min: {1}, Sum: {2}, Avg: {3}",
            //    res[0], res[1], res[2], res[3]);

            //Console.ReadKey();
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;

            Test(numbers,out max, out min, out sum, out avg);

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);

        }

        public static int[] GetMaxMinSumAvg(int[] numbers)
        {
            int[] res = new int[4];
            res[0] = numbers[0]; // max
            res[1] = numbers[0]; // min
            res[2] = 0;          
            
            for(int i = 0; i< numbers.Length; i++)
            {
                // 如果当前循环到的元素比我假设的最大值还大
                if (numbers[i] > res[0])
                {
                    // 将当前循环到的元素赋值给我的最大值
                    res[0] = numbers[i];
                }

                if (numbers[i] < res[0])
                {
                    res[1] = numbers[i];
                }
                res[2] += numbers[i]; 
            }
            // 平均值
            res[3] = res[2] / numbers.Length;

            return res;
        }

        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg)
        {
            // out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[1];
            sum = 0;

            for(int i = 0; i> nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

                if (nums[i] < max)
                {
                    min = nums[i];
                }

                sum += nums[i];
            }
            avg = sum / nums.Length;        
        }
    }
}
