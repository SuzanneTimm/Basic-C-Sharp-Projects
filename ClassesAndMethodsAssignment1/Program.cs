using System;

namespace ClassesAndMethodsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take a number and add 10.");
            int num = Convert.ToInt32(Console.ReadLine());

            MyMath math = new MyMath();            
            
            int numPlus10 = math.AddTen(num);
            Console.WriteLine(numPlus10);

            Console.WriteLine("Enter a decimal number.");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            numPlus10 = math.AddTen(num2);
            Console.WriteLine(numPlus10);

            Console.WriteLine("Enter a string. ");
            string str = Console.ReadLine();

            numPlus10 = math.AddTen(str);
            Console.WriteLine(numPlus10);





        }
    }
}
