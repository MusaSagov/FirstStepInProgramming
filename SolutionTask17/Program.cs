//Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой
//находится эта точка.

//Метод считывает точки и возвращает массив с ними

int[,] readPoint()
{
    string inputLine = Console.ReadLine();  // Считали строчку

    //x=34; y=-30 -> 4

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";")); //Разобрали считанную строчку дли понять компьютеру что мы вводим в консоль
    //x=34;
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1); //Избавляемся от х=
    
    //y=-30
    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1); //Избавляемся от y=

    // Console.WriteLine(coordX+" "+coordY);

    int coordX = int.Parse(coordXLine); //Превратили значения в вещественные
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1, 2];   //заполнили массив, положили в массив запятая в квадратных скобках это таблица-массив (1 строчка и 2 столбца)
    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;


    return arrayOut; //выдаем массив на выход
}

//Печатает номер четверти
void printQuter(int[,] arreyPoint)
{
    if (arreyPoint[0, 0] > 0 && arreyPoint[0, 1]>0)
        Console.WriteLine("1 четверть");

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1]>0)
        Console.WriteLine("2 четверть");

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1]<0)
        Console.WriteLine("3 четверть");

    if (arreyPoint[0, 0] > 0 && arreyPoint[0, 1]<0)
        Console.WriteLine("4 четверть");
}

int[,] arreyPoint = readPoint(); //вызвали первый метод

printQuter(arreyPoint);

//printQuter(readPoint());
