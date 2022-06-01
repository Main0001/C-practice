namespace FigureLib
{
    public abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public abstract string GetFigureType();

        //    public void ShowInfo()
        //    {
        //        Console.WriteLine(
        //            $"Название фигуры: {ShapeName()}\n" +
        //            $"Площадь: {Area()}\n" +
        //            $"Периметр: {Perimeter()}\n" +
        //            $"Тип: {GetFigureType()}"
        //            );
        //        Console.WriteLine();
        //    }
    }
    public class Triangle : Figure
    {
        double sideA, sideB, sideC;   // Стороны треугольника

        // Конструктор
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            if (!isExist(triangleSideA, triangleSideB, triangleSideC))
            {
                throw new Exception($"Error");
            }
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;

        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? -value : value; }
        }

        public bool isExist(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 && sideC > 0 && (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                return true;
            }
            return false;
        }

        // Метод для вычисления площади треугольника
        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }

        // Метод для вычисления периметра треугольника
        public override string Perimeter()
        {
            return (sideA + sideB + sideC).ToString();
        }

        public override string GetFigureType()
        {
            if (sideA == SideB && sideA == sideC) return "равносторонний";
            if (sideA == SideB || sideA == sideC || SideB == sideC) return "равнобедренный";
            return "треугольник, как треугольник";
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Треугольник";
        }
    }
}