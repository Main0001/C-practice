using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW7_2
{
    public enum Position : int
    {
        ChiefExecutiveOfficer = 36,
        ChiefOperatingOfficer,
        ChiefFinancialOfficer,
        ChiefMarketingOfficer,
        ExecutiveAssistant,
        VicePresident = 5,
        President,
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(Position)))
                Console.WriteLine($"{Enum.GetName(typeof(Position), i)}, {i}");
            Console.ReadLine();
        }
    }
}
