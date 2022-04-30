using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_PartTime
{
    class PartTime
    {
        public int IS_PRESENT = 1;
        public int Wage_Per_Hours = 20;
        // public int Full_Day_Hour = 8;
        readonly int Emp_Full_Time = 2;
        readonly int Emp_Part_Time = 1;
        public int empHrs;
        public int EmployeeWage;
        public void Attendance()
        {
            // Stroing RandomValue
            Random random = new Random();
            int empCheck = random.Next(0, 2); 
            if (empCheck == Emp_Part_Time)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 4; 
            }
            else 
            {
                Console.WriteLine("Employee is Absent"); 
                empHrs = 0; 
            }
            //calculate 
            EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage); 
        }
    }
}
