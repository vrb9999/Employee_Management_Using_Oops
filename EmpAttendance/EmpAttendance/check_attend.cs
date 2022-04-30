using System;
using System.Collections.Generic;
using System.Text;

namespace EmpAttendance
{
    class check_attend
    {
        readonly int present = 1;
        public int check;

        public void attendance()
        {
            Random random = new Random();
            check = random.Next(0, 2);
            if (check == present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
