Magistor student = new Magistor("Talerchik", 9.0, "TP");
Console.WriteLine(student.AddStipend());
Console.WriteLine(student.AddStipend(5));
class Student
{
    private string _name;
    private double _s;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double s
    {
        get { return _s; }
        set { _s = value; }
    }

    public double AddStipend()
    {
         return 3000000 + 10000 * (_s - 5);
    }

    public Student(string nameData, double sData) {
        _name = nameData;
        _s = sData;
    }
}

class Magistor : Student
{
    private string _speciality;
    public string Speciality
    {
        get { return _speciality; }
        set { _speciality = value; }
    }
    public Magistor(string nameData, double sData, string speciality)
    : base(nameData, sData)
    {
        Speciality = speciality;
    }
    public double AddStipend(int m)
    {
        return (3000000 + 10000 * (s - 5)) + m;
    }
}