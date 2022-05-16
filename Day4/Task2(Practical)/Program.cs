Train[] park = Station.FillStation();
Station station = new Station(park);

bool contin = true;
while (contin)
{
    Console.WriteLine("Выеберите критерий:\n" +
       "1. Получить информацию о поезде по номеру\n" +
       "2. Получить информацию о поездах, отправляющихся после указанного времени\n" +
       "3. Сравнение времени отправления 2 поездов\n" +
       "4. Получить информацию о поездах, отправляющихся в заданный пункт назначения. \n" +
       "5. Выход\n");
    int choice = Int32.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Введите номер поезда: ");
            int index = Convert.ToInt32(Console.ReadLine());
            station.PrintTrainInfoByIndex(index);
            break;
        case 2:
            Console.WriteLine("Введите час отправки: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минуту отправки: ");
            int m = Convert.ToInt32(Console.ReadLine());

            station.PrintTrainInfoByTime(h, m);
            break;
        case 3:
            Console.WriteLine("Введите номер первого поезда: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер первого поезда: ");
            int second = Convert.ToInt32(Console.ReadLine());

            station.CompareTime(first, second);
            break;
        case 4:
            Console.WriteLine("Введите пункт назначения: ");
            string destination = Console.ReadLine();

            station.PrintTrainInfoByDestination(destination);
            break;
        case 5:
            contin = false;
            break;
    }
}

public class Station
{
    private Train[] _train;

    public Station(Train[] _train)
    {
        this._train = _train;
    }

    public static Train[] FillStation()
    {
        Train[] _train = new Train[2];
        Console.WriteLine("Заполните описание поездов");
        for (int i = 0; i <= _train.Length - 1; i++)
        {
            Console.WriteLine("Пункт назначения: ");
            string dest = Console.ReadLine();

            Console.WriteLine("Введите час отправки: ");
            int timeH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минуту отправки: ");
            int timeM = Convert.ToInt32(Console.ReadLine());
            _train[i] = new Train(i, dest, timeH, timeM);
        }
        return _train;
    }

    public void PrintTrainInfoByIndex(int index)
    {
        for (int i = 0; i <= _train.Length - 1; i++)
        {
            if (i == index)
                _train[i].Print();
        }
    }

    public void PrintTrainInfoByTime(int h, int m)
    {
        for (int i = 0; i <= _train.Length - 1; i++)
        {
            if (_train[i].timeH > h || (_train[i].timeH == h && _train[i].timeM > m))
                _train[i].Print();
        }
    }

    public void PrintTrainInfoByDestination(string destination)
    {
        for (int i = 0; i <= _train.Length - 1; i++)
        {
            if (_train[i].destination == destination)
                _train[i].Print();
        }
    }

    public void CompareTime(int first, int second)
    {
        Train fir = _train[first];
        Train sec = _train[second];

        if (fir > sec)
            Console.WriteLine("Первый поезд отправляется позже");

        else if (fir < sec)
            Console.WriteLine("Второй поезд отправляется позже");
    }
}

public class Train
{
    public int number;
    public string destination;
    public int timeH;
    public int timeM;

    public Train(int number, string destination, int timeH, int timeM)
    {
        this.number = number;
        this.destination = destination;
        this.timeH = timeH;
        this.timeM = timeM;
    }

    public void Print()
    {
        Console.WriteLine($"Номер поезда: {number}, пункт назначения: {destination}, время отправления: {timeH} ч, {timeM} м");
    }

    public static bool operator >(Train a, Train b)
    {
        if (a.timeH > b.timeH || (a.timeH == b.timeH && a.timeM > b.timeM))
            return true;
        else
            return false;
    }

    public static bool operator <(Train a, Train b)
    {
        if (a.timeH < b.timeH || (a.timeH == b.timeH && a.timeM < b.timeM))
            return true;
        else
            return false;
    }
}