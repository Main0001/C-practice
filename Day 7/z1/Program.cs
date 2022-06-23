string st = Console.ReadLine();
char[] s = st.ToCharArray();

static char foo(char s)
{
     if (s >= 'a' && s <= 'z') return (char)(s - 32);
     if (s >= 'A' && s <= 'Z') return (char)(s + 32);
     return s;
}