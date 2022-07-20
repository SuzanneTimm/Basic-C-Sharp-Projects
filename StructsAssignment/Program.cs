using System;

namespace StructsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numbers = new Number();
            numbers.Amount = 10.10m;
            Console.WriteLine(numbers.Amount);
            Console.ReadLine();
        }
    }
}
