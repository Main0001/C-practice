class Numbers
{
    static void Main(String[] args)
    {
       static bool Check(int x)
        {
            return x / 1000 == x % 10 && x / 100 % 10 == x / 10 % 10;
        }

        int number = 0;
        while (true)
        {
            try
            {
                Console.Write("Number = ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine(Check(number));
                break;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}