using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            employee.Quit();

            IQuittable quitter = new Employee();           
            quitter.Quit();
        }
    }
}