//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int siz = new Random().Next(1, 20);
int[] array = new int[siz];
System.Console.WriteLine("Величина массива = "+siz);
void Newarray(int[] array, int siz)
{
    for (int i = 0; i < siz; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
string Print(int[] array)
{
    return String.Join(", ", array);
}
int EvenNumbers(int[] array)
{
    int siz = array.Length;
    int count = 0;
    for (int i = 0; i < siz; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Newarray(array, siz);
Console.WriteLine(Print(array));
Console.WriteLine("Количчество четных элементов массива = " + EvenNumbers(array));


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Newarray36(int[] array, int siz)
{
    for (int i = 0; i < siz; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}
int Sum(int[] array, int siz)
{
    int sum = 0;
    for (int i = 1; i < siz; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}


// Newarray36(array,siz);
// System.Console.WriteLine(Print(array));
// System.Console.WriteLine("Сумма элементов на нечетных позициях = " + Sum(array,siz));



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Newarray38(int[] array, int siz)
{
    for (int i = 0; i < siz; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

int MaxNumber(int[] array, int siz)
{
    int max = 0;
    for (int i = 0; i < siz; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine("максимальная цифра = " + max);
    return max;
}
int MinNumber(int[] array, int siz)
{
    int min = array[0];
    for (int i = 0; i < siz; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine("минимальная цифра = " + min);
    return min;
}
int Difference(int max, int min)
{
    int minus = 0;
    minus = max - min;
    return minus;
}
// Newarray38(array, siz);
// Console.WriteLine(Print(array));
// int max = MaxNumber(array, siz);
// int min = MinNumber(array, siz);
// System.Console.WriteLine("Разница между максимум и минимум = " + Difference(max, min));


