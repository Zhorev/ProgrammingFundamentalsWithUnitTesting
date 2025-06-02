int time1 = int.Parse(Console.ReadLine()!);
int time2 = int.Parse(Console.ReadLine()!);
int time3 = int.Parse(Console.ReadLine()!);

int totalTime = time1 + time2 + time3;
double minutes = Math.Floor((double)totalTime / 60);
int seconds = totalTime % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");