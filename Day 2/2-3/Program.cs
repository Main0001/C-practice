class DeyInMoth
{
    static void Main(String[] args)
    {
        int mouthNomber, dayNum;
        while (true)
        {
            try
            {
                Console.Write("Moth: ");
                mouthNomber = int.Parse(Console.ReadLine());
                Console.Write("Day: ");
                dayNum = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }

        switch (mouthNomber)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (dayNum < 31)
                {
                    Console.WriteLine(31 - dayNum);
                }
                else { Console.WriteLine("Day > number of days in mouth"); }
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                if (dayNum < 30)
                {
                    Console.WriteLine(30 - dayNum);
                }
                else { Console.WriteLine("Day > number of days in mouth"); }

                break;

            case 2:
                if (dayNum < 28)
                {
                    Console.WriteLine(28 - dayNum);
                }
                else { Console.WriteLine("Day > number of days in mouth"); }

                break;
            default: Console.WriteLine("Mouth error"); break;
        }
    }
}