//Задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    char[]threeDigit = inputLine.ToCharArray();
    
    if(threeDigit.Length>=3)
    {
        Console.WriteLine(threeDigit[2]);
    }

    else
    {
    Console.WriteLine("третьей цифры нет");
    }    
}    
