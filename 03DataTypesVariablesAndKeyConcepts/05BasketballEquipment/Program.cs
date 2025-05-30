int annualFee = int.Parse(Console.ReadLine());

double sneakersPrice = annualFee - (annualFee * 0.4);
double uniformPrice = sneakersPrice - (sneakersPrice * 0.2);
double ballPrice = uniformPrice / 4;
double accessoriesPrice = ballPrice / 5;

double totalCost = annualFee + sneakersPrice + uniformPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalCost);