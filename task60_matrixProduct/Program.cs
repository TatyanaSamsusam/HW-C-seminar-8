// Задача 58*: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}


void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindScalarProduct (int [,] arrA, int [,] arrB)
{
    int result = 0;
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            result = result + arrA[i,j] * arrB[i,j];
        }
    }
    return result;
}

Console.WriteLine("вот 2 матрицы: ");
Console.WriteLine();
int [,] arr1 = GetArray(4,4);
int [,] arr2 = GetArray(4,4);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
int scalar = FindScalarProduct(arr1, arr2);
Console.WriteLine($"скалярное произведение двух матриц равно {scalar}");