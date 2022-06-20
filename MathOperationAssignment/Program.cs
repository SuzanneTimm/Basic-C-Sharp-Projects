using System;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operations Assignment");
            Console.WriteLine();

            Console.Write("enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            num = num * 50;
            Console.WriteLine(num);

            Console.Write("enter a number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num2 = num2 + 25;
            Console.WriteLine(num2);

            Console.Write("enter a number ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            num3 = num3 / 12.5;
            Console.WriteLine(num3);

            Console.Write("enter a number ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 > 50)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.Write("enter a number ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            num5 = num5 % 7;
            Console.WriteLine(num5);







        }
    }
}
