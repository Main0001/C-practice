try
{
    Aeroport aeroport = new Aeroport();
    Aeroplane plane = new Aeroplane("Москва", 999999, new DateTime(2011, 5, 26, 20, 0, 0, 0));
    Aeroplane plane1 = new Aeroplane("Киев", 999998, new DateTime(2011, 5, 26, 20, 10, 0, 0));
    Aeroplane plane2 = new Aeroplane("Минск", 999997, new DateTime(2011, 5, 26, 20, 20, 0, 0));
    Aeroplane plane3 = new Aeroplane("Париж", 999996, new DateTime(2011, 5, 26, 22, 0, 0, 0));
    aeroport.AddAeroplaneRange(plane, plane1, plane2, plane3);
    aeroport.GetInforation(0);//информация о рейсе
    aeroport.ThisHour(new DateTime(2011, 5, 26, 20, 0, 0, 0));//в течение часа
    aeroport.TripFromPointName("Париж");//информация о рейсе в Париж
    Console.WriteLine("-------------------------------------------");
    aeroport.InfoSort();
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//Класс самолет
class Aeroplane
{
    private string _pointName;//пункт назначения
    private int _number;      //номер рейса
    private DateTime _time;   //время вылета

    public Aeroplane(string Pointname, int Number, DateTime Time)
    {
        _pointName = Pointname;
        _number = Number;
        _time = Time;
    }
    public int Number
    {
        get { return _number; }
        set { _number = value; }
    }
    public string PointName
    {
        get { return _pointName; }
        set { _pointName = value; }
    }
    public DateTime TimeToFly
    {
        get { return _time; }
        set { _time = value; }
    }
    public static bool operator >(Aeroplane plane1, Aeroplane plane2) //перегрузка операторов
    {
        return plane1.TimeToFly > plane2.TimeToFly;
    }

    public static bool operator <(Aeroplane plane1, Aeroplane plane2) //перегрузка операторов
    {
        return plane1.TimeToFly < plane2.TimeToFly;
    }
    public override string ToString()
    {
        return $"{_pointName},{_number},{_time}";
    }
}

class Aeroport
{
    List<Aeroplane> planes; // принимаем массив самолетов
    public Aeroport()
    {
        planes = new List<Aeroplane>(); // инициализируем переменную с массивом
    }

    public void AddAeroplane(Aeroplane plane) // добавление самолетов
    {
        planes.Add(plane);
    }

    public void AddAeroplaneRange(params Aeroplane[] Planes)//параметр массив, который будем заполнять // добавление нескольких самолетов одновременно
    {
        planes.AddRange(Planes);
    }


    public void GetInforation(int index) // получение информации по индексу
    {
        //var isMore = planes[0] > planes[1]; // проверка перегрузки
        //Console.WriteLine(isMore);

        if (index > planes.Count - 1)
        {
            throw new Exception("Рейса не существует");
        }
        Console.WriteLine("Номер рейса: " + planes[index].Number);
        Console.WriteLine("Пункт назначения: " + planes[index].PointName);
        Console.WriteLine("Время вылета: " + planes[index].TimeToFly);
    }

    public void InfoSort() //сортировка по времени
    {
        var temp = planes[0];
        for (int i = 0; i < planes.Count - 1; i++)
        {
            for (int j = i + 1; j < planes.Count; j++)
            {
                if (planes[i].TimeToFly > planes[j].TimeToFly)
                {
                    temp = planes[i];
                    planes[i] = planes[j];
                    planes[j] = temp;
                }
            }
        }
        Console.WriteLine("Заданный пункт назначения, Номер рейса, Дата и время отправления соответственно (сортировка по времени):");
        for (int i = 0; i < planes.Count; i++)
        {
            Console.WriteLine(planes[i]);
        }
    }

    public void ThisHour(DateTime time) // получение данных о самолетах, которые вылетят в течении часа
    {
        DateTime time1 = new DateTime(time.Year, time.Month, time.Day, time.Hour + 1,
            time.Minute, time.Second, DateTimeKind.Local);
        Console.WriteLine("\nВ течение часа вылетят самолеты:");
        for (int i = 0; i < planes.Count; i++)
            if (planes[i].TimeToFly > time && planes[i].TimeToFly < time1)
                GetInforation(i);
        Console.WriteLine("Список окончен\n");
    }

    public void TripFromPointName(string PointName) // получение самолетов, которые летят в определенную точку
    {
        Console.WriteLine("В " + PointName + " летят следующие самолеты: ");
        for (int i = 0; i < planes.Count; i++)
            if (planes[i].PointName == PointName)
            {
                GetInforation(i);
            }
        Console.WriteLine("Список окончен\n");
    }

}