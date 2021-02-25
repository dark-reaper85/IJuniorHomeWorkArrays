using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMax
{
    class LocalMax
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] array = new int[arrayLength];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:\n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            
            if (array[0] > array[1])
                Console.WriteLine("Нулевой член массива является локальным максимумом и равен: " + array[0] + "\n");
            
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    Console.WriteLine("Локальный максимум под номером: " + i + " равен: " + array[i]);
            }
            Console.WriteLine();

            if (array[array.Length - 1] > array[array.Length - 2])
                Console.WriteLine("Крайний член массива является локальным максимумом и равен: " + array[array.Length - 1]);
        }
    }
}
