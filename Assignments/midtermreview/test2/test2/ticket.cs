using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class ticket
    {
        public const int INIT_FINE = 75;
        public const double SPEED_SURCHARGE = 50;
        public const int SENIOR_CHARGE_LOW = 50;
        public const int SENIOR_CHARGE_HIGH = 200;
        public const int JUNIOR_DEDUCT = 50;
        public const int JUNIOR_CHARGE = 100;

        public int speed;
        private int year;
        public int speedLimit;

        public string name;

        public ticket()
        {

        }

        public ticket(int speed, int year, int speedLimit, string name)
        {
            this.speed = speed;
            this.year = year;
            this.speedLimit = speedLimit;
            this.name = name;
        }

        public double CalculateYearSurcharge()
        {
            double xchgYear = 0;

            if(year > 1)
            {
                if(speed - speedLimit >= 20)
                {
                    xchgYear = SENIOR_CHARGE_HIGH;
                }
                else
                {
                    xchgYear = SENIOR_CHARGE_LOW;
                }
            }
            else
            {
                if(speed - speedLimit >=20)
                {
                    xchgYear = JUNIOR_CHARGE;
                }
                else
                {
                    xchgYear = 0 - JUNIOR_DEDUCT;
                }
            }

            return xchgYear;
        }

        public double CalculateTicket()
        {
            double fine = INIT_FINE;

            double xchgSpd = SPEED_SURCHARGE * ((speed - speedLimit) / 5);

            return fine + xchgSpd + CalculateYearSurcharge();
        }

        public override string ToString()
        {
            return "\tTicket" +
                "\nName: \t" + name +
                "\nSchool year: \t" + year +
                "\nReported Speed: \t" + speed +
                "\nSpeed Limit: \t" + speedLimit +
                "\nFine: \t" + CalculateTicket().ToString();
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            if(year <= 4 && year >=1)
            {
                this.year = 0;
            }
            else
            {
                this.year = 1;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if(value < 1)
                {
                    year = 1;
                }
                else if(value > 1)
                {
                    year = 4;
                }
                else 
                {
                    year = value;
                }
            }
        }
    }
}
