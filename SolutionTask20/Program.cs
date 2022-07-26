//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int coordXPointA; //вводим переменные если убираем код в метод
int coordYPointA; 
int coordXPointB;           //Глобальные переменные всегда объявляются сверху методов
int coordYPointB;
double lengthAB;

//Метод считывания координат точек А и В
void readDataofPoint()
{
    Console.WriteLine("Введите координату Х в точке А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y в точке А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х в точке B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y в точке B");
    coordYPointB = int.Parse(Console.ReadLine());
}

//Метод вычисляет расстояние между точками А и В
void conculatelengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

readDataofPoint();
conculatelengthAB();


// Console.WriteLine("Введите координату Х в точке А"); //ввод координат без метода
// int coordXPointA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Y в точке А");
// int coordYPointA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Х в точке B");
// int coordXPointB = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Y в точке B");
// int coordYPointB = int.Parse(Console.ReadLine());

// double lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2)); //Math.Sqrt - корень квадратный Math.Pow - возведение в степень double - введение чисел с десятичными дробями  //расчет длины между точками без метода

Console.WriteLine(lengthAB);
