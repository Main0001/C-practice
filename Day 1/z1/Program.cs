float x, y;
Console.WriteLine("Enter first float number: ");
x = float.Parse(Console.ReadLine());
Console.WriteLine("Enter second float number: ");
y = float.Parse(Console.ReadLine());

Console.WriteLine($"Division of 2 float number {x} and {y} is {Math.Round(x / y, 3)}");

