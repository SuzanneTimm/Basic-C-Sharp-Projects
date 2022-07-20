using System.Collections.Generic;

namespace GenericsAssignment
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator != (Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}

