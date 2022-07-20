using System;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1234;
            employee.Firstname = "Sample";
            employee.Lastname = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}

