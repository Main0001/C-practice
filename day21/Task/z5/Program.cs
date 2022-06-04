try
{
    var multV = 1;
    var summV = 0;
    ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 }, Mult);

    void Mult(int n, ParallelLoopState pls)
    {
        Console.WriteLine($"Result mult = {multV *= n}");
        Console.WriteLine($"Result summ = {summV += n}");

        if (multV > 20)
        {
            Console.WriteLine("Цикл прерван (mult > 20)");
            pls.Break();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}