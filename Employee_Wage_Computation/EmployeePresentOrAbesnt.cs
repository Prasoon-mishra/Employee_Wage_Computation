using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    public class EmployeePresentOrAbesnt
    {
        public void PresentOrAbsent()
        {
            int Is_Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }

        }

    }
}
