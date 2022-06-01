using System;
using Animals;

Console.WriteLine("Enter animal's data. ");

Console.Write("Enter animal variety: ");
string variety = Console.ReadLine();

Console.Write("Enter what type of food this animal eats: ");
string food = Console.ReadLine();

Console.Write("Enter animal's weight: ");
int weight = int.Parse(Console.ReadLine());

Console.Write("Enter animal's wool color : ");
string color = Console.ReadLine();

Animal inf = new Animal(variety, food, weight, color);

Console.WriteLine(inf.AnimalInfo());