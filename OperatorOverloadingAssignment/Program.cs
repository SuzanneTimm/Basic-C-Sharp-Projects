using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Suzanne";
            example.LastName = "Timm";
            example.ID = 123;

            Employee example2 = new Employee();
            example2.FirstName = "Hank";
            example2.LastName = "van Tunen";
            example2.ID = 456;
            
        }
    }
}
