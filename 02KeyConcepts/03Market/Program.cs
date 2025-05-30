double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatoCost = tomatoPrice * tomatoQuantity;
double cucumberCost = cucumberPrice * cucumberQuantity;
double totalCost = tomatoCost + cucumberCost;

//Console.WriteLine($"Tomatoes: {tomatoPrice:F2} * {tomatoQuantity:F2} = {tomatoCost:F2}");
//Console.WriteLine($"Cucumbers: {cucumberPrice:F2} * {cucumberQuantity:F2} = {cucumberCost:F2}");
Console.WriteLine($"{totalCost:F2}");