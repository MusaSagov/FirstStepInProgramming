//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string? inputLine = Console.ReadLine();

if(inputLine != null)//Трехзначное число
{
    int inputNumberOne = int.Parse(inputLine);//превращаем строк. перем.- в целочисленное
    int inputNumberTwo = (inputNumberOne % 100)/10;//остаток от деления "456"/100=56,
    // деление 56/10= 5
    
    Console.WriteLine(inputNumberTwo);
}    