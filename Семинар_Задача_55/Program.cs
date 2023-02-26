// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на 
//столбцы. В случае, если это невозможно, программа должна вывести сообщение для 
//пользователя.

int n = 4;
int m = 5;
int[,] Array = new int[m,n];
int[,] ArrayInverted = new int[n,m];
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j] = new Random().Next(1,10);
        Console.Write($"{Array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Перевернутый массив");

for (int j = 0; j < Array.GetLength(1); j++)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        ArrayInverted[j,i] = Array[i,j];
        Console.Write($"{Array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// int temp = Array[i,i];
        // int tempI=i;
        // int tempJ=i;
        // Array[i,i] = Array[0+i,0+i];
        // Array[0+i,0+i]=temp;
        // Array[tempJ,tempI] = temp;