var result = 0;
int i = 0;
int j = 0;
int k = 0;

Console.WriteLine("Цикл For");
for (i = 0; i <= 101; i++) 
{ 
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\nЦикл while");
while (j <= 101)
{
    if (j % 2 != 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

Console.WriteLine("\nЦикл do while");
do
{
    if (k % 2 != 0)
    {
        Console.WriteLine(k);
    }
    k++;
}
while (k <= 101);