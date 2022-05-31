try
{
    FileStream f = new FileStream("file.txt", FileMode.Open);
    StreamReader sr = new StreamReader(f);

    double[] arr = sr.ReadToEnd().Split('\n',' ').Select((x) => Convert.ToDouble(x)).ToArray();

    Console.WriteLine($"Сумма наибольшего и наименьшего значения файла: {arr.Max() + arr.Min()}");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}