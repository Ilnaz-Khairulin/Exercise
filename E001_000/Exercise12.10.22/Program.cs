// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = new int[,]
// {
//     { 1,4,7,2},
//     {5,9,7,2},
//     { 8,4,2,4},
//     { 5,2,6,7}
// };
// int[] sum = new int[4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum[i] = sum[i] + array[i, j];

//     }
//     Console.Write(sum[i] + ", ");
// }
// int minArray = sum[0];
// for (int i = 0; i < 4; i++)
// {
//     minArray = Math.Min(minArray, sum[i]);
// };
// for (int i = 0; i < 4; i++)
// {
//     if (minArray == sum[i])
//     {
//         i++;
//         Console.WriteLine();
//         Console.WriteLine("номер строки с наименьшей суммой элементов: " + (i) + " строка");
//     }

// }




// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void Print(int[,] array, int siz, int m)
{
    for (int i = 0; i < siz; i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + ",");
        }
    }
}

void FillArray(int[,] array, int siz, int m)
{
    for (int i = 0; i < siz; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}



int siz = new Random().Next(2, 4);
int m = new Random().Next(2, 4);
int[,] array = new int[siz, m];
FillArray(array, siz, m);
Print(array, siz, m);

Console.WriteLine();

int siz1 = new Random().Next(2, 4);
int m1 = new Random().Next(2, 4);
int[,] array1 = new int[siz1, m1];
FillArray(array1, siz1, m1);
Print(array1, siz1, m1);
Console.WriteLine();


if (siz == m1 || siz1 == m)
{
    if (siz == m1)
    {

        int[,] arrayKub = new int[siz1, m];
        Print(arrayKub, siz1, m);
        for (int i = 0; i < arrayKub.GetLength(0); i++)
        {
            for (int j = 0; j < arrayKub.GetLength(1); j++)
            {
                for (int n = 0; n < siz; n++)
                {


                    arrayKub[i, j] = arrayKub[i, j] + array[n, j] * array1[i, n];

                }



            }
        }
        Print(arrayKub, siz1, m);

    }
    else
    {
        int[,] arrayKub = new int[siz, m1];
        Print(arrayKub, siz, m1);
        for (int i = 0; i < arrayKub.GetLength(0); i++)
        {
            for (int j = 0; j < arrayKub.GetLength(1); j++)
            {
                for (int n = 0; n < siz1; n++)
                {
                    arrayKub[i, j] = arrayKub[i, j] + array[n, j] * array1[i, n];

                }



            }

        }
        Print(arrayKub, siz, m1);
    }

}



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array= new int[2,2,2];
// for (int i = 0; i < array.GetLength(0); i++)
// {
   
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.WriteLine();
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//            array[i,j,k]=new Random().Next(1,100);
//            Console.Write(" "+array[i,j,k]+"("+i+","+j+","+k+","+")");
//         }
//     }
// }
