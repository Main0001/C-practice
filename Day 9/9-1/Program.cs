using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW7_1
{
    internal class Program
    {
        struct TRAIN
        {
            public string state;
            public int num;
            public string time;
            public void Print()
            {
                Console.WriteLine($"{state}, {num}, {time}");
            }
            public TRAIN(string state = "Достоевская", int num = -1, string time = "0:00")
            {
                this.state = state;
                this.num = num;
                this.time = time;
            }
            public override string ToString()
            {
                return $"Train { num}, arrives at Station { state} at { time}";
            }
        }
        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[8];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введите данные {i} поезда :");
                Console.Write($"Номер поезда: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write($"Станция поезда: ");
                string state = Console.ReadLine();
                Console.Write($"Времяя прибытия: ");
                string time = Console.ReadLine();

                if (trains[i].state == null)
                {
                    trains[i] = new TRAIN(state, num, time);
                }
                else
                {
                    trains[i] = new TRAIN(state, num, time);
                    i--;
                }
            }

            var temp = trains[0];
            for (int f = 0; f < trains.Length - 1; f++)
            {
                for (int j = f + 1; j < trains.Length; j++)
                {
                    if (trains[f].num > trains[j].num)
                    {
                        temp = trains[f];
                        trains[f] = trains[j];
                        trains[j] = temp;
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Введите номер поезда (999999 - закончить): ");
                int numTrain = int.Parse(Console.ReadLine());
                bool bol = true;
                foreach (var item in trains)
                {
                    if (item.num == numTrain)
                    {
                        Console.WriteLine(item);
                        bol = false;
                    }
                }
                Console.WriteLine("----------------------");
                if (bol)
                {
                    Console.WriteLine($"Поезда с номера {numTrain} нету");
                }
                foreach (var item in trains)
                {
                    Console.WriteLine(item);
                }
                if (numTrain == 999999)
                {
                    break;
                }
            }
        }
    }
}
