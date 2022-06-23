using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = @"Не следует, однако забывать, что консультация с широким активом обеспечивает широкому кругу (специалистов) участие в формировании модели развития.
Равным образом рамки и место обучения кадров позволяет выполнять важные задания по разработке модели развития. Разнообразный и богатый опыт постоянный количественный рост
и сфера нашей активности представляет собой интересный эксперимент проверки новых предложений. Повседневная практика показывает, что новая модель организационной 
деятельности представляет собой интересный эксперимент проверки соответствующий условий активизации. Равным образом консультация с широким активом позволяет выполнять важные
задания по разработке направлений прогрессивного развития. Равным образом начало повседневной работы по формированию позиции обеспечивает широкому кругу (специалистов) участие 
в формировании направлений прогрессивного развития.";

            const string myReg = "со";
            MatchCollection myMatch = Regex.Matches(myText, myReg);

            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ", myReg);
            foreach (Match i in myMatch)
                Console.Write("\t" + i.Index);

            const string myReg1 = @"\b[с,д]\S*ериализац\S*";
            MatchCollection match1 = Regex.Matches(myText, myReg1, RegexOptions.IgnoreCase);
            findMyText(myText, match1);

            Console.ReadLine();
        }

        static void findMyText(string text, MatchCollection myMatch)
        {
            Console.WriteLine("\n\nИсходная строка:\n\n{0}\n\nВидоизмененная строка:\n", text);

            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }

        }
    }
}
