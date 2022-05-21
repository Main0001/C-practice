void MounthU(SortedSet<Znak> set) // метод для вывода записи соответствующего месяца, который введен с клавиатуры
{
    Console.WriteLine("Введите месяц:");
    int month = int.Parse(Console.ReadLine());

    List<Znak> result = (from n in set where n.dateOfBirth[1] == month select n).ToList<Znak>(); // выборка записей, соответствующих дате, введенной с клавиатуры
    if (result.Count != 0) //проверка и переборка записей
    {
        foreach (var n in result)
        {
            Console.WriteLine(n.ToString());
        }
    }
    else { Console.WriteLine("Данные отсутствуют!"); }
}

void Print(SortedSet<Znak> set) //Вывод всех записей
{
    foreach (Znak n in set)
    {
        Console.WriteLine(n.ToString());
    }
}

try
{
    SortedSet<Znak> set = new SortedSet<Znak>(); //создание сортированного массива(множества)

    Console.Write("Введите имя = ");
    string fnameU = Console.ReadLine();
    Console.Write("Введите фамилию = ");
    string lnameU = Console.ReadLine();
    Console.Write("Введите знак зодиака = ");
    string zodiakU = Console.ReadLine();
    Console.Write("Введите день рождения = ");
    int dayU = int.Parse(Console.ReadLine());
    Console.Write("Введите месяц рождения = ");
    int monthU = int.Parse(Console.ReadLine());
    Console.Write("Введите год рождения = ");
    int yearU = int.Parse(Console.ReadLine());

    int[] dateU = new int[] { dayU, monthU, yearU };

    set.Add(new Znak(fnameU, lnameU, zodiakU, dateU));
    set.Add(new Znak("Alex", "Barly", "Scorpion", new int[] { 12, 11, 1981 })); //добавление записей
    set.Add(new Znak("Nick", "Simpson", "Libra", new int[] { 10, 10, 1995 }));
    set.Add(new Znak("Mary", "Douglas", "Scorpion", new int[] { 25, 11, 2005 }));

    Console.WriteLine("------------------------------------------------------");
    Print(set);
    Console.WriteLine("------------------------------------------------------");
    MounthU(set);

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public struct Znak:IComparable
{
    public string firstName;
    public string lastName;
    public string zodiak;
    public int[] dateOfBirth;


    public Znak(string fName, string lName, string z, int[] date)
    {
        firstName = fName;
        lastName = lName;
        zodiak = z;
        //dateOfBirth = new int[date.Length];
        dateOfBirth = date;
    }

    public int CompareTo(object? obj) //Сортировка
    {
        var compareZnak=(Znak) obj;
        if (zodiak.CompareTo(compareZnak.zodiak) == 0)
        {
            var dateX = new DateTime(dateOfBirth[2], dateOfBirth[1], dateOfBirth[0]);
            var datey = new DateTime(compareZnak.dateOfBirth[2], compareZnak.dateOfBirth[1], compareZnak.dateOfBirth[0]);
            return dateX.CompareTo(datey);
        }
        else
        {
            return zodiak.CompareTo(compareZnak.zodiak); //Сортировка по знаку зодиака
        }
    }

    public override string ToString() //для корректного вывода информации о записи
    {
        return string.Format("Имя: {0}, фамилия: {1}, знак Зодиака: {2}, дата рождения: {3}.{4}.{5}",
            firstName, lastName, zodiak, dateOfBirth[0], dateOfBirth[1], dateOfBirth[2]);
    }
}
//class ZnakComparer : IComparer<Znak> //Сортировка
//{
//    public int Compare(Znak x, Znak y)
//    {
//        if (x.dateOfBirth[0] > y.dateOfBirth[0])
//            return 1;
//        if (x.dateOfBirth[0] < y.dateOfBirth[0])
//            return -1;
//        else
//            return 0;

//        if(x.zodiak.CompareTo(y.zodiak) == 0)
//        {
//            var dateX=new DateTime(x.dateOfBirth[2], x.dateOfBirth[1], x.dateOfBirth[0]);
//            var datey=new DateTime(y.dateOfBirth[2], y.dateOfBirth[1], y.dateOfBirth[0]);
//            return dateX.CompareTo(datey);
//        }
//        else
//        {
//            return x.zodiak.CompareTo(y.zodiak);
//        }
//    }
//}
