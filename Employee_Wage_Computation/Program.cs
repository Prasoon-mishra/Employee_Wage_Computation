namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation Program");
            Console.WriteLine("Enter 1 to check whether employee present or not");
            Console.WriteLine("Enter 2 to check the daily wage of an employee");
            Console.WriteLine("Enter 3 to check the employemet type of an employee");
            Console.WriteLine("Enter 4 to check dailywage using Switch ");
            Console.WriteLine("Enter 5 to check monthly wage using switch ");
            Console.WriteLine("Enter 6 to check monthly wage  and a certain condition using switch ");
            Console.WriteLine("Enter 7 to check the salary for multiple companies");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch(ans)
            {
                case 1: 
                    EmployeePresentOrAbesnt empPresntAbsent = new EmployeePresentOrAbesnt();
                    empPresntAbsent.PresentOrAbsent();
                    break;
                case 2:
                    DailyWage empWage = new DailyWage();
                    empWage.DailyWageCalculation();
                    break;
                case 3:
                    EmployeePartTime employeePartTime = new EmployeePartTime();
                    employeePartTime.EmployeeType();
                    break;
                case 4:
                    EmployeeSalaryUsingSwitch employeeSalaryUsingSwitch = new EmployeeSalaryUsingSwitch();
                    employeeSalaryUsingSwitch.EmployeeSwitch();
                    break;
                case 5:
                    WageForMonth empageForMonth = new WageForMonth();   
                    empageForMonth.SalaryPerMonth();
                    break;
                case 6:
                    WageUC6 wageUC6 = new WageUC6();
                    wageUC6.SalaryForParticularCondition();
                    break;
                case 7:
                    WageForMultipleCompanies wageForMultipleCompanies = new WageForMultipleCompanies();
                    wageForMultipleCompanies.MultipleCompanies("Cognizant", 200, 20, 100);
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}