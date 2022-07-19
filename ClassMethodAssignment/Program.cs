using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            math.DivideByTwo(num);

            int result;
            math.DivideByThree(num, out result);
            Console.WriteLine("Your number divided by three is " + result);

            MyStaticClass.DoSomething(123);
            MyStaticClass.DoSomething("Hello");
        }
    }
}
