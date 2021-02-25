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
            int[] someArray = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = rand.Next(1, 100);
                Console.Write(someArray[i] + " ");
            }
            Console.WriteLine();
            if (someArray[0] > someArray[1])
                Console.WriteLine("Нулевой член массива является локальным максимумом и равен: " + someArray[0]);
            else if (someArray[someArray.Length - 1] > someArray[someArray.Length - 2])
                Console.WriteLine("Крайний член массива является локальным максимумом и равен: " + someArray[someArray.Length - 1]);
            for (int i = 1; i < someArray.Length-1; i++)
            {
                if (someArray[i] > someArray[i - 1] && someArray[i] > someArray[i + 1])
                    Console.WriteLine("Локальный максимум под номером: " + i + " равен: " + someArray[i]);
            }
        }
    }
}
