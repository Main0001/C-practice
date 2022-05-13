class Course
{
    static void Main(String[] args)
    {
        double currentCourse = 100; // i know 😎😊
        while (true)
        {
            try
            {
                Console.Write("Course: ");
                currentCourse = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong, try again");
            }
        }

        Console.WriteLine("While()");
        int currentMoney = 5;
        while (currentMoney < 501)
        {
            Console.WriteLine($"{currentMoney}$ = {currentMoney * currentCourse}руб.");
            currentMoney += 5;
        }

        Console.WriteLine("Do{} while()");
        currentMoney = 0;
        do
        {
            currentMoney += 5;
            Console.WriteLine($"{currentMoney}$ = {currentMoney * currentCourse}руб.");
        } while (currentMoney != 500);

        Console.WriteLine("For()");
        for (currentMoney = 5; currentMoney < 501; currentMoney+=5)
        {
            Console.WriteLine($"{currentMoney}$ = {currentMoney * currentCourse}руб.");
        }
    }
}