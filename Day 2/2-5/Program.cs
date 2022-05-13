class Sweats
{
    static void Main(String[] args)
    {
        int price = 100; 
        while (true)
        {
            try
            {
                Console.Write("Price: ");
                price = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }
        for (int kg = 0; kg <= 10; kg++)
        {
            Console.WriteLine($"{kg}kg. - {kg * price}$");
        }
    }
}