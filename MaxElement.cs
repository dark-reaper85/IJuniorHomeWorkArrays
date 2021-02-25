using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int maxValue = int.MinValue;
            int iIndexOfMaxValue = 0;
            int jIndexOfMaxValue = 0;
            Random rand = new Random();

            Console.WriteLine("Базовый массив:\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] >= maxValue)
                    {
                        maxValue = array[i, j];
                        iIndexOfMaxValue = i;
                        jIndexOfMaxValue = j;
                    }
                }
            }
            Console.WriteLine("\nМаксимальный элемент массива = " + maxValue + "\nРасположен по адресу: " + iIndexOfMaxValue + "|" + jIndexOfMaxValue + ".\n");
            
            array[iIndexOfMaxValue, jIndexOfMaxValue] = 0;
            Console.WriteLine("Измененный массив:\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
