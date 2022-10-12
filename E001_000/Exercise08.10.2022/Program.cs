// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int[] M = new int[10];

// for (int i = 0; i < 10; i++)
// {
//     // Console.WriteLine("Введите цифру: ");
//     // M[i] = int.Parse(Console.ReadLine());
//     M[i] =new Random().Next(-100, 100);
// }
// System.Console.WriteLine();

// for (int i = 0; i < 10; i++)
// {
//     Console.Write(M[i] + ",");
// }
// System.Console.WriteLine();

// int count = 0;
// for (int i = 0; i < 10; i++)
// {
//     if (M[i]>0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите к1 ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 ");
double k2 = double.Parse(Console.ReadLine());
double a= b2-b1;
double a1= k1-k2; 
double x = a/a1;
double y = k1*x+b1;
double y1= k2*x+b2;
if(y==y1)
{
        Console.WriteLine($"{"координаты пересечения прямых равна = "} ({y}; {x})");
}
else
Console.WriteLine("прямые не пересикаються!");