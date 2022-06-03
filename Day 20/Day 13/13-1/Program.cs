double radius;
double length, area, volume;

Figures fG;
fG = new Figures();

CalcFigures cF;

Console.Write("Введите радиус окружности: ");
radius = Convert.ToDouble(Console.ReadLine());

cF = fG.Get_Length;
length = cF(radius);

Console.WriteLine($"Длина окружности = {length}");

cF = fG.Get_Area;
area = cF(radius);

Console.WriteLine($"Площадь круга = {area}");

cF = fG.Get_Volume;
volume = cF(radius);

Console.WriteLine($"Объём шара = {volume}");


/// <summary>
/// Figures class
/// </summary>
class Figures
{
    /// <summary>
    /// Get length this figure
    /// </summary>
    /// <param name="r">radius</param>
    /// <returns>calculate length</returns>
    public double Get_Length(double r)
    {
        double length;
        length = Math.PI * 2 * r;
        return length;
    }

    /// <summary>
    /// Get area.
    /// </summary>
    /// <param name="r">radius</param>
    /// <returns>calculate length</returns>
    public double Get_Area(double r)
    {
        double area;
        area = Math.PI * Math.Pow(r, 2);
        return area;
    }

    /// <summary>
    /// Get volume.
    /// </summary>
    /// <param name="r">radius</param>
    /// <returns>volume</returns>
    public double Get_Volume(double r)
    {
        double volume;
        volume = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
        return volume;
    }
}

/// <summary>
/// Delegate calculated figures
/// </summary>
/// <param name="r">radius</param>
/// <returns>volume, area, length</returns>
delegate double CalcFigures(double r);