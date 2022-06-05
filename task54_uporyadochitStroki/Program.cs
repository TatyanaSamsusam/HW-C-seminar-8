// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


int[,] ModifyArr (int[,] array)
{
    for (int a = 0; a < array.GetLength(1); a++)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(0); j++)
            {
                if (array[a,i] < array[a,j])
                {
                    temp = array[a,i];
                    array[a,i] = array[a,j];
                    array[a,j] = temp;
                }
            }
        }
    }
    return array;
}


int [,] arr = GetArray(4,4);
PrintArray(arr);
Console.WriteLine();
int [,] SortedArr = ModifyArr(arr);
PrintArray(SortedArr);


