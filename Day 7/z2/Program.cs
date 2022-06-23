int[] mas = new int[10];
string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (s[i] >= '0' & s[i] <= '9')
    {
        int n = Int32.Parse(s[i].ToString());
        mas[n]++;
    }
}
int max = 0;
int no = 0;
for (int i = 0; i < 10; i++)
    if (mas[i] > max)
    {
        no = i;
        max = mas[i];
    }
Console.WriteLine("Max: " + no);
Console.ReadKey();
