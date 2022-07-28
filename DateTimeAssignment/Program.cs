using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {        
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please, select a number?");
            int numberSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1}hrs = {2} ", now, numberSelected, now.AddHours(numberSelected));

            Console.ReadLine();
        }
    }
}