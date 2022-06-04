const int A = -1;
const int B = 9;

try
{
    Parallel.For(A, B, x => {
        if (x != 0)
            Console.WriteLine($"{x} элемент = {Math.Cos(1 / x)}");
    });
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}