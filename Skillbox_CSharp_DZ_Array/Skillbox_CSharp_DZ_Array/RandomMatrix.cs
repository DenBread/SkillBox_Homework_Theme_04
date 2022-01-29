using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_CSharp_DZ_Array
{
    internal class RandomMatrix
    {
        private  int[,] testArray;
        private  int lineCount, columnCount;
        private  Random random = new Random();

        private int sumNambers;

        public void GenegationMatrix()
        {
            Console.Write("Кол-во строк: ");
            lineCount = int.Parse(Console.ReadLine());

            Console.Write("Кол-во столбцов: ");
            columnCount = int.Parse(Console.ReadLine());

            testArray = new int[lineCount, columnCount];


            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    testArray[i, j] = random.Next(20);
                    sumNambers += testArray[i, j];
                    Console.Write(testArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма всех чисел: " + sumNambers);
        }
    }
}
