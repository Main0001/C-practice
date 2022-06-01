using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLib;

namespace testProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Triangle(4, 5, 6);
            figure1.ShowInfo();
            figure1.Area();
            figure1.Perimeter();
            Console.WriteLine(figure1.GetType());

            Figure figure3 = new Rectangle(5, 6);
            figure3.ShowInfo();

            Console.ReadLine();
        }
    }
}
