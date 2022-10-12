namespace Day_8_EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Empwage");
            

            EmployeeAttendence employeeAttendence = new EmployeeAttendence();
            employeeAttendence.CheckEmployeeAttendance();

            CalculateEmpWage calculateEmpWage = new CalculateEmpWage();
            calculateEmpWage.ToCalculateEmpWage();

            PartTimeEmpwage partTimeEmpWage = new PartTimeEmpwage();
            partTimeEmpWage.ToCalculateEmpWage();

            SwitchCase sw = new SwitchCase();
            sw.ToCalculateEmpWage();

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.ToCalculateEmpWage();

            TotalEmpWage totalEmpWage = new TotalEmpWage();
            totalEmpWage.ToCalculateEmpWage();
        }
    }
}