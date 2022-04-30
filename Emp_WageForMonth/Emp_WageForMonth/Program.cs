using System;

namespace Emp_WageForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            WageForMonth EmployeeWage = new WageForMonth();
            EmployeeWage.Attendance();
        }
    }
}
