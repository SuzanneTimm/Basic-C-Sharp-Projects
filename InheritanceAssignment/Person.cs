using System;

namespace InheritanceAssignment
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:" + Firstname + " " + Lastname);
            Console.ReadLine();
        }
    }
}
