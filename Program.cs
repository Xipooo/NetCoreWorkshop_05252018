using System;

namespace NetCoreWorkshop_05252018
{
    class Program
    {
        static void Main(string[] args)
        {
            Person steve = new Person { Id = 1, FirstName = "Steve", LastName="Bishop"};
            Console.WriteLine(steve.getFullName());

            Person amanda = null;
            Console.WriteLine(amanda.getFullName());
        }
    }
}
