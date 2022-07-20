using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things1 = new Employee<string>();
            things1.Things = new List<string>() { "books", "cars", "trucks" };

            Employee<int> things2 = new Employee<int>();
            things2.Things = new List<int>() { 1, 2, 3, 4 };

            foreach (string items1 in things1.Things)
            {
                Console.WriteLine(items1);
            }

            foreach (int items2 in things2.Things)
            {
                Console.WriteLine(items2);
            }
            Console.ReadLine();
        }
    }
}
