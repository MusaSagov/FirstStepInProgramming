// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
//введение глобальных переменных
int valueB1; 
int valueK1;
int valueB2;
int valueK2;
int coordyX=0;
int coordyY=0;
string coordy;


void ReadingFunctionValues()
{
    Console.WriteLine("Введите значение b1");
    valueB1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k1");
    valueK1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение b2");
    valueB2 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k2");
    valueK2 = int.Parse(Console.ReadLine()?? "");
}
//метод подсчета координат точки пересечения
void Conculate() 
{
    if ((valueK1 == valueK2)&&(valueB1 == valueB2))
    //проверка на совпадение прямых
        Console.WriteLine("Прямые совпадают"); 
    else
        if (valueK1 == valueK2)
        Console.WriteLine("Прямые параллельны"); //проверка на параллельность прямых       
    else
        {
            coordyX=(valueB2-valueB1)/(valueK1-valueK2); //применение расчетов
            coordyY=(valueK1*(valueB2-valueB1))/(valueK1-valueK2)+valueB1;
        }  
    coordy = "Координаты точки пересечения: " + coordyX + "," + coordyY;
}
//метод вывода ответа
void PrintPointOfIntersectionOfCoordinates() 
{
    Console.WriteLine(coordy);
}    

ReadingFunctionValues();
Conculate();
PrintPointOfIntersectionOfCoordinates();