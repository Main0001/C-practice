using System.Text;
FileStream filOut = new FileStream(@"output.txt", FileMode.OpenOrCreate);
using (StreamWriter streamWriter = new StreamWriter(filOut))
{
    foreach (var line in System.IO.File.ReadLines(@"input.txt"))
    {
        foreach(var item in line)
        {
            if (item == '0')
            {
                streamWriter.Write(1);
            }
            else if (item == '1') streamWriter.Write(0);
            else { streamWriter.Write(item); }
        }
        streamWriter.WriteLine();
    }
}