using _4_5.Models;
using System.Linq;
using System.Text.RegularExpressions;

class Book
{
    private Dictionary<string, int[]> _index = new Dictionary<string, int[]>();
    
    public Dictionary<string, int[]> Index
    {
        get { return _index; }
    }
    public string LoadFromFile(string filename)
    {
        var file = new System.IO.StreamReader(filename);
        return file.ReadToEnd();
       
    }

    public List<int> GetPages(string word)
    {
        List<int> pages = new List<int>();
        foreach (KeyValuePair<string, int[]> item in _index)
        {
            if (item.Key == word)
            {
                pages.AddRange(item.Value);
            }
        }
        return pages;
    }
}
class Program
{

    static void Main(string[] args)
    {
        var filePath = "Content.txt";
        var text = LoadFromFile(filePath);
    var content= PageParser.Parse(text);
        var ukazatel = new Ukazatel(content);
       var sections= ukazatel.GetSections();
        PrintSections(sections);











        //Book ex = new Book();
        //ex.Index.Add("Ivanov", new int[] { 1, 25, 73 });
        //ex.Index.Add("Petrov", new int[] { 2, 31, 86 });
        //ex.Index.Add("Sidorov", new int[] { 3, 41, 72 });

        //Console.Write("Input word:");
        //string word = Console.ReadLine();
        //Console.WriteLine();

        //List<int> pages = ex.GetPages(word);

        //Console.WriteLine("Pages for your word:");
        //foreach (int page in pages)
        //{
        //    Console.WriteLine(page.ToString());
        //}

        Console.ReadLine();
    }

    private static void PrintSections(Section[] sections)
    {
        foreach (var section in sections)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(section.Letter);
            foreach (var word in section.Words)
            {
                Console.WriteLine($"\t {word} | {string.Join(" ",word.Value)}");
            }
        }
    }

    public static string LoadFromFile(string filename)
    {
        var file = new System.IO.StreamReader(filename);
        return file.ReadToEnd();

    }
}