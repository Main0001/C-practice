string st = @"АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";


Console.Write("Введите имя: ");
string str = Console.ReadLine();
IdentityCodeCalculation(str, st);

static void IdentityCodeCalculation(string str, string st)
{
    int identityCode = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
            continue;
        else
            identityCode += st.IndexOf(str[i]) / 2 + 1;
    }

    int iC = 0;
    while (identityCode > 9)
    {
        iC = 0;
        int rest = identityCode;
        while (rest >= 1)
        {
            iC += rest % 10;
            rest /= 10;
        }
        identityCode = iC;
    }
    Console.WriteLine("Код личности: " + identityCode);
}