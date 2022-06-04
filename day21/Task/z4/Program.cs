try
{
    const int A = 0;
    const int B = 10;

    Console.Write("Введите х: ");
    var x = int.Parse(Console.ReadLine());

    Parallel.For(A, B, Task);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Task(int x)
{
    Console.WriteLine($"Result = {x - Math.Sin(x)}");
}