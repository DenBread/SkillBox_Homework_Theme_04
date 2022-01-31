using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_CSharp_DZ_Array
{
    internal class GuessNumber
    {
        public void GussNumberFind()
        {
            Console.Write("Введите масимальное число для генерации: ");
            int randomNamber = int.Parse(Console.ReadLine());

            Random random = new Random();
            int gameNumber = random.Next(randomNamber);

            int inputNumber = 0;
            bool trueNumber = false; // Проверка числа на преобразование в число
            bool guessNumber = false;
            Console.WriteLine("Число сгенерирована! Попробуйте угадать...");

            while (!guessNumber)
            {
                Console.Write("Введите число: ");
                trueNumber = int.TryParse(Console.ReadLine(), out inputNumber);

                if (inputNumber > gameNumber) Console.WriteLine("Вы ввели большое число");
                if (inputNumber < gameNumber) Console.WriteLine("Вы ввесли маленькое число");
                if (!trueNumber)
                {
                    Console.WriteLine("Вы остановили игру. Загаданное число: " + gameNumber);
                    break;
                }
                if (inputNumber == gameNumber)
                {
                    Console.WriteLine("Вы угадали!");
                    guessNumber = true;
                }
            }
        }
    }
}
