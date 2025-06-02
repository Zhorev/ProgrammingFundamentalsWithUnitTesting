int firstNumber = int.Parse(Console.ReadLine()!);
int secondNumber = int.Parse(Console.ReadLine()!);
int thirdNumber = int.Parse(Console.ReadLine()!);

if (firstNumber < secondNumber && secondNumber < thirdNumber)
{
    Console.WriteLine("Ascending");
}
else if (thirdNumber < secondNumber && secondNumber < firstNumber)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
