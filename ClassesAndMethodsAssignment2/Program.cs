using System;

namespace ClassesAndMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            Console.WriteLine("Enter first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number (this can be blank).");
            string str2 = Console.ReadLine();

            int answer;
            if (str2 == "")
            {
                answer = math.DoAdd(num1);   
            }
            else
            {
                int num2 = Convert.ToInt32(str2);
                answer = math.DoAdd(num1, num2);
            }

            Console.WriteLine("The answer is " + answer);
        }
    }
}
