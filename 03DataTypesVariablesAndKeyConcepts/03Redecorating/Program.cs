int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double additionalPaint = paint * 0.10;
double paintPrice = (paint + additionalPaint) * 14.50;
double thinnerPrice = thinner * 5.00;
double bagPrice = 0.40;

double totalMaterialsPrice = nylonPrice + paintPrice + thinnerPrice + bagPrice;
double craftsHourPrice = (totalMaterialsPrice * 0.30);
double craftsManPrice = craftsHourPrice * hours;
double totalPrice = totalMaterialsPrice + craftsManPrice;

Console.WriteLine(totalPrice);