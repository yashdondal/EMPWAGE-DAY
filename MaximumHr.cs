using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmpWage
{
    public class MaximumHr
    {
        public static int WAGE_PER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int ABSENT = 0;
        public const int NumofWorkingDay = 20;
        public const int Maximumhr = 100;

        public void monthlywages()
        {
            //variable
            int emphr = 0;
            //int Empwage = 0;
            //int totalempwage = 0;
            int totalemphr = 0;
            int totalworkingday = 0;

            while (totalemphr <= Maximumhr && totalworkingday < NumofWorkingDay)
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
                Console.WriteLine(totalemphr);
                Console.WriteLine("total days {0}:", totalworkingday + " emp hour " + emphr);

            }
            int totalempwage = totalemphr * WAGE_PER_HR;
            Console.WriteLine("total employee wage : {0}", totalempwage);
        }
    }
}
