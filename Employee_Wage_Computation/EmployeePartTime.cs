using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    internal class EmployeePartTime
    {
        public void EmployeeType()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Eployee is full time Employee");
            }
            else if(empCheck == Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("Eployee is Part time Employee");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Eployee is Absent");
            }
            empWage = empHrs * Emp_rate_per_hour;
            Console.WriteLine("The daily wage of employee is" + empWage);
        }
    }
}
