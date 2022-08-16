namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation Program");
            Console.WriteLine("Enter 1 to check whether employee present or not");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch(ans)
            {
                case 1: 
                    EmployeePresentOrAbesnt empPresntAbsent = new EmployeePresentOrAbesnt();
                    empPresntAbsent.PresentOrAbsent();
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}