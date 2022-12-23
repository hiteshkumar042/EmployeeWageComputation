using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    //UC-6 Refactoring the code, Created new class and added class variable, accessed from main method
    public class EmpWageComp
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static int empHrs = 0;
        static int empWage = 0, totalWage = 0, day = 1, totalHrs = 0;
    
        public static void GetEmpWage()
        {
            //UC-1 Check employee present or not
            Random random = new Random();
            //UC-6 Wage for 20 Working days or 100 Hrs
            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
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
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for {0} days:{1} and Hrs:{2}", (day - 1), totalWage, (totalHrs - empHrs));
        }
    }
}
