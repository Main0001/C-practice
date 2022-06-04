int x = 0;

while (true)
{
    try
    {
        Console.Write($"Enter num: ");
        x = int.Parse(Console.ReadLine());

        Task[] tasks= new Task[2]
        {
            new Task(() => Console.WriteLine($"Task - 1 | Z1 - {FormulaZ1(x)}")),
            new Task(() => {
            Console.WriteLine($"Task - 2 | Z2 - {FormulaZ2(x)}");

                }
            )
        };
        // запуск задач в массиве
        foreach (var t in tasks)
        {
            t.Start();

        }


        int index = Task.WaitAny(tasks);
        Console.WriteLine("Wait ended because task #{0} completed.",
                          tasks[index].Id);
        Console.WriteLine("\nCurrent Status of Tasks:");
        foreach (var t in tasks)
            Console.WriteLine("   Task {0}: {1}", t.Id, t.Status);


        Console.WriteLine();


        Task.WaitAll(tasks);
        Console.WriteLine("Tasks completed");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Some error! ({ex.Message})");
    }
}

double FormulaZ1(int x)
{
    Thread.Sleep(10);
    var z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) /
        (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));


    return z1;
}

double FormulaZ2(int x)
{
    Thread.Sleep(200);
    var z2 = Math.Sqrt((x + 3) / (x - 3));
    return z2;
}


