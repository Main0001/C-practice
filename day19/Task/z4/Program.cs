Dictionary<string, Dictionary<string, string>> catalog = new Dictionary<string, Dictionary<string, string>>();
int number = 9;
while (number != 0)
{
    try
    {
        Console.Write("1)Создание диска\n2)Удаление диска\n3)Добавление записи\n4)Удаление записи\n5)Просмотр каталога\n6)Просмотр определенного диска\nВведите '0' для завершения программы\n");
        number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("_________________________________");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Console.Write("Введите ключ диска: ");
            string keyOfDisk = Console.ReadLine();
            catalog.Add(keyOfDisk, dict);
            Console.WriteLine("Диск создан");
            Console.WriteLine("_________________________________");
        }
        else if (number == 2)
        {
            Console.WriteLine("_________________________________");
            Console.Write("Введите ключ диска, который Вы хотите удалить: ");
            string keyOfDiskDDelete = Console.ReadLine();
            catalog.Remove(keyOfDiskDDelete);
            Console.WriteLine("Диск удален");
            Console.WriteLine("_________________________________");
        }
        else if (number == 3)
        {
            Console.WriteLine("_________________________________");
            Console.Write("Введите ключ диска, в который Вы хотите добавить запись: ");
            string keyOfDisk = Console.ReadLine();
            var dict1 = AddMusic(keyOfDisk);
        }
        else if (number == 4)
        {
            Console.WriteLine("_________________________________");
            Console.Write("Введите ключ диска, с которого хотите удалить запись запись: ");
            string keyOfDisk = Console.ReadLine();
            var dict1 = RemoveMusic(keyOfDisk);
        }
        else if (number == 5)
        {
            Console.WriteLine("_________________________________");
            foreach (var cat in catalog)
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine(cat.Key);
                Console.WriteLine("_________________________________");
                foreach (var catI in catalog[cat.Key])
                {
                    Console.Write($"ключ: {catI.Key} ");
                    Console.WriteLine($"название: {catI.Value}" + "\n");
                }
            }
            Console.WriteLine("_________________________________");
        }
        else if (number == 6)
        {
            Console.WriteLine("_________________________________");
            Console.Write("Введите ключ диска, который Вы хотите просмотреть: ");
            string keyOfDisk = Console.ReadLine();
            CheckDisk(keyOfDisk);

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Dictionary<string, string> AddMusic(string keyOfDisk)
{
    var dict1 = catalog[keyOfDisk];
    Console.Write("Ключ песни: ");
    string keyOfMusic = Console.ReadLine();
    Console.Write("Название песни: ");
    string valOfMusic = Console.ReadLine();
    dict1.Add(keyOfMusic, valOfMusic);
    Console.WriteLine("Песня добавлена");
    Console.WriteLine("_________________________________");
    return dict1;
}
Dictionary<string, string> RemoveMusic(string keyOfDisk)
{
    var dict1 = catalog[keyOfDisk];
    Console.Write("Ключ песни: ");
    string keyOfMusic = Console.ReadLine();
    dict1.Remove(keyOfMusic);
    Console.WriteLine("Песня удалена");
    Console.WriteLine("_________________________________");
    return dict1;
}
void CheckDisk(string keyOfDisk)
{
    var dict1 = catalog[keyOfDisk];
    foreach (var mus in dict1)
    {
        Console.WriteLine($"ключ: {mus.Key}");
        Console.WriteLine($"название песни: {mus.Value} \n");
    }
    Console.WriteLine("_________________________________");
}