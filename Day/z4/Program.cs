Console.WriteLine("Enter r1");
int r1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter r2");
int r2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter r3");
int r3 = int.Parse(Console.ReadLine());

double resistance = 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3);

Console.WriteLine($"Resistance: {Math.Round(resistance, 3)} Ohm");

