using System;
using System.Collections.Generic;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Deane", "Hubba"));
            employees.Add(new Employee(2, "Leghorn", "Foghorn"));
            employees.Add(new Employee(3, "Randy", "Dandy"));
            employees.Add(new Employee(4, "Bello", "Cello"));
            employees.Add(new Employee(5, "Joe", "Bing"));
            employees.Add(new Employee(6, "Henry", "Cavill"));
            employees.Add(new Employee(7, "Susie", "Cutie"));
            employees.Add(new Employee(8, "Datz", "Daone"));
            employees.Add(new Employee(9, "Joe", "Blow"));
            employees.Add(new Employee(10, "Bob", "Apples"));

            PrintEmployees("Original Employee List", employees);

            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {               
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            PrintEmployees("List of Joes using foreach.", joes);

            List<Employee> joes2 = employees.FindAll(e => e.FirstName == "Joe");
            PrintEmployees("List of Joes using Lambda.", joes2);

            List<Employee> greaterThanFive = employees.FindAll(e => e.Id > 5 );
            PrintEmployees("List of employees with id greater than 5.", greaterThanFive);
        }

        static void PrintEmployees ( string msg, List<Employee> list)
        {
            Console.WriteLine(msg);
            Console.WriteLine(new String('-', msg.Length));
            list.ForEach(e => Console.WriteLine(e.FirstName + " " + e.LastName + ", Id = " + e.Id));
            Console.WriteLine();
        }
    }
}