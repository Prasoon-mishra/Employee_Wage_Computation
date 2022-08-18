using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    public class WageForMultipleCompanies
    {
        int Is_Full_Time = 1;
        int Is_Part_Time = 2;
        public void MultipleCompanies(string Company, int empRatePerHour, int numberOFWorkingDays, int MaxHourPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (empHrs < MaxHourPerMonth && totalWorkingDays < numberOFWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("total working days" + totalWorkingDays + "total employee hours:" + totalEmpHrs);
            }
            int TotalWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("The monthly wage of employee is : " + TotalWage);
        }
    }
}
