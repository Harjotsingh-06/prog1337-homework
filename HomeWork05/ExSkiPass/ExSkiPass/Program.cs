int childPrice = 0;
int nightPrice = 20;
int seniorPrice = 30;
int youthWeekdayPrice= 25;
int youthWeekendPrice = 35;
int adultWeekdayPrice = 50;
int adultWeekendPrice = 65;


Console.WriteLine("Ski Hill Day Pass");

Console.Write("Age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Day (1 = Monday ... 7 = Sunday): ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Night skiing? (y/n): ");
string nightInput = Console.ReadLine().ToLower();

Console.Write("Student card? (y/n): ");
string studentCardInput = Console.ReadLine().ToLower();

Console.WriteLine();


bool isWeekend = (day == 6 || day == 7);
bool isNight = (nightInput == "y");
bool hasStudentCard = (studentCardInput == "y");


if (age < 0 || age > 120 || day < 1 || day > 7)
{
    Console.WriteLine("Invalid input. No ticket sold.");
}
else
{
    string ticketType;
    int price = 0;

    if (age <= 5)
    {
        ticketType = "Child";
        price = childPrice;
    }
    else if (isNight)
    {
        ticketType = "Night";
        price = nightPrice;
    }
    else if (age >= 65)
    {
        ticketType = "Senior";
        price = seniorPrice;
    }
    else if (age <= 17 || (age <= 25 && hasStudentCard))
    {
        ticketType = "Youth/Student";
        if (isWeekend)
        {
            price = youthWeekendPrice;
        }
        else
        {
            price = youthWeekdayPrice;
        }
    }
    else
    {
        ticketType = "Adult";
        if (isWeekend)
        {
            price = adultWeekendPrice;
        }
        else
        {
            price = adultWeekdayPrice;
        }
    }

    Console.WriteLine($"Ticket: {ticketType}");
    Console.WriteLine($"Price: ${price}");
}
        