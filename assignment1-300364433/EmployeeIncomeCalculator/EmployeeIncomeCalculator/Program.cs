using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeeIncomeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double COMMISSION_RATE = 0.07;
            const double FEDERAL_TAX_RATE = 0.18;
            const double RETIREMENT_TAX_RATE = 0.10;
            const double SOCIAL_SECURITY_RATE = 0.06;

            string employeeName = "Joshua Montain";
            double salesThisMonth = 161423.00;
            
            // commission from monthly sales
            double commission = salesThisMonth * COMMISSION_RATE; // calculate commission

            // federal tax
            double federalTax = commission * FEDERAL_TAX_RATE; // calculate federal tax

            // earnings before federal tax
            double earnings = commission - federalTax; // calculate earnings after paying tax

            // retirement program
            double contributionToRetirementProgram = earnings * RETIREMENT_TAX_RATE;

            // social security
            double contributionToSocialSecurity = earnings * SOCIAL_SECURITY_RATE;

            // final earning after paying the retirement and social security programs
            double finalEarnings = earnings - contributionToRetirementProgram - contributionToSocialSecurity;

            // total deduction out of all sales this month
            double totalDeduction = (salesThisMonth - commission) + federalTax + contributionToRetirementProgram + contributionToSocialSecurity;

            WriteLine(employeeName + "'s Personal Income Report\n");
            WriteLine(("").PadRight(40, '-') + "\n");
            WriteLine("Monthly Sales:{0, 26:c}\n", salesThisMonth);
            WriteLine("Commission/{0:p1}:{1,24:N}\n", COMMISSION_RATE, commission);

            WriteLine("Federal Tax/{0:p1}:\t" + "{1,16:N}\n", FEDERAL_TAX_RATE, -federalTax);
            WriteLine(("").PadRight(40, '-') + "\n");

            WriteLine("Earnings:\t{0,24:N}\n", earnings);
            WriteLine("Retirement/{0:p1}:\t{1,16:N}\n", RETIREMENT_TAX_RATE, -contributionToRetirementProgram);
            WriteLine("Social Security/{0:p1}:\t{1,16:N}\n", SOCIAL_SECURITY_RATE, -contributionToSocialSecurity);

            WriteLine(("").PadRight(40, '-') + "\n");
            WriteLine("Total Deduction:\t{0,16:N}\n",  totalDeduction);
            WriteLine("Final Earnings:\t{0,24:c}\n", finalEarnings);

            ReadKey();
        }
    }
}

/*
 * the output should be like this below when 
 * monthly sales is $161,432.00
 * 
   Joshua Montain's Personal Income Report

   ----------------------------------------

   Monthly Sales:               $161,432.00

   Commission/7.0%:               11,300.24

   Federal Tax/18.0%:             -2,034.04

   ----------------------------------------

   Earnings:                       9,266.20

   Retirement/10.0%:                -926.62

   Social Security/6.0%:            -555.97

   ----------------------------------------

   Total Deduction:              153,648.39

   Final Earnings:                $7,783.61 
 *
 */
