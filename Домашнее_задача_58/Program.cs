// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// = 2*3 + 4*3 2*4+4*3 => 18 20
// = 3*3 + 2*3 3*4+2*3 => 15 18 
// Результирующая матрица будет:
// 18 20
// 15 18

int a = 2;
int b = 2;
int c = 2;
int d = 2;
int[,] matrix1 = new int[a, b];
int[,] matrix2 = new int[c, d];
int[,] matrix3 = new int[a, d];

if (b != c)
{
    Console.Write("Эти матрицы нельзя перемножить");
}
else
{
    Console.WriteLine($"Массив matrix1:");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
{
    Console.WriteLine($"Массив matrix2:");
    for (int m = 0; m < matrix2.GetLength(0); m++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            matrix2[m, n] = new Random().Next(1, 10);
            Console.Write($"{matrix2[m, n]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Перемножаем матрицы:");
// умножения строки на столбец. Находятся произведения первого элемента строки и 
//первого элемента столбца, второго элемента строки и второго элемента столбца и т.д. 
//Затем полученные произведения суммируются.

{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            matrix3[i, n] = 0;
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix3[i, n] = matrix3[i, n] + matrix1[i, j] * matrix2[j, n];
            }
        }
    }
}

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        Console.Write($"{matrix3[i, j]} ");
    }
    Console.WriteLine();
}