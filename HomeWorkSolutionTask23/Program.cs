string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string line1 = "";
    string line2 = string.Empty; //Пустая строка
    int s = 1;

    while (s <= numberN)
    {
        line1 = line1 + s + " ";
        line2 = line2 + (s * s * s) + " ";
        s++;
    }

    Console.WriteLine(line1);
    Console.WriteLine(line2);
}