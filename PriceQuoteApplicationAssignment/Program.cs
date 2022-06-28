using System;

namespace PriceQuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();

            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length");
            int length = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    
            }
            else if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double cost = height * width * length * weight / 100;
                Console.WriteLine("Your estimate total for shipping this package is: $" + cost);
                Console.WriteLine("Thank you.");
            }



            

         


        }
    }
}
