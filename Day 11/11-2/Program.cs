using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
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
                while (a < 10)
                {
                    sum += b + d;
                    a++;
                }
                return sum;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(0, 10, 2); // new B (a, b, d)
            Console.WriteLine(b.c2);
            Console.ReadLine();
        }
    }
}
