double depositAmount = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine()) / 100;
//double trueRate = interestRate / 100;

//double amount = depositAmount + depositPeriod * (depositAmount * trueRate / 12);
double amount = depositAmount + depositPeriod * (depositAmount * interestRate / 12);

Console.WriteLine($"{amount:F2}");