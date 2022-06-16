// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = rndNum.Next(10, 50);
                if (array[i, j, n] == array [i, j, n+1]) array [i, j, n+1] = rndNum.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"page # " + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,,] arr = GetArray(2, 3, 2);
PrintArray(arr);