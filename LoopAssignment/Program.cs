using System;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerNumber = 42;
            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.WriteLine("Guess which number I am thinking of?");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == computerNumber)
                {
                    isGuessed = true;
                }
                else if (number < computerNumber)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("Guess lower.");
                }
            }
            Console.WriteLine("You guessed the number!");

            Console.WriteLine("I am thinking of another number. Can you guess it?");

            computerNumber = 23;

            do
            {
                isGuessed = false;
                Console.WriteLine("Guess which number I am thinking of?");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == computerNumber)
                {
                    isGuessed = true;
                }
                else if (number < computerNumber)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("Guess lower.");
                }
            }
            while (!isGuessed);
            Console.WriteLine("You guessed the number!");

        }
    }
}

