class Program
{
    static int massParser(double[] array)
    {
        return array.Where(x => x < 0).Count();
    }
    static void Main(String[] args)
    {
        Random random = new Random();
        double[] array = new double[20];
        for(int i = 0; i < array.Length; i++) 
        { 
            array[i] = random.Next(-10, 10);
            Console.WriteLine($"{i} : {array[i]}");
        }

        int numberOfNegative = massParser(array);
        Console.WriteLine($"Negativ - {numberOfNegative}");
    }
}