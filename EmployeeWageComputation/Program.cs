namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            GetEmpWage("Meta",30, 25, 70);
            GetEmpWage("Amazon", 25, 20, 60);
            GetEmpWage("Google", 28, 28, 60);

            Console.ReadLine();
        }
        public static void GetEmpWage(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            int empWage = 0, totalWage = 0, day = 1, empHrs = 0, totalHrs = 0;
            //UC-1 Check employee present or not
            Random random = new Random();
            //UC-6 Wage for 20 Working days or 100 Hrs
            while (day <= maxWorkingDays && totalHrs <= maxWorkingHrs)
            {
                int employeeInput = random.Next(0, 3);
                //UC-4- Switch case
                switch (employeeInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //UC-2 calculate EmployeeWage
                empWage = empRatePerHr * empHrs;
                totalWage += empWage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("{0} : Total wage for {1} days:{2} and Hrs:{3}", company, (day - 1), totalWage, (totalHrs - empHrs));
        }
    }
}