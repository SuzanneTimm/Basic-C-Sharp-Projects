using System;
using System.Linq;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following information to create a student.");
            Console.WriteLine();
            Console.Write("First Name ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name ");
            string lastName = Console.ReadLine();
            Console.Write("Date of Birth ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Email ");
            string email = Console.ReadLine();

            var student = new Student {
                Id = Guid.NewGuid(),
                FirstName = firstName, 
                LastName = lastName,
                BirthDate = birthdate,
                Email = email };

            using (var db = new StudentContext())
            {
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.LastName, s.FirstName
                            select s;

                Console.WriteLine();
                Console.WriteLine("These are the students in the database.");
                foreach (var std in query)
                {
                    Console.WriteLine(std.FirstName + " " + std.LastName);
                }
            }
        }
    }
}
