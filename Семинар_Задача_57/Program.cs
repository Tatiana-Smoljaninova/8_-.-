// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный 
//словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных: { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// Набор данных:
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// Частотный массив:
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int m = 4;
int n = 5;
int A = 10;
int[,] array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,A);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int number = 0;
int count;

while (number < A)
{
count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       if (array[i,j] == number)
       {
        count++; 
       }
    }
}
if (count == 0)
{
    Console.WriteLine($"Цифры {number} нет в массиве");
}

else
{
    Console.WriteLine($"Цифра {number} повторяется {count} раз");
}
number++;
}