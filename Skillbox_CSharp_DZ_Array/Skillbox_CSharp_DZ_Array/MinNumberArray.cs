using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_CSharp_DZ_Array
{
    internal class MinNumberArray
    {
        public void FindMinNumber()
        {
            Console.Write("Введите длину чисел: ");
            int lengthNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[lengthNumber];
            for (int i = 0; i < lengthNumber; i++)
            {
                Console.Write("Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Минимальное число: " + numbers.Min());
        }
    }
}
