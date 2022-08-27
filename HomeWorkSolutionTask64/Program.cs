// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
int numberM = ReadData("Задайте число M"); // использование метода превращения чисел в вещественные
int numberN = ReadData("Задайте число N");

if (numberM < numberN) // определяем какое из введенных чисел больше, какое меньше
{
    NaturalNumberPrinter(numberM, numberN);
}
else
{
    NaturalNumberPrinter(numberN, numberM);
}


int ReadData(string line) // метод превращения введенных чисел в вещественные
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int sum = 0;

void NaturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " "); // печать всех чисел в диапазоне
    NaturalNumberPrinter(m + 1, n); // определение диапазона
}