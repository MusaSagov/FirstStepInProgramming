//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// string? inputLine = Console.ReadLine(); //открыли строку для ввода 

// if(inputLine != null)  //проверили на null
// {
//     int inputNumberP = int.Parse(inputLine); //превратили в вещественное

//     int number1 = inputNumberP/10000; //нашли первую цифру числа
//     int number2 = (inputNumberP/1000)%10; //нашли вторую цифру числа
//     int number3 = (inputNumberP/100)%10; //нашли третью цифру числа
//     int number4 = (inputNumberP/10)%10; //нашли четвертую цифру числа
//     int number5 = inputNumberP%10; //нашли пятую цифру числа

//     if (number1 == number5&&number2==number4) //сравнили 1и5 2и4 цифры числа
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }

int inputNumberP;
int number1;
int number2;
int number3;
int number4;
int number5;

void findDigits(int inputNumberP)
{
    number1 = inputNumberP / 10000; //нашли первую цифру числа
    number2 = (inputNumberP / 1000) % 10; //нашли вторую цифру числа
    number3 = (inputNumberP / 100) % 10; //нашли третью цифру числа
    number4 = (inputNumberP / 10) % 10; //нашли четвертую цифру числа
    number5 = inputNumberP % 10; //нашли пятую цифру числа

}

void Palindrom(int number1, int number2, int number4, int number5)
{
    if (number1 == number5 && number2 == number4) //сравнили 1и5 2и4 цифры числа
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

string? inputLine = Console.ReadLine(); //открыли строку для ввода в консоль
inputNumberP = int.Parse(inputLine); //превратили в вещественное число

//Palindrom();
//findDigits(inputNumberP);