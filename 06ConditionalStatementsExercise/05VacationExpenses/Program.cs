using System.ComponentModel.Design;

string season = Console.ReadLine();
string accomType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double pricePerDay = 0;

switch (season)
{
    case "Spring":
        if (accomType == "Hotel")
        {
            pricePerDay = 24;
        }
        else if (accomType == "Camping")
        {
            pricePerDay = 8;
        }
        break;
    case "Summer":
        if (accomType == "Hotel")
        {
            pricePerDay = 50;
        }
        else if (accomType == "Camping")
        {
            pricePerDay = 30;
        }
        break;
    case "Autumn":
        if (accomType == "Hotel")
        {
            pricePerDay = 14;
        }
        else if (accomType == "Camping")
        {
            pricePerDay = 10.5;
        }
        break;
    case "Winter":
        if (accomType == "Hotel")
        {
            pricePerDay = 36;
        }
        else if (accomType == "Camping")
        {
            pricePerDay = 9;
        }
        break;
}

double totalPrice = pricePerDay * days;
Console.WriteLine($"{totalPrice:F2}");

