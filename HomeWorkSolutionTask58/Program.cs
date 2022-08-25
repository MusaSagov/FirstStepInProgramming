// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// метод по перемножениею матриц
void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix) 
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array) // метод введения рандомной матрицы с заданым диапазоном
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 50);
        }
    }
}

void WriteArray(int[,] array) // метод печати матриц
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"\nВведите размеры матриц ");
Console.Write("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMatrix);

int[,] resultMatrix = new int[m, p];
MultiplicationMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);