Console.WriteLine("Enter cost of notebook: ");
decimal nbkCost = decimal.Parse(Console.ReadLine());
Console.WriteLine("Enter cost of cover: ");
decimal cvrCost = decimal.Parse(Console.ReadLine());
Console.WriteLine("Enter count of kits: ");
int kitsCount = int.Parse(Console.ReadLine());

decimal price = (nbkCost + cvrCost) * kitsCount;

Console.WriteLine($"Finial price: {price}");