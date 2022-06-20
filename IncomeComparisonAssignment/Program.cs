using System;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Assignment");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.Write("  Hourly Rate ");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("  Hours Worked Per Week ");
            decimal person1HoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.Write("  Hourly Rate ");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("  Hours Worked Per Week ");
            decimal person2HoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 1");
            decimal person1AnnualSalary = person1HourlyRate * person1HoursWorked * 52;
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2");
            decimal person2AnnualSalary = person2HourlyRate * person2HoursWorked * 52;
            Console.WriteLine(person2AnnualSalary);

            Console.WriteLine();
            bool person1MakesMoreThanPerson2 = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMoreThanPerson2);
        }
    }
}
