// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int m;
int count=0;
//метод для считывания количества чисел
int ReadNumbers() 
{
    Console.Write($"Укажи планируемое количество чисел: ");
    m = int.Parse(Console.ReadLine() ?? "");
    return m;
}
//метод для считывания чисел поочереди
int[] InputNumbers(int m) 
{
    int[] massiveNumbers = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = int.Parse(Console.ReadLine()?? "");
    }
    return massiveNumbers;
}

//метод определения чисел, которые больше нуля
int Comparison(int[] massiveNumbers) 
{
    count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

//метод вывода ответа на задачу
void PrintAnswer() 
{
    Console.WriteLine($"Введено чисел больше 0: {(count)} ");
}

ReadNumbers();
int[] testArray=InputNumbers(m);
Comparison(testArray);
PrintAnswer();