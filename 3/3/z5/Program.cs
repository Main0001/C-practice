using System;
using z5.Modules;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {

            Plane plane = new Plane("Tokyo", 771199, new DateTime(2022, 07, 20, 18, 35, 5));

            Console.WriteLine($"Destination town: {plane.destination}");
            Console.WriteLine($"Plane ID: {plane.number}");
            Console.WriteLine($"Departure time {plane.time}");
        }
    }
}
