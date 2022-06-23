using System.Text;

int a = 7, b = 17;
Queue<int> fromAToB = new Queue<int>();
Queue<int> lessThenA = new Queue<int>();
Queue<int> moreThenB = new Queue<int>();
int number;
using (StreamReader reader = new StreamReader(@"PSHHHHHHHHHHHHHHHHHHHHHHHHHHHHH.txt", Encoding.UTF8))
{
    while (!reader.EndOfStream)
    {
        number = int.Parse(reader.ReadLine());
        if (number < a)
            lessThenA.Enqueue(number);
        else if (number > b)
            moreThenB.Enqueue(number);
        else
            fromAToB.Enqueue(number);
    }
}
Console.WriteLine(string.Join(" ", fromAToB));
Console.WriteLine(string.Join(" ", lessThenA));
Console.WriteLine(string.Join(" ", moreThenB));
