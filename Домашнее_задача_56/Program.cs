// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int m = 3;
int n = 5;
int sum; // сумма эл-тов в строке
int sumMin = 0; // мин сумма
int count = 0; //номер строки с мин суммой
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
       sum = sum + array[i, j];
    } 

    if (i == 0)
    {
        sumMin = sum;
        count = i + 1; // берем индекс i, прибавляем 1, т.к. интекс с  0, а счет с 1
    }
    else if (sum < sumMin)
    {
        sumMin = sum;
        count = i + 1;
    }
}
Console.Write($"Наименьшая сумма элементов в строке {count}");