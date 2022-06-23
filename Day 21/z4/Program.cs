const int A = -6;
const int B = 4;

try
{
    Parallel.For(A, B, x => {
        if (x != 0)
            Console.WriteLine($"{x} элемент = {Math.Cos(x) / Math.Sin(x)}");
    });
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
