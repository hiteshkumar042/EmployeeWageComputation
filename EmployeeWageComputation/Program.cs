namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            //Emp Attandance - UC1
            const int EMP_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int randomInput = random.Next(0, 2);
            if (randomInput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empWage = 0;
            }
            //UC-2 calculate Employee Wage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is :" + empWage);
        }
    }
}