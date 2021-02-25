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
            int[] array = new int[0];
            int[] tempArray = null;
            int iterationNumber = 0;
            string userInput = null;
            bool isWorking = true;
            int sum = 0;

            while (isWorking)
            {
                Console.WriteLine("Введите целочисленное значение или sum для суммы введенных значений или exit для выхода:");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    isWorking = false;
                }
                else if (userInput == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                        sum += array[i];

                    Console.WriteLine("Сумма введенных чисел равна: " + sum);
                }
                else
                {
                    tempArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                        tempArray[i] = array[i];

                    tempArray[iterationNumber] = Convert.ToInt32(userInput);
                    
                    array = tempArray;
                    
                    iterationNumber++;
                }
            }
        }
    }
}
