using System;

namespace z3
{ 
    class Room
    {
        public double length;
        public double width;
        public double height;
        public int windows;

        public void volume()
        {
            double obj = length * width * height;
            Console.Write($"Room volume: {obj} m3 \n"); ;
        }
        
        public void square()
        {
            double pl = length * width;
            Console.Write($"Room square: {pl} m2 \n");
        }
    }

    class Program
    {

        static void Main()
        {
            Room RoomValues = new Room();
            while (true)
            {
                try
                {
                    Console.Write("Enter room length: ");
                    RoomValues.length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter room width: ");
                    RoomValues.width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter room height: ");
                    RoomValues.height = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter amount of windows: ");
                    RoomValues.windows = Convert.ToInt16(Console.ReadLine());
                    RoomValues.volume();
                    RoomValues.square();
                    Console.Write("Amount of windows: " + RoomValues.windows);
                    break;
                }
                catch
                {
                    Console.WriteLine("Value is incorrect!");
                }
            }
        }
    }
}
