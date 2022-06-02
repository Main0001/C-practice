using System.Text;

int a = 2, b = 6;
Queue<int> fromAToB = new Queue<int>(); //Queue - очередь
Queue<int> lessThenA = new Queue<int>();
Queue<int> moreThenB = new Queue<int>();
int number;
using (StreamReader reader = new StreamReader(@"file.txt", Encoding.UTF8)) //Открываем поток для чтения файла
{
    while (!reader.EndOfStream)
    {
        number = int.Parse(reader.ReadLine());//считывание строки, затем перенос на новую строку
        if (number < a)
            lessThenA.Enqueue(number); //Enqueue - добавляет элемент в конец очереди
        else if (number > b)
            moreThenB.Enqueue(number);
        else
            fromAToB.Enqueue(number);
    }
}
Console.WriteLine(string.Join(" ", fromAToB)); //из массива объединяем в строку и добавляем " " между элементами
Console.WriteLine(string.Join(" ", lessThenA));
Console.WriteLine(string.Join(" ", moreThenB));