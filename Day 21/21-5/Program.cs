try
{
    var multV = 1;
    ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 }, Mult);

    void Mult(int n, ParallelLoopState pls)
    {
        Console.WriteLine(multV);
        Console.WriteLine(n);
        Console.WriteLine($"Result = {multV *= n}");

        if (multV > 20)
        {
            Console.WriteLine("Цикл прерван");
            pls.Break();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}