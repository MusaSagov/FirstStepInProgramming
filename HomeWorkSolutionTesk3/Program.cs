string? inputLkwLine = Console.ReadLine();

if(inputLkwLine != null)
{
    int inputLine = int.Parse(inputLkwLine);
    
    if(inputLine%2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
