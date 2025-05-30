double bathroomWight = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double bathroomArea = bathroomWight * bathroomHeight;

double tileWight = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());
double tileArea = tileWight * tileHeight;


double totalBathArea = bathroomArea * 0.1 + bathroomArea; // 10% more for waste

double tilesNeeded = Math.Round(totalBathArea / tileArea);

Console.WriteLine(tilesNeeded);

