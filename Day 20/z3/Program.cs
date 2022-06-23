char[] text;
/// <summary>
/// Streamreader create
/// </summary>
/// <param name="sr">Value with file path, open for reading</param>
using (StreamReader sr = new StreamReader("1.txt"))
{
    text = sr.ReadToEnd().ToCharArray();
}
///<value>
///0 or 1 if text file contains it
///</value>
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '0')
        text[i] = '1';
    else
    {
        if (text[i] == '1')
            text[i] = '0';
    }
}
using (StreamWriter sw = new StreamWriter("2.txt"))
{
    foreach (char c in text)
        sw.Write(c);
}
