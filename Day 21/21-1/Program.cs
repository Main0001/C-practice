var num = 0;

while (true)
{
    try
    {
        Console.Write("Enter num: ");
        num = int.Parse(Console.ReadLine());

        if (num < 100 || num > 999)
        {
            throw new FormatException();
        }
        TaskVariant1(num);
        TaskVariant2(num);
        TaskVariant3(num);
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Some error! ({ex})");
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


void TaskVariant1(int num)
{
    Task ex1 = Task.Run(() =>
    {
        var intVariation = intParser(num);

        Console.WriteLine("Resault: ");
        foreach (var item in intVariation)
        {
            Console.WriteLine($"{item} | Task - 1");
        }

    });
    ex1.Wait();
}




void TaskVariant2(int num)
{
    Task ex2 = Task.Factory.StartNew(() =>
    {
        var intVariation = intParser(num);

        Console.WriteLine("Resault: ");
        foreach (var item in intVariation)
        {
            Console.WriteLine($"{item} | Task - 2");
        }

    });
    ex2.Wait();
}


void TaskVariant3(int num)
{
    Thread.CurrentThread.Name = "Main";

    // Create a task and supply a user delegate by using a lambda expression.
    Task taskA = new Task(() =>
    {
        var intVariation = intParser(num);

        Console.WriteLine("Resault: ");
        foreach (var item in intVariation)
        {
            Console.WriteLine($"{item} | Task - 3");
        }
    }
    );
    // Start the task.
    taskA.Start();

    // Output a message from the calling thread.
    taskA.Wait();
}
