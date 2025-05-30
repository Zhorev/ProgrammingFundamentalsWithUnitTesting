int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

double percentage = double.Parse(Console.ReadLine()) / 100;

double aquariumVolume = lenght * width * height;
double aquariumLiters = aquariumVolume * 0.001;

double reqLiters = aquariumLiters * (1 - percentage);

Console.WriteLine($"{reqLiters:f2}");