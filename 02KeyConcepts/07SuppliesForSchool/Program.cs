double packagePenPrice = 5.80;
double packageMarkerPrice = 7.20;
double boardCleanerPrice = 1.20;

int numberPackagesPens = int.Parse(Console.ReadLine());
int numberPackagesMarkers = int.Parse(Console.ReadLine());
int numberBoardCleaners = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double totalPenPrice = numberPackagesPens * packagePenPrice;
double totalMarkerPrice = numberPackagesMarkers * packageMarkerPrice;
double totalBoardCleanerPrice = numberBoardCleaners * boardCleanerPrice;

double totalPrice = totalPenPrice + totalMarkerPrice + totalBoardCleanerPrice;
double discount = totalPrice * discountPercentage / 100;
double finalPrice = totalPrice - discount;

Console.WriteLine($"{finalPrice:F3}");