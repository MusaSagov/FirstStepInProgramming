// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double a;
double b;
double res = 0;
char oper;

Console.Write("Введите первое число:");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите действие:");
oper = Convert.ToChar(Console.ReadLine());

Console.Write("Введите второе число:");
b = Convert.ToDouble(Console.ReadLine());

if (oper == '+')
{
    res = a + b;
}

else
    if (oper == '-')
    {
    res = a - b;
    }

else 
    if (oper == '*')
{
    res = a * b;
}

else if (oper == '/')
{
    if (b != 0)
        res = a / b;
    else Console.WriteLine("На 0 делить нельзя!");
}
else if (oper == '^')
{
   res = Math.Pow(a,b);
    }
else
{
    Console.WriteLine("Неизвестный оператор.");
}

Console.WriteLine("Результат: {0}", res);
Console.ReadLine();