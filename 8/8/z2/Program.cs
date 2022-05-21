using System;

namespace ex2
{
    public enum PositionWorkTime : int
    {
        CEO = 101,
        Accountant = 45,
        Designer = 66,
        Art_Manager = 69,
        Admin = 89,
        Merchandiser = 55,
        Ceo_Deputy = 90,
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Employee work time: ");
            foreach (int i in Enum.GetValues(typeof(PositionWorkTime)))
                Console.WriteLine($"{Enum.GetName(typeof(PositionWorkTime), i)}, {i}" + " hrs");    
        }
    }
}