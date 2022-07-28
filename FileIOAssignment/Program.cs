using System;
using System.IO;


namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number please?");
            string numberSelected = Console.ReadLine();
            File.WriteAllText("Number.txt", numberSelected);
            string fromFile = File.ReadAllText("Number.txt");
            Console.WriteLine(fromFile);
            Console.ReadLine();
        }
    }
}