using System.Text;

internal class Program
{
    public static string Alphabet = GetAplhabetString();
    static string GetAplhabetString()
    {
        var str = new StringBuilder();
        for (char i = 'а'; i <= 'я'; i++)
        {
            str.Append(i.ToString());
        }
        return str.ToString();
    }

    public static int[] GetNumberCodes(string text)
    {
        int[] array = new int[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            array[i] = Alphabet.IndexOf(text[i]) + 1;
        }
        return array;
    }
    public static int SumDigits(int Number)
    {
        int Sum = 0;
        while (Number > 0)
        {
            Sum += Number % 10;
            Number /= 10;
        }
        return Sum;
    }
    static void Main()
    {
        try
        {
            string Text;
            Console.Write("Введите строку: ");
            Text = Convert.ToString(Console.ReadLine());
            Text = Text.Replace(" ", "").ToLower();
            int[] mas = GetNumberCodes(Text);
            int Sum = mas.Sum();
            while (Sum > 9)
            {
                Sum = SumDigits(Sum);
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
