class TriangelIsExist
{
    static void Main(String[] args)
    {
        static bool isExist(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 && sideC > 0 && (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                return true;
            }
            return false;
        }

        int triangleSideA, triangleSideB, triangleSideC;
        while (true)
        {
            try
            {
                Console.Write("Slide A: ");
                triangleSideA = int.Parse(Console.ReadLine());
                Console.Write("Slide B: ");
                triangleSideB = int.Parse(Console.ReadLine());
                Console.Write("Slide C: ");
                triangleSideC = int.Parse(Console.ReadLine());
                if (!isExist(triangleSideA, triangleSideB, triangleSideC))
                {
                    Console.WriteLine("Triangel does not exsist");
                    throw new Exception();
                }
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }
        Console.WriteLine("Triangel exsist");
    }
}