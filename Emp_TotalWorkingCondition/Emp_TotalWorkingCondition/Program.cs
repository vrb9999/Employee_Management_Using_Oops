using System;

namespace Emp_TotalWorkingCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            WorkingCondition EmployeeWage = new WorkingCondition();
            EmployeeWage.Attendance();
        }
    }
}
