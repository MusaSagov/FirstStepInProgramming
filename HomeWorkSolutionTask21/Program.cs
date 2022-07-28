//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//вводим переменные если убираем код в метод
//Глобальные переменные всегда объявляются сверху методов
int coordXPointA; 
int coordYPointA;
int coordZPointA;  
int coordXPointB;          
int coordYPointB;
int coordZPointB;
double lengthAB;

//Метод считывания координат точек А и В
void readDataofPoint()
{
    Console.WriteLine("Введите координату Х в точке А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y в точке А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z в точке А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х в точке B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y в точке B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z в точке B");
    coordZPointB = int.Parse(Console.ReadLine());
}

//Метод вычисляет расстояние между точками А и В в 3D пространстве
void conculatelengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointB - coordXPointA), 2) + Math.Pow((coordYPointB - coordYPointA), 2) + Math.Pow((coordZPointB - coordZPointA), 2));
}

readDataofPoint();
conculatelengthAB();

