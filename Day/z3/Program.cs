const float x = 6.4f;
const float e = 2.71f;
const float pi = 3.14f;

double y = x * Math.Pow(e, Math.Pow(x, 2)) - (Math.Sin(Math.Sqrt(x) + Math.Cos(Math.Pow(Math.Log(x), 2)))) / (Math.Sqrt(Math.Abs(1 - pi * x)));

Console.WriteLine($"y: {y}");