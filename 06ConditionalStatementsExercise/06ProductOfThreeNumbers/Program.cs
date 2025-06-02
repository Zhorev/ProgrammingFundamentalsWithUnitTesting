double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());

double result = n1 * n2 * n3;

if (result > 0)
{
    Console.WriteLine("positive");
}
else if (result == 0)
{
    Console.WriteLine("zero");
}
else if (result < 0)
{
    Console.WriteLine("negative");
}
