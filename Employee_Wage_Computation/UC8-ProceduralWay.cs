using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    internal class UC8_ProceduralWay
    {
        public void SalaryForParticularCondition()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;
            int WorkingDays = 20;
            int TotalWage = 0;
            int Maximum_Hrs_in_month = 100;
            int total_working_days = 0;
            int total_emp_hrs = 0;

            while (total_working_days < WorkingDays && empHrs < Maximum_Hrs_in_month)
            {
                total_working_days++;
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
                total_emp_hrs += empHrs;
                Console.WriteLine("total working days" + total_working_days + "total employee hours:" + total_emp_hrs);
            }
            TotalWage = total_emp_hrs * Emp_rate_per_hour;
            Console.WriteLine("The monthly wage of employee is : " + TotalWage);
        }
    }
}
