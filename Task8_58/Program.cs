// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void inputFirstMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{firstMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void inputSecondMatrix(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{secondMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void resultMatrix (int[,] firstMatrix, int[,] secondMatrix, int[,] result)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] != coord[1])
{
    Console.Write("Вы ошиблись!\nВведите размеры матрицы: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] firstMatrix = new int[coord[0], coord[1]];
int[,] secondMatrix = new int[coord[0], coord[1]];
int[,] result = new int[coord[0], coord[1]];
Console.WriteLine("Первый массив: ");
inputFirstMatrix(firstMatrix);
Console.WriteLine("Второй массив: ");
inputSecondMatrix(secondMatrix);
Console.WriteLine();
resultMatrix(firstMatrix, secondMatrix, result);
