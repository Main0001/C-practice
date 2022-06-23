using System.Linq;

Random rnd = new Random();
int[] A = new int[50];
for (int i = 0; i < 50; i++)
    A[i] = rnd.Next(0, 100);

int min = A.Min();

int index = -1;
A.First(n => { index++; return n == A.Min(); });

Console.WriteLine("Первый минимальный элемент = " + min.ToString() + ", с индексом: " + index.ToString());

Console.WriteLine(string.Format("Первый минимальный элемент = {0}, с индексом: {1}", min.ToString(), index.ToString()));

