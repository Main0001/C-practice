using Rectangle1;
using Triangel;

try
{
    Figure figure1 = new Triangle(10, 10, 10);
    figure1.ShowInfo();
}
catch (Exception)
{
    Console.WriteLine("Error");
}
RectangleFigure figure3 = new Rectangle(5, 5);
figure3.ShowInfo();