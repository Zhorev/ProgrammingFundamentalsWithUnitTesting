int number = int.Parse(Console.ReadLine());

bool isValid = (number == 0 || number >= 100 && number <= 200);

if (!isValid)
{
    Console.WriteLine("invalid");
}