using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmpWage
{
    public class PartTimeEmpwage
    {
        public void ToCalculateEmpWage()
        {
            int Is_FullTime = 1;
            int Is_PartTime = 2;
            int EmpWage_PerHr = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == Is_FullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == Is_PartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EmpWage_PerHr;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
