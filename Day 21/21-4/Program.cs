Parallel.For(-6, 6, Square);

// вычисляем квадрат числа
void Square(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Console.WriteLine($"sin(x) - cox(x) = {Math.Sin(n) - Math.Cos(n)}");
    Thread.Sleep(2000);
}