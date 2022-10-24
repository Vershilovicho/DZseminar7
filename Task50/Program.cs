// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

Console.WriteLine("Введите позицию элемента в массиве: номер строки -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца -> ");
int n = Convert.ToInt32(Console.ReadLine());

int ElementValue(int[,] matrix, int mm, int nn)
{
    int el = default;
    el = matrix[mm, nn];
    return el;
}


if (m < array2D.GetLength(0) && n < array2D.GetLength(1))
{
    int elementValue = ElementValue(array2D, m, n);
    Console.WriteLine(elementValue);
}
else
{
    Console.WriteLine("Такого элемента нет");
}
