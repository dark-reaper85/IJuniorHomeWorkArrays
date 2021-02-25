using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    class DinamicArray
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[1];
            int[] tempArray = null;
            string userInput = null;
            bool isWorking = true;
            int sum = 0;
            for (int i = 0; isWorking; i++)
            {
                Console.WriteLine("Введите целочисленное значение или sum для суммы введенных значений или exit для выхода:");
                userInput = Console.ReadLine();
                if (userInput == "exit")
                    isWorking = false;
                else if (userInput == "sum" && i != 0)
                {
                    for (int j = 0; j < someArray.Length; j++)
                        sum += someArray[j];
                    Console.WriteLine("Сумма введенных чисел равна: " + sum);
                    i--;
                }
                else
                {
                    tempArray = new int[someArray.Length + 1];
                    someArray[i] = Convert.ToInt32(userInput);
                    for (int k = 0; k < someArray.Length; k++)
                        tempArray[k] = someArray[k];
                    someArray = tempArray;
                }
            }
        }
    }
}
