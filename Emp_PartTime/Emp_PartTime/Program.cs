using System;

namespace Emp_PartTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            PartTime EmployeeWage = new PartTime();
            EmployeeWage.Attendance();
        }
    }
}
