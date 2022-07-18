string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);

    if(inputNumberOne > inputNumberTwo)
    {
        Console.WriteLine($"max = {inputNumberOne}");
        Console.WriteLine($"min = {inputNumberTwo}");
    }
    else{
        Console.WriteLine($"max = {inputNumberTwo}");
        Console.WriteLine($"min = {inputNumberOne}");
    }
}