using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Logic Assignment");
            Console.WriteLine(0);

            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Have you ever had a DUI? ");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.Write("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool qualifies = age > 15 && !dui && tickets < 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifies);

            

        }
    }
}
