namespace ClassLibrary1
{
    public abstract class RectangleFigure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public abstract string GetFigureType();

        //public void ShowInfo()
        //{
        //    Console.WriteLine(
        //         $"Название фигуры: {ShapeName()}\n" +
        //         $"Площадь: {Area()}\n" +
        //         $"Периметр: {Perimeter()}\n" +
        //         $"Тип: {GetFigureType()}"
        //         );
        //    Console.WriteLine();
        //}
    }

    public class Rectangle : RectangleFigure
    {
        double width;   // Ширина прямоугольника
        double height;   // Высота прямоугольника

        // Конструктор
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        // Свойство, проверяем значение на отрицательность.
        public double Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }

        //public override bool isExist()
        //{
        //    if (width > 0 && height > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        // Метод для вычисления площади прямоугольника
        public override string Area()
        {
            return (width * height).ToString();
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }

        public override string GetFigureType()
        {
            if (width == height) return "Квадрат";
            return "Не квадратный прямоугольник";
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }
}