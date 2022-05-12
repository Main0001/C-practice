var alpha = 1;

try
{
    var z1 = (Math.Sin((Math.PI / 2) / 3 * alpha)) / (1 - Math.Sin(3 * alpha - Math.PI));
    var z2 = 1 / Math.Tan((5 / 4) * Math.PI + (3 / 2) * alpha);

    Console.WriteLine($"z1 = {z1}");
    Console.WriteLine($"z2 = {z2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}