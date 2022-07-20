using System;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DaysOfTheWeek theDays = new DaysOfTheWeek();
                Console.WriteLine("What is the current day of the week?");
                string daySelected = Console.ReadLine();

                var theDay = Enum.Parse(typeof(DaysOfTheWeek), daySelected, true);
                DaysOfTheWeek parsedEnumValue = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), daySelected);

                Console.WriteLine("Today is : ", theDay);
                Console.WriteLine("Today is {0}. ", theDay);
                Console.WriteLine(Enum.GetName(typeof(DaysOfTheWeek), theDays));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Unable to convert this to a date. Please enter an actual day of the week. Thank you!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}    
