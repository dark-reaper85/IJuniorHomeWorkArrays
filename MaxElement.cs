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
            int[,] anyArray = new int[10, 10];
            int maxValue = int.MinValue;
            int iIndexOfMaxValue = 0;
            int jIndexOfMaxValue = 0;
            Random rand = new Random();
            Console.WriteLine("Базовый массив:");
            for (int i = 0; i < anyArray.GetLength(0); i++)
            {
                for (int j = 0; j < anyArray.GetLength(1); j++)
                {
                    anyArray[i, j] = rand.Next(1, 100);
                    if ( anyArray[i,j] >= maxValue)
                    {
                        maxValue = anyArray[i, j];
                        iIndexOfMaxValue = i;
                        jIndexOfMaxValue = j;
                    }
                    Console.Write(anyArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент массива = " + maxValue + "\nРасположен по адресу: " + iIndexOfMaxValue + "|" + jIndexOfMaxValue + ".");
            anyArray[iIndexOfMaxValue, jIndexOfMaxValue] = 0;
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < anyArray.GetLength(0); i++)
            {
                for (int j = 0; j < anyArray.GetLength(1); j++)
                {
                    Console.Write(anyArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
