// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// int m = 3;
// int n = 4;
// double[,] array =new double [m,n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double rand = new Random().NextDouble();
//         array[i,j] =Math.Round(rand*new Random().Next(-5,5),2);
//     }
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         System.Console.Write(array[i,j]+"; ");
//     }
//     System.Console.WriteLine();
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         array[i, j] = new Random().Next(1, 10);
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         System.Console.Write(array[i, j] + "; ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine();
// Console.Write("Среднее арифметическое каждого столбца: ");
// double[] average = new double [4];
// for (int k = 0; k < 4; k++)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//   average[k]=average[k]+array[i,k];
// }
// average[k]=average[k]/3;
// System.Console.Write(Math.Round(average[k],1) + "; ");
// }
