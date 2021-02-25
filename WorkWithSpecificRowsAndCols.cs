using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJuniorHomeWorkArrays
{
    class WorkWithSpecificRowsAndCols
    {
        static void Main(string[] args)
        {
            int rowsCount = 6;
            int colsCount = 3;
            Random rand = new Random();
            int[,] anyArray = new int[rowsCount, colsCount];
            int specificRow = 1;
            int specificCol = 0;
            int sumOfSpecificRow = 0;
            int productOfSpeccificCol = 1;

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    anyArray[i, j] = rand.Next(0, 9);
                    Console.Write(anyArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            for ( int j = 0; j < colsCount; j++)
            {
                sumOfSpecificRow += anyArray[specificRow, j];
            }

            for ( int i = 0; i < rowsCount; i++)
            {
                productOfSpeccificCol *= anyArray[i, specificCol];
            }

            Console.WriteLine();
            Console.WriteLine("Сумма значений " + (specificRow + 1) + " строки = "+ sumOfSpecificRow);
            Console.WriteLine("Произведение значений " + (specificCol + 1) + " столбца = " + productOfSpeccificCol);
        }
    }
}
