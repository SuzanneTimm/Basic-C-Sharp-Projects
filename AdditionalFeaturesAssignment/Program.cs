using System;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {           

            const string myIdentity = "Suzanne";
            Console.WriteLine("Hello, {0}.", myIdentity);

            var identity = new Identity(myIdentity);           
            Console.WriteLine(identity.id);
            Console.WriteLine(identity.name);
            Console.ReadLine();
        }
    }
}