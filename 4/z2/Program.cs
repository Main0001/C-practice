using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter x value : ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Expression result = {Expression(x)}");
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


            static double Expression(double x)
            {
                try
                {
                    if ((x > -5) && (x < -1)) return Math.Round(Math.Pow(x, 3),4);
                    else if (x >= -1) return Math.Round(x / (5 * x + 5),4);
                    else throw new Exception($"Value '{x}' is not in range!");
                }
                catch (DivideByZeroException)
                {
                    throw new DivideByZeroException();
                }

            }
        }
    }
}
