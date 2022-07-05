using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myValues = new List<int>() { 10, 20, 30, 40, 50 };

                Console.WriteLine("Pick a number.");
                int divider = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < myValues.Count; i++)
                {
                    Console.WriteLine(myValues[i] / divider);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero.");
            }
        }
    }
}
