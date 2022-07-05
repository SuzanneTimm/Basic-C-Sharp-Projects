using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignmentPartOne();
            AssignmentPartTwo();
            AssignmentPartThree(); 
            AssignmentPartFour(); 
            AssignmentPartFive(); 
            AssignmentPartSix();
        }

        static void AssignmentPartOne()
        {
            Console.WriteLine("Assignment Part 1");

            // 1.
            string[] strArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // 2.
            Console.WriteLine("What do you want to add to each string?");
            string input = Console.ReadLine();

            // 3.
            for (int loop = 0; loop < strArray.Length; loop++)
            {
                strArray[loop] = strArray[loop] + input;
            }

            // 4.
            for (int loop = 0; loop < strArray.Length; loop++)
            {
                Console.WriteLine(strArray[loop]);
            }

            Console.WriteLine();
        }

        static void AssignmentPartTwo()
        {
            Console.WriteLine("Assignment Part 2");

            // 1.
            /*
            for (int loop = 0; loop < 10; loop += 0)
            {
                Console.WriteLine("Look at me, I'm infinite!");
            }
            */

            // 3.
            for (int loop = 0; loop < 10; loop ++)
            {
                Console.WriteLine("Look at me, I'm not infinite!");
            }

            Console.WriteLine();
        }




        static void AssignmentPartThree()
        {
            Console.WriteLine("Assignment Part 3");

            // 1.
            Console.WriteLine("Using for loop with < comparison");
            for (int loop = 0; loop < 5; loop++)
            {
                Console.WriteLine("Loop = " + loop);
            }

            // 3.
            Console.WriteLine("Using for loop with <= comparison");
            for (int loop = 0; loop <= 5; loop++)
            {
                Console.WriteLine("Loop = " + loop);
            }

            Console.WriteLine();
        }

        static void AssignmentPartFour()
        {
            Console.WriteLine("Assignment Part 4");

            // 1.            
            List<string> strList = new List<string>();
            strList.Add("Rose");
            strList.Add("Tulip");
            strList.Add("Pansy");
            strList.Add("Sunflower");

            // 2.
            Console.WriteLine("Enter the name of a flower.");
            string input = Console.ReadLine();

            // 3. and 4.
            bool foundFlower = false;
            for (int loop = 0; loop < strList.Count; loop++)
            {
                if (input == strList[loop])
                {
                    Console.WriteLine("Found your flower at index " + loop);
                    foundFlower = true;
                    // 5. 
                    break;
                }
            }

            // 4.
            if (!foundFlower)
            {
                Console.WriteLine("We did not find the flower. ");
            }

            Console.WriteLine();
        }

        static void AssignmentPartFive()
        {
            Console.WriteLine("Assignment Part 5");

            // 1a. 
            List<string> strList = new List<string>();
            strList.Add("Spoon");
            strList.Add("Fork");
            strList.Add("Knife");
            strList.Add("Spatula");
            strList.Add("Fork");
            strList.Add("Ladel");

            // 1b.
            Console.WriteLine("Enter the name of a kitchen utensil.");
            string utensil = Console.ReadLine();

            // 2. and 3.
            bool foundUtensil = false;
            for (int loop = 0; loop < strList.Count; loop++)
            {
                if (utensil == strList[loop])
                {
                    Console.WriteLine("Found your utensil at index " + loop);
                    foundUtensil = true;                  
                }
            }

            // 3.
            if (!foundUtensil)
            {
                Console.WriteLine("We did not find the utensil. ");
            }

            Console.WriteLine();
        }

        static void AssignmentPartSix()
        {
            Console.WriteLine("Assignment Part 6");

            // 1a. 
            List<string> strList = new List<string>();
            strList.Add("Spoon");
            strList.Add("Fork");
            strList.Add("Knife");
            strList.Add("Spatula");
            strList.Add("Fork");
            strList.Add("Ladel");

            // 2.
            foreach (string utensil in strList)
            {
                int count = 0;
                foreach (string utensil2 in strList)
                {
                    if (utensil == utensil2)
                    {
                        count++;
                    } 
                }
                if (count > 1)
                {
                    Console.WriteLine("Found " + utensil + " "+ count + " times.");
                }
            }

            Console.WriteLine();
        }
    }
}

           