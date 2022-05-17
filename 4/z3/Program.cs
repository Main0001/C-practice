using System;
using System.Linq;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter A1 value: ");
                    double A = int.Parse(Console.ReadLine());
                    Console.Write("Enter B1 value: ");
                    double B = int.Parse(Console.ReadLine());
                    Console.Write("Enter C1 value: ");
                    double C = int.Parse(Console.ReadLine());
                    SortInc3(ref A, ref B, ref C);
                    Console.WriteLine($"Sorted values: \nA - {A} \nB - {B} \nC - {C}");

                    Console.Write("Enter A2 value: ");
                    A = int.Parse(Console.ReadLine());
                    Console.Write("Enter B2 value: ");
                    B = int.Parse(Console.ReadLine());
                    Console.Write("Enter C2 value: ");
                    C = int.Parse(Console.ReadLine());
                    SortInc3(ref A, ref B, ref C);
                    Console.WriteLine($"Sorted values: \nA - {A} \nB - {B} \nC - {C}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format exception (value cannot be a letter, please, enter number)");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide by zero (Value cannot be divided by zero)");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error! {e}");
                }
            }


            static void SortInc3(ref double A, ref double B, ref double C)
            {
                double[] mass = { A, B, C };
                double[] ordered = mass.OrderBy(x => x).ToArray();
                A = ordered[0];
                B = ordered[1];
                C = ordered[2];
            }
        }
    }
}
