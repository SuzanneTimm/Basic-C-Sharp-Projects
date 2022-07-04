using System;
using System.Collections.Generic;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            bool okay;
            int index;
            string input;

            string[] strArray = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            do
            {
                Console.WriteLine("Which string do you want?");
                input = Console.ReadLine();
                if (int.TryParse(input, out index) && index >= 0 && index < strArray.Length)
                {
                    Console.WriteLine("The string you have chosen is " + strArray[index]);
                    okay = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and " + Convert.ToString(strArray.Length - 1));
                    okay = false;
                }
            } while (!okay);

            Console.WriteLine();

            int[] intArray = new int[] { 11, 22, 33, 44, 55 };
            do
            {
                Console.WriteLine("Which integer do you want?");
                input = Console.ReadLine();
                if (int.TryParse(input, out index) && index >= 0 && index < intArray.Length)
                {
                    Console.WriteLine("The integer you have chosen is " + intArray[index]);
                    okay = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and " + Convert.ToString(intArray.Length - 1));
                    okay = false;
                }
            } while (!okay);

            Console.WriteLine();

            List<string> strList = new List<string>();
            strList.Add("Honda");
            strList.Add("Ford");
            strList.Add("Toyoto");
            strList.Add("Nissan");
            strList.Add("Audi");
            do
            {
                Console.WriteLine("Which string do you want?");
                input = Console.ReadLine();
                if (int.TryParse(input, out index) && index >= 0 && index < strList.Count)
                {
                    Console.WriteLine("The string you have chosen is " + strList[index]);
                    okay = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and " + Convert.ToString(strList.Count - 1));
                    okay = false;
                }
            } while (!okay);
        }
    }
}
