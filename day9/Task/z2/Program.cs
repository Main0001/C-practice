try
{
    int value = 1;
    while (value == 1)
    {
        Console.WriteLine("Выберите работника:" +
                      '\n' + "1. Admin" +
                      '\n' + "2. Worker" +
                      '\n' + "3. Manager" +
                      '\n' + "4. Accountant");
        int choice = Int32.Parse(Console.ReadLine());
        Accountant acc = new Accountant();
        switch (choice)
        {
            case 1:
                acc.worker = Post.Admin;
                break;
            case 2:
                acc.worker = Post.Worker;
                break;
            case 3:
                acc.worker = Post.Manager;
                break;
            case 4:
                acc.worker = Post.Accountant;
                break;
        }
        Console.WriteLine("Введите количество отработанных часов: ");
        int hours = Int32.Parse(Console.ReadLine());
        if (Accountant.AskForBonus(acc.worker, hours))
            Console.WriteLine("Сотруднику положена премия");
        else Console.WriteLine("Сотруднику не положена премия");
        Console.WriteLine("Хотите продолжить?" +
                          '\n' + "1. Да" +
                          '\n' + "2. Нет");
        value = Int32.Parse(Console.ReadLine());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
enum Post
{
    Admin = 50,
    Worker = 40,
    Manager = 44,
    Accountant = 45
}
class Accountant
{
    public Post worker;
    public static bool AskForBonus(Post worker, int hours)
    {
        if ((int)worker <= hours)
            return true;
        else return false;
    }
}
