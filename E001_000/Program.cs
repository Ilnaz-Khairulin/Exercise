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
for(int d =0;d<100;d++)
{
int HourOpen = 0;
int HourClose = 0;
HourOpen = new Random().Next(8, 16);
HourClose = new Random().Next(HourOpen + 1, 16);

Console.WriteLine("время входа " + HourOpen);
Console.WriteLine("время выхода " + HourClose);

int count = 2;
for (int i = HourOpen + 1; i < HourClose; i++)
{
    count++;

};
System.Console.WriteLine("количество часов внутри " + count);
int[] Time = new int[count];
int a = HourOpen - 1;
Console.Write("в какие часы был внутри ");
System.Console.WriteLine();
for (int j = 0; j < count; j++)
{
    a = a + 1;
    Time[j] = a;
    Console.Write(Time[j] + " ");
}

for(int f = 0;f<count;f++)
{
    if(Time[f] == 8)
    {
        Counter[0]++;
    }
    else if(Time[f]==9)
    {
        Counter[1]++;
    }
    else if(Time[f]==10)
    {
        Counter[2]++;
    }
    else if(Time[f]==11)
    {
        Counter[3]++;
    }
    else if(Time[f]==12)
    {
        Counter[4]++;
    }
    else if(Time[f]==13)
    {
        Counter[5]++;
    }
    else if(Time[f]==14)
    {
        Counter[6]++;
    }
    else if(Time[f]==15)
    {
        Counter[7]++;
    }
    else if(Time[f]==16)
    {
        Counter[8]++;
    }
    
}}
System.Console.WriteLine();
for(int g=0;g<9;g++)
Console.WriteLine("счетчик по часам  " + Counter[g]);












