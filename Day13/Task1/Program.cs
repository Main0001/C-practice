double radius;
double length, area, volume;

Figures fG;
fG = new Figures();

CalcFigures cF;

Console.Write("Введите радиус окружности: ");
radius = Convert.ToDouble(Console.ReadLine());

cF = fG.GetLength;
length = cF(radius);

Console.WriteLine($"Длина окружности = {length}");

cF = fG.GetArea;
area = cF(radius);

Console.WriteLine($"Площадь круга = {area}");

cF = fG.GetVolume;
volume = cF(radius);

Console.WriteLine($"Объём шара = {volume}");

class Figures
{
    public double GetLength(double r)
    {
        double length;
        length = Math.PI * 2 * r;
        return length;
    }

    public double GetArea(double r)
    {
        double area;
        area = Math.PI * Math.Pow(r, 2);
        return area;
    }

    public double GetVolume(double r)
    {
        double volume;
        volume = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
        return volume;
    }
}

delegate double CalcFigures(double r);