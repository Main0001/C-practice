try
{
    Station station = new Station();
    Train train = new Train("Воронеж", "a1", new DateTime(2011, 5, 26, 20, 0, 0, 0));
    Train train1 = new Train("Новороссийск", "a2", new DateTime(2011, 5, 26, 20, 10, 0, 0));
    Train train2 = new Train("Минск", "a3", new DateTime(2011, 5, 26, 20, 20, 0, 0));
    Train train3 = new Train("Дубай", "a4", new DateTime(2011, 5, 26, 22, 0, 0, 0));

    station.AddRangeTrains(train, train1, train2, train3);

    station.ThisDate(new DateTime(2011, 5, 26, 20, 0, 0, 0));
    Console.WriteLine("-----------------------------");
    station.Print();
    Console.WriteLine("-----------------------------");
    station.TripFromPointName("Москва");
    Console.WriteLine("-----------------------------");
    station.GetInformation(0);
    Console.WriteLine("-----------------------------");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Train : IComparable<Train>
{
    private string _pointName;
    private string _trainNumber;
    private DateTime _trainDate;

    public Train(string PointName, string TrainNumber, DateTime TrainDate)
    {
        _pointName = PointName;
        _trainNumber = TrainNumber;
        _trainDate = TrainDate;
    }
    public string PointName
    {
        get { return _pointName; }
        set { _pointName = value; }
    }
    public string TrainNumber
    {
        get { return _trainNumber; }
        set { _trainNumber = value; }
    }
    public DateTime TrainDate
    {
        get { return _trainDate; }
        set { _trainDate = value; }
    }
    public static bool operator >(Train train1, Train train2)
    {
        return train1.TrainDate > train2.TrainDate;
    }
    public static bool operator <(Train train1, Train train2)
    {
        return train1.TrainDate < train2.TrainDate;
    }
    public override string ToString()
    {
        return $"{_pointName},{_trainNumber},{_trainDate}";
    }

    public int CompareTo(Train? other)
    {
        return _trainDate.CompareTo(other.TrainDate);
    }
}

class Station
{
    List<Train> trains;
    public Station()
    {
        trains = new List<Train>();
    }
    public void AddTrain(Train train)
    {
        trains.Add(train);
    }
    public void AddRangeTrains(params Train[] Trains)
    {
        trains.AddRange(Trains);
    }
    public void GetInformation(int index)
    {
        

        if (index > trains.Count - 1)
        {
            throw new Exception("Рейса не существует");
        }
        Console.WriteLine("Номер номер поезда: " + trains[index].TrainNumber);
        Console.WriteLine("Пункт назначения: " + trains[index].PointName);
        Console.WriteLine("Время выезда: " + trains[index].TrainDate);
    }
    public void ThisDate(DateTime time) 
    {
        DateTime time1 = new DateTime(time.Year, time.Month, time.Day, time.Hour + 1,
            time.Minute, time.Second, DateTimeKind.Local);
        Console.WriteLine("\nИнформация о поездах, отправляющихся после определенного времени:");
        for (int i = 0; i < trains.Count; i++)
            if (trains[i].TrainDate > time)
                GetInformation(i);
        Console.WriteLine("Список окончен\n");
    }

    public void TripFromPointName(string PointName)
    {
        Console.WriteLine("В " + PointName + " едут следующие поезда: ");
        for (int i = 0; i < trains.Count; i++)
            if (trains[i].PointName == PointName)
            {
                GetInformation(i);
            }
        Console.WriteLine("Список окончен\n");
    }
    public void Print()
    {
        foreach (Train t in trains)
        {
            Console.WriteLine(t.ToString());
        }
    }
}