namespace Task1
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

        static bool Exist(int a, int b, int c)
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

        static int Perimeter(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }

        static double Square(int a, int b, int c)
        {
            double semiPer = (a + b + c) / 2;
            double sqr = Math.Sqrt(semiPer * (semiPer - a) * (semiPer - b) * (semiPer - c));
            return sqr;
        }

        static string TriangleType(int a, int b, int c)
        {
            if (a == b && a == c)
                return "Равносторонний";
            else if (a != b && a != c && b != c)
                return "Разносторонний";
            else return "Равнобедренный";
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

        static int Perimeter(int a, int b)
        {
            int result = 2 * (a + b);
            return result;
        }

        static double Square(int a, int b)
        {
            double sqr = a * b;
            return sqr;
        }
    }
}