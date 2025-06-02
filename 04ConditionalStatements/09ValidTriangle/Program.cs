//int sideA = int.Parse(Console.ReadLine());
//int sideB = int.Parse(Console.ReadLine());
//int sideC = int.Parse(Console.ReadLine());

//if (sideA < sideB + sideC && 
//    sideB < sideA + sideC && 
//    sideC < sideA + sideB)
//{
//    Console.WriteLine("Valid Triangle");
//}
//else
//{
//    Console.WriteLine("Invalid Triangle");
//}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool isValid = true;

if (a > b + c)
    isValid = false;
else if (b > a + c)

    isValid = false;
else if (c > a + b)
    isValid = false;

if (isValid)
    Console.WriteLine("Valid Triangle");
else
    Console.WriteLine("Invalid Triangle");
