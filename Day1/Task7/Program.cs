int alpha = 45;

try
{
    double z1 = ((Math.Sin(2 * alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha)) / (Math.Cos(alpha) + 1 - 2 * Math.Pow(Math.Sin(2 * alpha), 2)));
    double z2 = 2 * Math.Sin(alpha);
    Console.WriteLine("z1 = " + z1);
    Console.WriteLine("z2 = " + z2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}