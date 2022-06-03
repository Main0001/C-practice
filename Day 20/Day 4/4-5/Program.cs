using _4_5.Models;


class Program
{

    static void Main(string[] args)
    {

        var filePath = "Content.txt";
        var text = LoadFromFile(filePath);
        var content = PageParser.Parse(text);
        var ukazatel = new Ukazatel(content);
        var sections = ukazatel.Sections;
        PrintSections(sections);

        var word = "и";
        var indexes = ukazatel.GetWordIndexes(word);
        Console.Write(word);
        indexes.ToList().ForEach(i=>Console.Write($" {i}"));

        Console.ReadLine();
    }

    /// <summary>
    /// Print section.
    /// </summary>
    /// <param name="sections">Number of section</param>
    private static void PrintSections(Section[] sections)
    {
        foreach (var section in sections)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(section.Letter);
            foreach (var word in section.Words)
            {
                var indexes = string.Join(" ", word.Value);
                Console.WriteLine($"{word.Key,20} | {indexes}");
            }
        }
    }

    /// <summary>
    /// Work with file.
    /// </summary>
    /// <param name="filename">file name</param>
    /// <returns>return string</returns>
    public static string LoadFromFile(string filename)
    {
        var file = new System.IO.StreamReader(filename);
        return file.ReadToEnd();

    }
}