// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] Array = new int[4,4];

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j] = new Random().Next(1,10);
        Console.Write($"{Array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Новый массив, строки поменяли местами");
Console.WriteLine();

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (i == 0)
        {
            int temp = Array[i,j];
            Array[i,j] = Array[Array.GetLength(0) - 1, j];
            Console.Write($"{Array[i,j]} ");
            Array[(Array.GetLength(0)-1),j] = temp;
        }
        
        else 
        {
            Console.Write($"{Array[i,j]} ");
        }
    }
    Console.WriteLine();
}            
    