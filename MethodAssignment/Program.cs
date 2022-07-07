using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to use for math operations?");
            int num = Convert.ToInt32(Console.ReadLine());

            MyMath math = new MyMath();
            int numTimes10 = math.MultiplyByTen(num);
            int numDiv10 = math.DivideByTen(num);
            int numSquared = math.Squared(num);

            Console.WriteLine(num + " times 10 = " + numTimes10);
            Console.WriteLine(num + " divided by 10 = " + numDiv10);
            Console.WriteLine(num + " squared = " + numSquared);
        }
    }   
}
