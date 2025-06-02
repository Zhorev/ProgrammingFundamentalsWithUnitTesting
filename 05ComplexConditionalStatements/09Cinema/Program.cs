string movieType = Console.ReadLine();

int rows = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

int totalSeats = rows * seatsPerRow;

if (movieType == "Premiere")
{
    Console.WriteLine($"{totalSeats * 12.00:F2}");
}
else if (movieType == "Normal")
{
    Console.WriteLine($"{totalSeats * 7.50:F2}");
}
else if (movieType == "Discount")
{
    Console.WriteLine($"{totalSeats * 5.00:F2}");
}
