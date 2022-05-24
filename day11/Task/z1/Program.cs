try
{
    Cat cat = new Cat("Morty", 150, 15, "Red");
    Console.WriteLine($"result = {cat.WeightAnimal()}");
    //cat.SaYS();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Animal
{
    internal string _Name { get; set; }
    internal double _Height { get; set; }
    internal double _Coefficient { get; set; }
    public Animal(string name, double height, double coefficient)
    {
        this._Name = name;
        this._Height = height;
        this._Coefficient = coefficient;
    }
    public Animal()
    {
        this._Name = default(string);
        this._Height = default(double);
        this._Coefficient = default(double);
    }
    public int WeightAnimal()
    {
        double result = _Coefficient * _Height;
        return (int)result;
    }
    //public void SaYS()
    //{
    //    Console.WriteLine("Тестирование наследования метода");
    //}
}
class Cat : Animal
{
    internal string _Breed { get; set; }
    public Cat(string name, double height, double coefficient, string breed) : base(name, height, coefficient)
    {
        this._Coefficient = 15;
        this._Breed = breed;
    }
    public Cat(string breed)
    {
        this._Breed = breed;
    }
    public new int WeightAnimal()
    {
        var result = (_Coefficient * _Height) * 1000;
        return (int)result;
    }
}