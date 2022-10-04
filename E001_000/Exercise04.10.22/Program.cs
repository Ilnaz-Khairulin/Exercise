//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int siz = new Random().Next(2, 20);
// int[] array = new int[siz];
// System.Console.WriteLine("Величина массива = "+siz);
// void Newarray(int[] array, int siz)
// {
//     for (int i = 0; i < siz; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }
// string Print(int[] array)
// {
//     return String.Join(", ", array);
// }
// int EvenNumbers(int[] array)
// {
//     int siz = array.Length;
//     int count = 0;
//     for (int i = 0; i < siz; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Newarray(array, siz);
// Console.WriteLine(Print(array));
// Console.WriteLine("Количчество четных элементов массива = " + EvenNumbers(array));


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


//Есть магазин "Еда" В магазине есть охранник
//Охранник ведёт запись всех, кто заходит в магазин
//Охранник ведёт запись всех, кто выходит из магазин 
//Зайти и выйти можно в целый час.
//Выяснить в какой промежуток времени было больше всего
//посетителей
//Данные вводятся парами: приход-уход
//Максимум 100 покупателей
//Входные данные
//10-12
//11-13
//9-12
//Ответ 11-12

int[] Counter = new int[9];
for (int d = 0; d < 100; d++)
{
    int HourEnter = 0;
    int HourExit = 0;
    HourEnter = new Random().Next(8, 16);
    HourExit = new Random().Next(HourEnter + 1, 16);

    Console.WriteLine("время входа " + HourEnter);
    Console.WriteLine("время выхода " + HourExit);

    int count = 1;
    for (int i = HourEnter+ 1; i < HourExit; i++)
    {
        count++;

    };
    System.Console.WriteLine("количество часов внутри " + count);
    int[] Time = new int[count];
    int a = HourEnter - 1;
    Console.Write("в какие часы был внутри ");
    Console.WriteLine();
    for (int j = 0; j < count; j++)
    {
        a = a + 1;
        Time[j] = a;
        Console.Write(Time[j] + " ");
    }
    System.Console.WriteLine();

    for (int f = 0; f < count; f++)
    {
        if (Time[f] == 8)
        {
            Counter[0]++;
        }
        else if (Time[f] == 9)
        {
            Counter[1]++;
        }
        else if (Time[f] == 10)
        {
            Counter[2]++;
        }
        else if (Time[f] == 11)
        {
            Counter[3]++;
        }
        else if (Time[f] == 12)
        {
            Counter[4]++;
        }
        else if (Time[f] == 13)
        {
            Counter[5]++;
        }
        else if (Time[f] == 14)
        {
            Counter[6]++;
        }
        else if (Time[f] == 15)
        {
            Counter[7]++;
        }
        else if (Time[f] == 16)
        {
            Counter[8]++;
        }

    }
}
Console.WriteLine();
for (int g = 0; g < 9; g++)
    Console.WriteLine($"{"счетчик по часам "}  {g + 8}  {Counter[g]}");
int maxCounter = 0;
for (int s = 0; s < 9; s++)
{
    if (maxCounter < Counter[s])
    {
        maxCounter = Counter[s];
    }
}
for (int i = 0; i < 9; i++)
{
    if (maxCounter == Counter[i])
    {
        int maxHour = i + 8;
        int maxHour1 = i + 9;
        System.Console.WriteLine();
        Console.Write("время максимального количество людей  " + maxHour);
        Console.Write(" " + maxHour1);
    }
}












