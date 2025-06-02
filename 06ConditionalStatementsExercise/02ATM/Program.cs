int balance = int.Parse(Console.ReadLine()!);
int withdrawal = int.Parse(Console.ReadLine()!);
int limit = int.Parse(Console.ReadLine()!);

if (balance > withdrawal && withdrawal < limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (withdrawal > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (withdrawal > balance && withdrawal < limit)
{
    Console.WriteLine("Insufficient availability.");
}
