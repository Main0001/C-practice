int x = int.Parse(Console.ReadLine());
if(x <= 1)
{
    double y = 2 * Math.Cos(x) + 3 * Math.Pow(x, 2);
    Console.WriteLine(y);
}
else
{
    double y = 2 * Math.Log(x) + Math.Pow(1 + Math.Pow(x, 2), 1/2);
    Console.WriteLine(y);
}
