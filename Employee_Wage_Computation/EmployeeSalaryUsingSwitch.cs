using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    internal class EmployeeSalaryUsingSwitch
    {
        public void EmployeeSwitch()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch(empCheck)
            {
                case 1: empHrs = 8;
                    break;
                case 2: empHrs = 4;
                    break;
                default:empHrs = 0;
                    break;
            }
            empWage = empHrs*Emp_rate_per_hour;
            Console.WriteLine("The daily wage of employee is : " + empWage);

        }
    }
}
