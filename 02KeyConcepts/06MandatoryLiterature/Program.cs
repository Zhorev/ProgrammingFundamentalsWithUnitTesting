int numberPages = int.Parse(Console.ReadLine());
int readPagesPerHour = int.Parse(Console.ReadLine());
int readPagesPerDay = int.Parse(Console.ReadLine());

int totalHours = numberPages / readPagesPerHour;
int totalDays = totalHours / readPagesPerDay;

Console.WriteLine(totalDays);