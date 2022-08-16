using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    public class WageForMonth
    {
        public void SalaryPerMonth()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            int WorkingDays = 20;
            int TotalWage = 0;
            for(int i = 0; i <= WorkingDays; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                empWage = empHrs * Emp_rate_per_hour;
                TotalWage = TotalWage + empWage;
                

            }
            
            Console.WriteLine("The monthly wage of employee is : " + TotalWage);
        }
    }
}
