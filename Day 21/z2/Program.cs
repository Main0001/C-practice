Task[] tasks = new Task[2];

Console.Write("Введит a: ");
double a = Convert.ToDouble(Console.ReadLine());

double z1 = 0;
tasks[0] = Task.Run(() =>
{
    a = a * Math.PI / 180;
    z1 = Math.Sin(4 * a) / (1 + Math.Cos(4 * a)) * (Math.Cos(2 * a) / (1 + Math.Cos(2 * a)));
});

tasks[0].Wait();
Console.WriteLine($"z1 = {z1}");

double z2 = 0;
tasks[1] = Task.Run(() =>
{
    z2 = Math.Tan(a); //ctg(3/2*pi - x) = tan(x)
    Thread.Sleep(3000);
});

tasks[1].Wait();
Console.WriteLine($"z2 = {z2}");