int n = int.Parse(Console.ReadLine());
int sum = 0;
int countX = 0;
int countY = 0;

Random rnd = new Random();
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(-50,50);
    if (array[i] > 0)
    {
        sum += array[i];
    }
    else if (array[i] < 0) countX++;
    else countY++;
    Console.WriteLine($"{array[i]}, Sum {sum}, Count {countX}, Count 0 {countY}");
}

