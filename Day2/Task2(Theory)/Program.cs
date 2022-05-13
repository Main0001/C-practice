Console.Write("Введите числовую последовательность: ");

try
{
    string seq = Console.ReadLine();
    if (seq[0] < seq[1] && seq[1] < seq[2])
        Console.WriteLine("Последовательность - возрастающая");
    else
        if (seq[0] > seq[1] && seq[1] > seq[2])
        Console.WriteLine("Последовательность - убывающая");
    else Console.WriteLine("Последовательность не является ни возрастающей ни убыващей");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}