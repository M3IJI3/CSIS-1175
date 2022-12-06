using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Employee
    {
        public const double TAX_RATE_LOW = 0.15; // [0,850]
        public const double TAX_RATE_MEDIUM = 0.205; // (850, 1900]
        public const double TAX_RATE_HIGH = 0.29; // (1900, 2700]
        public const double TAX_RATE_HIGHEST = 0.33; // >2700

        public string name;
        public double hourlyRate;
        public double hoursWorked;
        public double grossPayment;
        public double bonus;
        private double afterTaxPayment;

        public Employee()
        {

        }

        public Employee(string name, double hourlyRate, double hoursWorked)
        {
            this.name = name;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        // getter and setter methods
        public double AfterTaxPayment
        {
            get { return afterTaxPayment; }
            set { afterTaxPayment = value; }
        }

        public double CalculateGrossIncome()
        {
            double grossIncome = hourlyRate * hoursWorked + CalculateBonus();
            return grossIncome;
        }

        public double CalculateBonus()
        {
            if(hoursWorked >= 30 && hoursWorked < 37.5)
            {
                bonus = 150;
            }
            else if(hoursWorked >= 37.5 && hoursWorked < 40)
            {
                bonus = 275;
            }
            else
            {
                bonus = 0;
            }

            return bonus;
        }

        public double CalculateTaxPayable()
        {
            double taxRate;
            double grossIncome = CalculateGrossIncome();

            if(grossIncome > 0 && grossIncome <= 850)
            {
                taxRate = TAX_RATE_LOW;
            }
            else if(grossIncome > 850 && grossIncome <= 1900)
            {
                taxRate = TAX_RATE_MEDIUM;
            }
            else if(grossIncome > 1900 && grossIncome <= 2700)
            {
                taxRate = TAX_RATE_HIGH;
            }
            else
            {
                taxRate = TAX_RATE_HIGHEST;
            }

            double taxPayable = grossIncome * taxRate;

            return taxPayable;
        }

        public double CalculateNetIncome()
        {
            double netIncome = CalculateGrossIncome() - CalculateTaxPayable();
            return netIncome;
        }

        public override string ToString()
        {
            return "Name: " + name +
                "\nHourlyRate: " + hourlyRate.ToString("C") +    
                "\nGross Income: " + CalculateGrossIncome().ToString("C") +
                "\nNet Income: " + CalculateNetIncome().ToString("C");
        }
    }
}
