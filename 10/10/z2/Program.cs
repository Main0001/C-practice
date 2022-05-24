using System;

namespace z2
{
    class A
    {
        protected int a;
        protected int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public A()
        {
            this.a = default(int);
            this.b = default(int);
        }
    }

    class B : A
    {
        private int d;
        public B(int a, int b, int d)
            : base(a, b)
        {
            this.d = d;
        }
        public B(int d)
        {
            this.d = d;
        }
        public int c2
        {
            get
            {
                var sum = 0;
                do
                {
                    sum += b + d;
                    a++;
                } while (a < 10);
                return sum;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(1, 16, 5);
            Console.WriteLine($"Expression result: {b.c2}");
            Console.ReadLine();
        }
    }
}
