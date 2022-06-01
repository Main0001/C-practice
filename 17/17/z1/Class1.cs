using System;

namespace z1
{
    public class Triangle
    {
        int a;
        int b;
        int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        static bool TriangleExists(int a, int b, int c)
        {
            if (a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Perim(int a, int b, int c)
        {
            int res = a + b + c;
            return res;
        }

        static double Square(int a, int b, int c)
        {
            double p2 = (a + b + c) / 2;
            double S = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            return S;
        }

        static string Type(int a, int b, int c)
        {
            if (a == b && a == c)
                return "Equilateral";
            else if (a != b && a != c && b != c)
                return "Versatile";
            else return "Isosceles";
        }
    }

    public class Rectangle
    {
        int a;
        int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        static int Perim(int a, int b)
        {
            int res = 2 * (a + b);
            return res;
        }

        static double Square(int a, int b)
        {
            double S = a * b;
            return S;
        }
    }
}