using System;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = 67;
            double gasConsumption = 8.5, gasPrice = 6.5, cost;
            Console.WriteLine("Price of trip to cottage.");
            Console.WriteLine($"Distance to cottage (km) --> {distance}");
            Console.WriteLine($"Consumtion of gas (liters to 100 km mileage) --> {gasConsumption}");
            Console.WriteLine($"Litere of gas price (Rub) --> {gasPrice}");
            cost = 2 * (((gasConsumption / 100) * distance) * gasPrice);
            Console.WriteLine($"Price of trip to cottage costs in {Math.Round(cost,2)} Rub");
            Console.ReadLine();
        }
    }
}
