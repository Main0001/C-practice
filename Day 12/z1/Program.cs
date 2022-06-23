using System;

namespace z1
{
    public class Automobile
    {
        public String Name { get; set; }
        public Automobile()
        {
            Name = "Car";
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
        public virtual double GasConsumption()
        {
            return 0;
        }
    }

    public class Truck : Automobile
    {
        public double p { get; set; }
        public Truck(double P)
        {
            this.p = P;
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Consumption on 100km: " + GasConsumption());
            Console.WriteLine("");
        }
        public override double GasConsumption()
        {
            return Math.Round(Math.Sqrt(p) * 100, 4);
        }
    }

    public class Car : Automobile
    {
        public double V { get; set; }
        public Car(double v)
        {
            this.V = v;
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Gas consumption: " + GasConsumption());
            Console.WriteLine("");
        }
        public override double GasConsumption()
        {
            return Math.Round(2.5 * V, 2);
        }
    }
    class Program
    {
        public static void Main()
        {
            double p, v; string k; int R;
            Console.WriteLine("Enter amount of auto: ");
            R = Convert.ToInt32(Console.ReadLine());
            Automobile[] Autos = new Automobile[R];
            for (int i = 0; i < R; i++)
            {
                Console.WriteLine("Auto type:\n1 - Truck\n2 - Car\nEnter type: ");
                k = Console.ReadLine();
                if (k == "1")
                {
                    Console.WriteLine("Enter load capacity: ");
                    p = Convert.ToInt32(Console.ReadLine());
                    Autos[i] = new Truck(p);
                    Console.WriteLine("Gas consumption on 100km - " + " " + Autos[i].GasConsumption());
                }
                else if (k == "2")
                {
                    Console.WriteLine("Enter engine volume: ");
                    v = Convert.ToInt32(Console.ReadLine());
                    Autos[i] = new Car(v);
                    Console.WriteLine("Gas consumption on 100km - " + " " + Autos[i].GasConsumption());
                }
                else if (k != "1" || k != "2")
                {
                    Console.WriteLine("Invalid vehicle type!");
                }
            }

            double sum = 0;
            for (int i = 0; i < R; i++)
            {
                sum += Autos[i].GasConsumption();
            }
            Console.WriteLine($"Total gas consumption - {Math.Round(sum, 4)}");
            Console.ReadLine();
        }
    }
}
