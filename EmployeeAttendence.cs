using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmpWage
{
    public class EmployeeAttendence
    {
        public void CheckEmployeeAttendance()
        {
            int Is_FullTime = 1;
            Random random = new Random();
            int emplCheck = random.Next(0, 2);

            if (emplCheck == 1)
            {
                Console.WriteLine("Empolyee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
