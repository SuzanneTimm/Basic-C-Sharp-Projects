using System;

namespace ClassMethodAssignment
{
    public static class MyStaticClass
    {
        public static void DoSomething (int num)
        {
            Console.WriteLine("This is your integer " + num);
        }

        public static void DoSomething(string str)
        {
            Console.WriteLine("This is your string " + str);
        }
    }
}
