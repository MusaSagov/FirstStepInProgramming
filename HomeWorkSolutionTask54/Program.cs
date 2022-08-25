// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// метод ввода размера массива
int [,] inputArray () 
{   
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()); // превратили в вещественное число
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
return array;
}
// метод упорядочивания
{
void OrderArrayLines(int[,] array) 
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
// метод генерации массива
void CreateArray(int[,] array) 
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,100);
    }
  }
}
// метод печати массива
void WriteArray(int[,] array) 
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


int[,] array = inputArray ();
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

