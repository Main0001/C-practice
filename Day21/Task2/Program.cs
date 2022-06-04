Task[] tasks = new Task[2];

Console.Write("Введит a: ");
double a = Convert.ToDouble(Console.ReadLine());

double z1 = 0;
tasks[0] = Task.Run( () =>
{
    a = a * Math.PI / 180;
    z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - (2 * Math.Pow(Math.Sin(2 * a), 2)));
});

tasks[0].Wait();
Console.WriteLine($"z1 = {z1}");

double z2 = 0;
tasks[1] = Task.Run(() =>
{
    z2 = 2 * Math.Sin(a);
    Thread.Sleep(3000);
});

tasks[1].Wait();
Console.WriteLine($"z2 = {z2}");