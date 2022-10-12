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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = new int[3, 4]
{       {1,4,7,2},
        {5,9,2,3},
        {8,4,2,4}
};
int m = 0;
int n = 0;
int[] position = new int[2];
position[0] = new Random().Next(0, 9);
position[1] = new Random().Next(0, 9);
System.Console.Write("(" + position[0] + "," + position[1] + ")");
if (position[0] >= 0 && position[0] < 3 && position[1] >= 0 && position[1] < 4)
{

    m = position[0];
    n = position[1];
    System.Console.WriteLine(" = " + array[m, n]);


}
else
    System.Console.WriteLine("-> такого числа в массиве нет. ");