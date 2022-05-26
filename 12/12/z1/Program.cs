using System;

// объявление переменных
double radius;
double length, area, volume;

// объявление экземпляра класса (если методы статические, то этого не нужно делать)
Figures FG;         // FG - переменная (объект) типа "класс Figures"
FG = new Figures(); // создать экземпляр объекта класса

// объявление делегата с именем CF типа CalcFigures
CalcFigures CF;

// взять радиус
radius = Convert.ToDouble(Console.ReadLine());

// вычислить значения длины окружности
// инициализировать делегат значением метода, который вычисляет длину окружности
CF = FG.Get_Length;
length = CF(radius);

// вывести на форму результат длины окружности
Console.WriteLine(Math.Round(length,4));

// вычислить значения площади круга
CF = FG.Get_Area; // присвоить делегату метод Get_Area
area = CF(radius);
Console.WriteLine(Math.Round(area, 4));

// вычислить значения объема шара
CF = FG.Get_Volume; // присвоить делегату метод Get_Volume
volume = CF(radius); // вызов метода Get_Volume
Console.WriteLine(Math.Round(volume,4));

// вычислить значения объема шара
// класс, размещается в отдельном модуле Figures.cs
class Figures
{
    // объявление методов класса
    // методы объявляются без ключевого слова static
    // длина окружности
    public double Get_Length(double r)
    {
        double length;
        length = 3.1415 * 2 * r;
        return length;
    }

    // площадь круга
    public double Get_Area(double r)
    {
        double area;
        area = 3.1415 * r * r;
        return area;
    }

    // объем шара
    public double Get_Volume(double r)
    {
        double volume;
        volume = 4.0 / 3.0 * 3.1415 * r * r * r;
        return volume;
    }
}

// демонстрация работы с методами, которые есть экземплярами класса
delegate double CalcFigures(double r);