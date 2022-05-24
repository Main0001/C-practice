int number = int.Parse(Console.ReadLine());

if (number % 2 == 1 && number.ToString().Length == 3)
    Console.WriteLine("This is odd 3-digit number");
else Console.WriteLine("This is not odd 3-digit number");
