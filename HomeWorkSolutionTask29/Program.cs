// Задача №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.WriteLine("Введите длинну массива:");
string? inputLine = Console.ReadLine();
int arrayLength = int.Parse(inputLine);

Console.WriteLine("Введите минимальное значение диапазона массива:");
string? inputLine2 = Console.ReadLine();
int minArray = int.Parse(inputLine2);

Console.WriteLine("Введите максимальное значение диапазона массива:");
string? inputLine3 = Console.ReadLine();
int maxArray = int.Parse(inputLine3);

System.Random randomArray = new Random();

void Array(int arrayLength, int minArray, int maxArray)
{
    int i = 0;
    Console.Write("[");
    while (i < arrayLength - 1)
    {
        Console.Write(randomArray.Next(minArray, maxArray) + ",");
        i++;
    }
    Console.Write(randomArray.Next(minArray, maxArray));
    Console.Write("]");
}

Array(arrayLength, minArray, maxArray);