int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegatarianMenu = int.Parse(Console.ReadLine());

double deliveryPrice = 2.50;
double chickenMenuPrice = chickenMenu * 10.35;
double fishMenuPrice = fishMenu * 12.40;
double vegatarianMenuPrice = vegatarianMenu * 8.15;

double allMenusPrice = chickenMenuPrice + fishMenuPrice + vegatarianMenuPrice;
double dessertPrice = allMenusPrice * 0.20;
double totalPrice = allMenusPrice + dessertPrice + deliveryPrice;

Console.WriteLine(totalPrice);