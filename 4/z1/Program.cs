using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter x value: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine($"First Expression result = {FirstExpression(x)}");
                    Console.WriteLine($"Second Expression result = {SecondExpression(x)}");
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


            static double FirstExpression(double x)
            {
                try
                {
                    return Math.Round(((Math.Pow(x, 2) - 3) / (Math.Pow(x, 2) - 4)), 4);
                }
                catch (Exception)
                {
                    throw new DivideByZeroException();
                }

            }

            static double SecondExpression(double x)
            {
                try
                {
                    return Math.Round((Math.Log10(x) / (x - 1)), 4);
                }
                catch (Exception)
                {
                    throw new DivideByZeroException();
                }

            }
        }
    }
}
