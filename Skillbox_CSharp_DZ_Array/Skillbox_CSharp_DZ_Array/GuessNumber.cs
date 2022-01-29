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
            bool trueNumber = false;
            Console.WriteLine("Число сгенерирована! Попробуйте угадать...");

            while (!trueNumber)
            {
                Console.Write("Введите число: ");
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber > gameNumber) Console.WriteLine("Вы ввели большое число");
                if (inputNumber < gameNumber) Console.WriteLine("Вы ввесли маленькое число");
                if (inputNumber.ToString() == "") break;
                if (inputNumber == gameNumber)
                {
                    Console.WriteLine("Вы угадали!");
                    trueNumber = true;
                }
            }
        }
    }
}
