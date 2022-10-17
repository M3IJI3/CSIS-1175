using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeeApp
{
    internal class Program
    {
        // 涨薪函数
        public static void IncreaseSalary(Employee[] employees)
        {
            string inputValue;
            double value;

            Write("Hi, boss, please input the raise for {0}: ", employees[0].name);
            inputValue = ReadLine();

            while(double.TryParse(inputValue, out value) == false)
            {
                Write("Hi, boss, please input the raise for {0} in the" +
                    "format of float number: ", employees[0].name);
                inputValue = ReadLine();
            }
            WriteLine();

            employees[0].hourlyRate += double.Parse(inputValue);
            WriteLine("The employee with lowest netincome");
            WriteLine("".PadRight(60, '-'));
            WriteLine(employees[0].ToString());

        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            WriteLine("Input Employees Information\n"); 

            for(int i = 0; i < employees.Length; i++)
            {
                //WriteLine("".PadRight(60, '-'));
                Write("Please enter the no.{0}'s employee name: ", i+1);
                string name = ReadLine();

                Write("Please enter hourly rate for " + name + ": ");
                double hourlyRate = double.Parse(ReadLine());

                Write("Please enter hours worked for " + name + ": ");
                double hoursWorked = double.Parse(ReadLine());

                WriteLine();

                employees[i] = new Employee(name, hourlyRate, hoursWorked);
                
            }

            // 根据net income大小排序
            var qry = from employee in employees
                      orderby employee.CalculateNetIncome()
                      select employee;
            Array.ForEach<Employee>(qry.ToArray<Employee>(), employee => WriteLine());



            WriteLine("The employee with the highest netincome");
            WriteLine("".PadRight(60, '-'));
            WriteLine(employees[3].ToString());
            WriteLine();

            WriteLine("The employee with the lowest netincome");
            WriteLine("".PadRight(60, '-'));
            WriteLine(employees[0].ToString());

            IncreaseSalary(employees);

            ReadKey();
        }
    }
}
