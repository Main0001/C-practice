using System;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            double gasConsumption, gasPrice, cost;
            Console.WriteLine("Price of trip to cottage.");
            Console.Write("Distance to cottage (km) --> ");
            distance = int.Parse(Console.ReadLine());
            Console.Write("Consumtion of gas (liters to 100 km mileage) --> ");
            gasConsumption = Double.Parse(Console.ReadLine());
            Console.Write("Litere of gas price (Rub) --> ");
            gasPrice = Double.Parse(Console.ReadLine());
            cost = 2 * (((gasConsumption / 100) * distance) * gasPrice);
            Console.WriteLine($"Price of trip to cottage costs in {Math.Round(cost,2)} Rub");
            Console.ReadLine();
        }
    }
}
