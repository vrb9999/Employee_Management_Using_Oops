using System;

namespace EmpDailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //Emp is Present Or Absent
            DailyWage EmployeeWage = new DailyWage();
            EmployeeWage.Attendance();
        }
    }
}
