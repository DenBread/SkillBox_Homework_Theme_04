using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_CSharp_DZ_Array
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Список игр:");
            Console.WriteLine(" 1) Случайная матрица");
            Console.WriteLine(" 2) Наименьший элемент в последовательности");
            Console.WriteLine(" 3) Игра «Угадай число»");

            Console.Write("\nВаш выбор игры: ");
            int choiceNumber = int.Parse(Console.ReadLine());

            while (true)
            {

                Console.Clear();
                switch (choiceNumber)
                {
                    case 1:
                        RandomMatrix randomMatrix = new RandomMatrix();
                        randomMatrix.GenegationMatrix();
                        break;
                    case 2:
                        MinNumberArray minNumberArray = new MinNumberArray();
                        minNumberArray.FindMinNumber();
                        break;
                    case 3:
                        GuessNumber guessNumber = new GuessNumber();
                        guessNumber.GussNumberFind();
                        break;
                    default:
                        Console.WriteLine("Вы ничего не выбрали...");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Хотите повторить игру? Нажмите на любую клавишу, либо нажмите на N - чтобы выйти в список игр");
                char letter = Console.ReadKey().KeyChar;
                Console.Clear();

                if (char.ToUpper(letter) == 'N' || char.ToUpper(letter) == 'Т')
                {
                    Console.WriteLine("Список игр:");
                    Console.WriteLine(" 1) Случайная матрица");
                    Console.WriteLine(" 2) Наименьший элемент в последовательности");
                    Console.WriteLine(" 3) Игра «Угадай число»");

                    Console.Write("\nВаш выбор игры: ");
                    choiceNumber = int.Parse(Console.ReadLine());
                }
                
            }
        }
    }
}