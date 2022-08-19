// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //Метод для создания массива размера size из случайных чисел из диапазона [start;end]

class Program {
  public static void Main (string[] args) {
    
            int[] GenerateRandomArray(int size, int start, int end)
            {
                //объявляем массив размера size( количество элементов = size)
                // это выделена область памяти для переменных типа int (количество переменных = size)
                int[] RandomArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    //Генерируем чисело из диапазона [start;end] и записываем его в i-йэлемент массива
                    RandomArray[i] = new Random().Next(start, end + 1);
                }
                //так как "int[] Gen" то вернуть должны что-то типа int[]. А это массив СОЗДАННЫЙ
                return RandomArray;
            }

            //Метод для вывода элементов массива в консоль для вывода на экрана
            //передаём "()" в метод ShowArray массив "int[] "
            void ShowArray(int[] Array1)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array1[i]));
                }
            }

            // Проверка количества чётных чисел (элементов) массива
            int CountOfEven(int[] myArray2)
            //передаём "()" в метод ShowArray массив "int[] ", возвращаем число "int Co..."
            {
                //Счётчик, куда сохраняем сколько раз попались чётные числа (при каждом новом нахождении +1)
                int Count = 0;
                for (int i = 0; i < myArray2.Length; i++)
                    if (myArray2[i] % 2 == 0)
                    {
                        Count = Count + 1;
                    }
                return Count;
            }

            // ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ
            int[] myArray = new int[5];
            myArray = GenerateRandomArray(5, 100, 999);
            ShowArray(myArray);
            Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));
           
  }
}