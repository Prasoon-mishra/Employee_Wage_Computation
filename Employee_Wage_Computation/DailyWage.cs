using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    public class DailyWage
    {
        public void DailyWageCalculation()
        {
            int Is_Full_Time = 1;
            int Emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                empHrs=8;
            }
            else
            {
                empHrs=0;
            }
            empWage = empHrs * Emp_rate_per_hour;
            Console.WriteLine("The daily wage of employee is" + empWage);
        }
    }
}
