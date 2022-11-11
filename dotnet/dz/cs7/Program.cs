
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[m, n];
// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 100))/10;
//         }
//     }
// }
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double [5, 5];
// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 100) / 7;
//         }

//     }
// }

// FillArray(matrix);

// if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n -1, m - 1 ]}");
// }

// PrintArray(matrix);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     double sum = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum = sum + matrix[i, j];
//     }
//     sum = sum / n;
//     Console.WriteLine(sum + ",");
// }

