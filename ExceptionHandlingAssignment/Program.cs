using System;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Age can not be less than 1");
                }
                else
                {
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in " + birthYear);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
