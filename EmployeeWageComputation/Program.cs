namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            //Emp Attandance - UC1
            const int EMP_PRESENT = 1;
            Random random = new Random();
            int randomInput = random.Next(0, 2);
            if (randomInput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}