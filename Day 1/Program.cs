static double MakeSomethingWrong(double x)
{
    double y = Math.Log10(x + Math.Sqrt(Math.Pow(x, 2) + 9)) - (x + 1) / Math.Atan(Math.Pow(x, 3));
    return y;
}

static int[] GetDigitsVariants(int num)
{
    var variants = new int[][]
    {
        new int []{ 0, 1, 2},
        new int []{ 0, 2, 1},
        new int []{ 2, 0, 1},
        new int []{ 2, 1, 0},
        new int []{ 1, 2, 0},
        new int []{ 1, 0, 2},
    };
    var digits = new int[] { num / 100, (num % 100) / 10, num % 10 };
    var result = new int[variants.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        var item = variants[i];
        result[i] = digits[item[0]] * 100 + digits[item[1]] * 10 + digits[item[2]];
    }
    return result;
}

float v0 = 0, a = 0, t = 0;


// Практическая часть, задание 4
do
{
    Console.Write("Enter v0: ");
    v0 = int.Parse(Console.ReadLine());
} while (v0 < 0);

do
{
    Console.Write("Enter t: ");
    t = int.Parse(Console.ReadLine());
} while (t < 0);

do
{
    Console.Write("Enter a: ");
    a = int.Parse(Console.ReadLine());
} while (a < 0);

double s = v0 * t + (a * Math.Sqrt(t) / 2);
double u = s / t;
Console.WriteLine($"за время {t}сек.\nточка при ускорении, {a}м/с^2\nи начальной скорости, {v0}м/с\nпройдет расстояние: {s} м\nСо скоростью: {u}м/с");




// Практическая часть, задание 3
// Z3
Console.Write("Enter x: ");
while (true)
{
    try
    {
        Console.WriteLine(MakeSomethingWrong(double.Parse(Console.ReadLine())));
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("Произошла ошибка попробуйте снова!");
    }
}



// Практическая часть, задание 2
// Водное занятие часть 2, задание 2
Console.Write("Enter nuber with 3 digits: ");
foreach (var item in GetDigitsVariants(int.Parse(Console.ReadLine())))
{
    Console.WriteLine(item);
}

// Практическая часть, задание 1 

float b;

while (true)
{
    try
    {
        Console.Write("a = ");
        a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = float.Parse(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("Произошла ошибка попробуйте снова!");
    }
}


Console.WriteLine($"{a} + {b} = {a + b}");


// Водное занятие часть 2, задание 1
Console.WriteLine("Введите величину временного интервала(в минутах) и нажмите <Enter>");
TimeSpan spWorkMin = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));
Console.WriteLine(string.Format("{0:0}ч. {1:00} мин.", (int)spWorkMin.TotalHours, spWorkMin.Minutes));


// Водное занятие часть 2, задание 3
Console.WriteLine("Enter m:");
float m = float.Parse(Console.ReadLine());
double z1 = Math.Sqrt(Math.Pow(3 * m + 2, 2) - 24 * m) /
    (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));

double z2 = -Math.Sqrt(m);

Console.WriteLine($"z1 - {z1}\nz2 - {z2}");