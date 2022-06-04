int x = 0;

while (true)
{
    try
    {
        int[] formula = { };
        Console.Write($"Enter num: ");
        x = int.Parse(Console.ReadLine());

        Task[] tasks = new Task[2]
        {
             new Task(() => {
                formula = intParser(x);
                }),
            new Task(() => Console.WriteLine("1"))
         };

        tasks[1] = tasks[0].ContinueWith(task =>
        {
            foreach (var item in formula)
            {
                Console.WriteLine(item);
            }
        });
        tasks[0].Start();

        // ждем окончания второй задачи
        tasks[1].Wait();
        Console.WriteLine("Конец метода Main");

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Some error! ({ex.Message})");
    }
}

static int[] intParser(int num)
{
    var variants = new int[][]
     {
        new int []{ 0, 1, 2},
        new int []{ 0, 2, 1},
        new int []{ 2, 0, 1},
        new int []{ 2, 1, 0},
        new int []{ 1, 2, 0},
        new int []{ 1, 0, 2},
     };
    var digits = new int[] { num / 100, (num % 100) / 10, num % 10 };
    var result = new int[variants.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        var item = variants[i];
        result[i] = digits[item[0]] * 100 + digits[item[1]] * 10 + digits[item[2]];
    }

    return result;
}


