using System;

namespace z1
{
    class A
    {
        public int a;
        public int b;

        public A(int a_, int b_)
        {
            this.a = a_; this.b = b_;
        }

        public double ExpressionA()
        {
            return (double)((b - 2) / (2 - a));
        }

        public double ExpressionB()
        {
            return (double)(Math.Pow(Math.Sqrt(a), 10));
        }
    }
    class Temp
    {
        static void Main(string[] args)
        {
            A classA = new A(3, 5);
            Console.WriteLine($"First exression (b-2) / (2-a) = {classA.ExpressionA()}");
            Console.WriteLine($"Second expression (sqrt in pow 10 from A) = {Math.Round(classA.ExpressionB(), 4)}");
        }
    }
}
