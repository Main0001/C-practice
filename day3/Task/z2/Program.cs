try
{
    Student st = new Student() {
    FirstName = "Anton",
    LastName = "Markiv",
    Course = 1,
    Age = 18,
    Sex = "M"
    };
    st.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }

    public void Print()
    {
        Console.WriteLine("Персона создана");
    }
}

class HeadOfDepartment : Person
{
    public string Faculty { get; set; }
    public string Subjects { get; set; }
    public string Timetable { get; set; }

    public void Print()
    {
        Console.WriteLine("Заведующий создан");
    }

}

class Teacher : HeadOfDepartment
{
    public string Marks { get; set; }
    public string Speciality { get; set; }

    public void Print()
    {
        Console.WriteLine("Учитель создан");
    }

}

class Student : Person
{
    public int Course { get; set; }

    public void Print()
    {
        Console.WriteLine("Студент создан");
    }
}