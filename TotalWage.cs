using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmpWage
{
    public class TotalWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private string company;
        private int EmpRateprhr;
        private int NumWorkingDay;
        private int MaxHrPrMonth;
        private int totalEmpWage;
        public TotalWages(string company, int EmpRateprhr, int NumWorkingDay, int MaxHrPrMonth)
        {
            this.company = company;
            this.EmpRateprhr = EmpRateprhr;
            this.NumWorkingDay = NumWorkingDay;
            this.MaxHrPrMonth = MaxHrPrMonth;
        }

        public void ComputeEmpWage()
        {
            //variable
            int emphr = 0;
            int totalemphr = 0;
            int totalworkingday = 0;

            while (totalemphr <= MaxHrPrMonth && totalworkingday < NumWorkingDay)
            {
                totalworkingday++;
                Console.WriteLine("monthly wages of employee");
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is FullTime");
                        emphr = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Employee is PartTime");
                        emphr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        emphr = 0;
                        break;
                }

                totalemphr += emphr;
                Console.WriteLine("total days {0}:", totalworkingday + " emp hour " + emphr);

            }
            int totalempwage = totalemphr * this.EmpRateprhr;
            Console.WriteLine("total employee wage : {0}", totalempwage);
        }
        public string toString()
        {
            return "total emp wage for company:" + this.company + " is" + totalEmpWage;
        }
    }
}
