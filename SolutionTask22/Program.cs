//Задача 22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty; //Пустая строка
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN + (s * s) + " ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}

//Вариант Кирилла

// List<int> listGen(int number) //Динамический массив и метод
// {
//     List<int> numbers = new List<int>(); //Динамический массив
//     for (int i = 1; i <= number; i++) //Цикл от 1 до N
//     {
//         number.Add(i);
//     }
//     return numbers;
// }

// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     List<int> nims = listGen(inputNumber); 
    
//     foreach (var i in nums) //проходит по всем элементам списка и выводит числа от 1 до N
//     {
//         Console.Write(i);
//         Console.Write(" ");
//     }
//     Console.WriteLine();
    
//     foreach (var i in nums) //подсчитывает и выводит квадраты
//     {
//         Console.Write(Math.Pow(i, 2));
//         Console.Write(" ");
//     }
// }