using FigureLib;
using ClassLibrary1;
using Parking;
try
{
    Figure figure1 = new Triangle(10, 10, 10);
    Console.WriteLine("Фигура треугольник создана");
    //figure1.ShowInfo();

    RectangleFigure figure3 = new Rectangle(5, 5);
    Console.WriteLine("Фигура прямоугольник создана");
    //figure3.ShowInfo();

    ParkingAuto auto = new ParkingAuto("Ламборджини", 1000, "Легковой");
    Console.WriteLine(auto.ShowInfo());

    Console.WriteLine("Введите количество денег для оплаты:");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.WriteLine(auto.BuyAuto(price));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();