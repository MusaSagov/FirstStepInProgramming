//Решение Николая
string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);
    int div =inputNumberTwo%inputNumberOne;
    if(div ==0){
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine(div);
    }
}

//Htit