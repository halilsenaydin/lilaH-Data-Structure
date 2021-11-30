using Core.Operations;
using Core.Operations.Abstracts;
using DataStructures.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IArrayOperationService service = new ArrayOperationManager();
            int[] array = new int[] { 1, 2, 3, 4, 3 };
            string[] array2 = new string[] { "Halil", "İbrahim", "Şenaydın"};
            service.SortByDesc(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 0;
            }

            else if (number == 2)
            {
                return 1;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public static int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
        {
            int row1 = matrix1.GetLength(0);
            int column1 = matrix1.GetLength(1);

            int row2 = matrix2.GetLength(0);
            int column2 = matrix2.GetLength(1);

            int newRow = row1;
            int newColumn = column2;
                
            int[,] temp = new int[newRow, newColumn];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int k = 0; k < column1; k++)
                    {
                        temp[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
              
            }

            return temp;
        }
    }
}
