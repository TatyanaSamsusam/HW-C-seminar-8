// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(5);
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

int [,] arr = GetArray(3,3);
PrintArray(arr);
Console.WriteLine();

int min = 0;
int rowNumber = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sumRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumRow = sumRow + arr[i,j];
    }
    if (i == 0) min = sumRow;
    else if (sumRow < min) 
    {
        min = sumRow; 
        rowNumber = i;
    }
}

Console.WriteLine($"номер строки с наименьшей суммой элементов: {rowNumber + 1}. Сумма ее элементов равна {min}");
Console.WriteLine();