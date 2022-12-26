namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        static void Main(string[] args)
        {
            EmpWageBuilderObject meta = new EmpWageBuilderObject("Meta",30, 25, 70);
            meta.ComputeEmpWage();
            Console.WriteLine(meta.ToString());
            EmpWageBuilderObject amazon = new EmpWageBuilderObject("Amazon", 25, 20, 60);
            amazon.ComputeEmpWage();
            Console.WriteLine(amazon.ToString());
            EmpWageBuilderObject google = new EmpWageBuilderObject("Google", 28, 28, 60);
            google.ComputeEmpWage();
            Console.WriteLine(google.ToString());

        }
    }
}