using System;

namespace NetCoreWorkshop_05252018
{
    class Program
    {
        static void Main(string[] args)
        {
            Person steve = new Person { FirstName = "Steve", LastName = "Bishop" };
            Console.WriteLine(steve.getInfo());

            Person amanda = null;
            Console.WriteLine(amanda?.getInfo() ?? "Amanda Doesn't Exist");

            // if (amanda != null)
            // {
            //     Console.WriteLine(amanda.getInfo());
            // }
        }
    }
}
