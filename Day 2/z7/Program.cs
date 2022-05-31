string[] maleNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
string[] femaleNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

string choice = Console.ReadLine();

if (choice ==  "M" || choice == "m")
{
    for(int i = 0; i < maleNames.Length; i++)
    {
        Console.Write($"{maleNames[i]} ");
    }
}
else if (choice == "F" || choice == "f")
{
    for (int i = 0; i < maleNames.Length; i++)
    {
        Console.Write($"{femaleNames[i]} ");
    }
}
else
{
    Console.WriteLine("None");
}
