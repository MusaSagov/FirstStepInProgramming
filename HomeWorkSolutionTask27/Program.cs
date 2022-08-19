// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine??"");
int sum = 0;
int sum2 = 0;

DateTime timePoint = DateTime.Now;

void Conculate(int inputNum)
{
    while (inputNum > 0)
    {
        sum = sum + inputNum % 10;
        inputNum = inputNum / 10;
    }
}

void Conculate2()
{
    char[] array = inputLine.ToCharArray();
    for (int i = 0; i < inputLine.Length; i++)
    {
        
        sum2 += int.Parse(array[i].ToString());
    }
  
}
timePoint = DateTime.Now;
Conculate(inputNum);
Console.WriteLine(sum);
Console.WriteLine(DateTime.Now-timePoint);

timePoint = DateTime.Now;
Conculate2();
Console.WriteLine(sum2);
Console.WriteLine(DateTime.Now-timePoint);
