using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College.");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            Console.Write("What course are you in? ");
            string course = Console.ReadLine();

            Console.Write("What page number? ");
            int page = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Do you need anything? Please answer \"true\" or \"false\" ");
            bool needSomething = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Were there any positive experiences you'd like to share? Please give specifics. ");
            string positiveExperience = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");







        }
    }
}
