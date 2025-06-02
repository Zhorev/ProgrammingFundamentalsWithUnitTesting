double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

string operation = Console.ReadLine();
double result = 0;

switch (operation)
{
    case "+":
        result = n1 + n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
                break;
        case "-":
        result = n1 - n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
        break;
        case "*":
        result = n1 * n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
        break;
        case "/":
        result = n1 / n2;
        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
        break;
}