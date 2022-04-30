using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_UsingSwitchCase
{
    class UsingSwitchCase
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        public int Wage_Per_Hours = 20;
        public int empHrs = 0;
        public int EmployeeWage;
        public void Attendance()
        {
            // Stroing RandomValue
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //Switch Case
            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    break;

                case 2: 
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }

            // Calculate
            EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine("Employee wage: " + EmployeeWage);
        }
    }
}
