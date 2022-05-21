using Note;

try
{
    NOTE[] list = new NOTE[8];
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите номер телефона: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Введите дату рождения");
        int[] birthday = new int[3];
        Console.Write("Введите день: ");
        birthday[0] = Int32.Parse(Console.ReadLine());
        Console.Write("Введите месяц: ");
        birthday[1] = Int32.Parse(Console.ReadLine());
        Console.Write("Введите год: ");
        birthday[2] = Int32.Parse(Console.ReadLine());
        list[i] = new(name, phoneNumber, birthday);
    }

    list = Sort(list);

    int choice = 1;
    while (choice == 1)
    {
        Console.Write("Введите месяц рождения: ");
        int month = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < list.Length; i++)
        {
            if (month == list[i].BirthdayDate[1])
            {
                list[i].Print();
                counter++;
            }
        }
        if (counter == 0)
            Console.WriteLine("Нет совпадений");
        Console.WriteLine("Хотите продолжить?" +
                          '\n' + "1. Да" +
                          '\n' + "2. Нет");
        choice = Int32.Parse(Console.ReadLine());
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

NOTE[] Sort(NOTE[] list)
{
    string tmp = string.Empty;
    int[] temp = new int[3];

    for (int i = 0; i < list.Length; i++)
    {
        for (int j = i + 1; j < list.Length; j++)
        {
            if (list[i].Name.CompareTo(list[j].Name) > 0)
            {
                tmp = list[i].Name;
                list[i].Name = list[j].Name;
                list[j].Name = tmp;

                tmp = list[i].PhoneNumber;
                list[i].PhoneNumber = list[j].PhoneNumber;
                list[j].PhoneNumber = tmp;

                temp = list[i].BirthdayDate;
                list[i].BirthdayDate = list[j].BirthdayDate;
                list[j].BirthdayDate = temp;
            }
        }
    }
    return list;
}