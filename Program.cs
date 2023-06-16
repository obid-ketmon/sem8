// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Упорядочивание элементов каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = j + 1; k < columns; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        // Обмен элементов местами
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        // Вывод упорядоченного массива
        Console.WriteLine("Упорядоченный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
 
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        // Поиск строки с наименьшей суммой элементов
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        // Вывод номера строки с наименьшей суммой элементов
        Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRowIndex + 1) + " строка");
    */

//     Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        // Проверка возможности умножения матриц
        if (columns1 != rows2)
        {
            Console.WriteLine("Умножение матриц невозможно");
            return;
        }

        int[,] result = new int[rows1, columns2];

        // Вычисление произведения матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;

                for (int k = 0; k < columns1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        // Вывод результирующей матрицы
        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
Console.WriteLine();
}
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
        int[,,] array = new int[2, 2, 2];
        int num = 10;

        // Заполнение массива неповторяющимися двузначными числами
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num;
                    num++;
                }
            }
        }

        // Вывод массива с добавлением индексов каждого элемента
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
                }
                Console.WriteLine();
            }
        }
    
*/

// ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
        int n = 4; // Размер массива
        int[,] array = new int[n, n];
        int num = 1; // Начальное значение для заполнения массива

        int rowStart = 0; // Индекс начальной строки
        int rowEnd = n - 1; // Индекс конечной строки
        int colStart = 0; // Индекс начального столбца
        int colEnd = n - 1; // Индекс конечного столбца

        // Заполнение массива спирально
        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Заполнение верхней строки
            for (int col = colStart; col <= colEnd; col++)
            {
                array[rowStart, col] = num;
                num++;
            }
            rowStart++;

            // Заполнение правого столбца
            for (int row = rowStart; row <= rowEnd; row++)
            {
                array[row, colEnd] = num;
                num++;
            }
            colEnd--;

            // Заполнение нижней строки
            for (int col = colEnd; col >= colStart; col--)
            {
                array[rowEnd, col] = num;
                num++;
            }
            rowEnd--;

            // Заполнение левого столбца
            for (int row = rowEnd; row >= rowStart; row--)
            {
                array[row, colStart] = num;
                num++;
            }
            colStart++;
        }

        // Вывод массива
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
 */