Animal animal = new Animal(4, "собака", new Bark());
animal.MakeSound();
animal.Soundable = new Meow();
animal.MakeSound();

interface ISoundable
{
    void MakeSound();
}

class Bark : ISoundable
{
    public void MakeSound()
    {
        Console.WriteLine("Гав");
    }
}

class Meow : ISoundable
{
    public void MakeSound()
    {
        Console.WriteLine("Мяу");
    }
}

class Animal
{
    protected int legs;
    protected string type;

    public Animal(int legs, string type, ISoundable sound)
    {
        this.legs = legs;
        this.type = type;
        Soundable = sound;
    }

    public ISoundable Soundable { private get; set; }

    public void MakeSound()
    {
        Soundable.MakeSound();
    }
}