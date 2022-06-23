class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        Static diary = new Static();

        diary.Name = menu.AskName();

        bool check = false;
        diary.Name = diary.Name.Trim(); //Исключаем пробелы.

        if (diary.Name.Length == 0) //Исключаем пустые строки.
        {
            check = false;
            Console.WriteLine("Oшибка, имя не внесено в базу");
        }
        else
        {
            check = true;
            Console.WriteLine("Имя ученика введено в базу");
        }

        while (true)
        {
            string menuPoint = menu.AskMainMenuPoint();
            switch (menuPoint)
            {
                case "1":

                    diary.ChooseLesson();

                    break;

                case "2":

                    diary.ShowMath();
                    diary.ShowRead();
                    diary.ShowEnvir();
                    diary.ShowPhysic();
                    diary.ShowLetter();

                    break;

                case "3":

                    return;

                default:

                    menu.ShowInvalidMenuPointText();

                    break;
            }
        }
    }
    public class Menu
    {
        public string AskName() //Публичный запрос имени
        {
            Console.WriteLine("Доброго дня! Введите, пожалуйста, имя ученика");
            return Console.ReadLine();
        }

        public string AskMainMenuPoint() //Публичный запрос меню
        {
            Console.WriteLine("Выберите команду, которая вас интересует: " +
                "1 - добавить оценку в дневник; 2 - вывести статистику; 3 - выход");
            return Console.ReadLine();
        }

        public int Lesson() //Публичный запрос меню
        {
            Console.WriteLine("Выберите пожалуйста, предмет: " +
                "1 - математика; 2 - чтение; 3 - природоведение; 4 - физкультура; 5 - письмо; 6 - выход");
            return int.Parse(Console.ReadLine());
        }

        public int ReadScore() //Запрашиваем оценку.
        {
            Console.WriteLine("Введите, пожалуйста, оценку: 2 - Неудовлетворительно; 3 - Удовлетворительно; 4 - Хорошо; 5 - Отлично");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ShowInvalidMenuPointText() //Недопустимое значение
        {
            Console.WriteLine("Вы ввели недопустимое значение");
        }

    }
    public class Static
    {
        Menu menu = new Menu();

        private List<int> _score;
        public string Name;
        public List<int> Math;
        public List<int> Read;
        public List<int> Envir;
        public List<int> Physic;
        public List<int> Letter;

        public Static()
        {
            Math = new List<int>();
            Read = new List<int>();
            Envir = new List<int>();
            Physic = new List<int>();
            Letter = new List<int>();
        }

        public void MathStatic(int math)
        {
            Math.Add(math);
        }

        public void ReadStatic(int read)
        {
            Read.Add(read);
        }

        public void EnvirStatic(int envir)
        {
            Envir.Add(envir);
        }

        public void PhysicStatic(int physic)
        {
            Physic.Add(physic);
        }

        public void LetterStatic(int letter)
        {
            Letter.Add(letter);
        }

        public void ChooseLesson()
        {
            int lesson = menu.Lesson();
            if (lesson == 1)
            {
                MathStatic(menu.ReadScore());
            }

            else if (lesson == 2)
            {
                ReadStatic(menu.ReadScore());
            }

            else if (lesson == 3)
            {
                EnvirStatic(menu.ReadScore());
            }

            else if (lesson == 4)
            {
                PhysicStatic(menu.ReadScore());
            }

            else if (lesson == 5)
            {
                LetterStatic(menu.ReadScore());
            }

            else if (lesson == 6)
            {
                return;
            }

            else
            {
                menu.ShowInvalidMenuPointText();
            }
        }

        public void ShowMath()
        {
            double sumTmp = 0.0;

            foreach (var mathElement in Math)
            {
                sumTmp += mathElement;
            }

            Math.Sort();
            Console.WriteLine($"По мамематике минимальной оценкой является {Math[0]}, максимальной оценкой является {Math[Math.Count - 1]}, средней оценкой является {sumTmp / Math.Count}");
        }

        public void ShowRead()
        {
            double sumTmp = 0.0;

            foreach (var readElement in Read)
            {
                sumTmp += readElement;
            }

            Read.Sort();
            Console.WriteLine($"По чтению минимальной оценкой является {Read[0]}, максимальной оценкой является {Read[Read.Count - 1]}, средней оценкой является {sumTmp / Read.Count}");
        }

        public void ShowEnvir()
        {
            double sumTmp = 0.0;

            foreach (var envirElement in Envir)
            {
                sumTmp += envirElement;
            }

            Envir.Sort();
            Console.WriteLine($"По природоведению минимальной оценкой является {Envir[0]}, максимальной оценкой является {Envir[Envir.Count - 1]}, средней оценкой является {sumTmp / Envir.Count}");
        }

        public void ShowPhysic()
        {
            double sumTmp = 0.0;

            foreach (var physicElement in Physic)
            {
                sumTmp += physicElement;
            }

            Physic.Sort();
            Console.WriteLine($"По физической культуре минимальной оценкой является {Physic[0]}, максимальной оценкой является {Physic[Physic.Count - 1]}, средней оценкой является {sumTmp / Physic.Count}");
        }

        public void ShowLetter()
        {
            double sumTmp = 0.0;

            foreach (var letterElement in Letter)
            {
                sumTmp += letterElement;
            }

            Letter.Sort();
            Console.WriteLine($"По письму минимальной оценкой является {Letter[0]}, максимальной оценкой является {Letter[Letter.Count - 1]}, средней оценкой является {sumTmp / Letter.Count}");
        }

        public void ShowStatic()
        {
            double sumTmp = 0.0;

            foreach (var scoreElement in _score)
            {
                sumTmp += scoreElement;
            }

            _score.Sort();
            Console.WriteLine($"Минимальной оценкой является {_score[0]}, максимальной оценкой является {_score[_score.Count - 1]}, средней оценкой является {sumTmp / _score.Count}");

        }
    }
}
