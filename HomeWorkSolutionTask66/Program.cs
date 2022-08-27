// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int m = InputNumbers("Введите m: "); // использование метода превращения чисел в вещественные
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int InputNumbers(string input) // метод превращения введенных чисел в вещественные
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}