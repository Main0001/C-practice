using System;
using System.Linq;
using System.Threading.Tasks;

int x = 0;

while (true)
{
    try
    {
        int Sum = 0;
        Console.Write($"Enter number: ");
        x = int.Parse(Console.ReadLine());

        Task[] tasks = new Task[2]
        {
             new Task(() => {
                Sum = NumbersSuming(x);
                }),
            new Task(() => Console.WriteLine("1"))
         };

        tasks[1] = tasks[0].ContinueWith(task =>
        {
            Console.WriteLine($"Result of summing numbers: {Sum}");
        });
        tasks[0].Start();

        tasks[1].Wait();
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine($"An error occured - {e.Message}");
    }
}

static int NumbersSuming(int num)
{
    var numbers = new int[] { num / 1000, (num / 100) % 10, (num % 100) / 10, num % 10 };
    return numbers.Sum();
}