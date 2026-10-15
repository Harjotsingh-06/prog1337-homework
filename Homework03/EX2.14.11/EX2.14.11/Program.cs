Console.Write("Enter hero name: ");
string heroName = Console.ReadLine();


Console.Write("Enter sidekick name: ");
string sidekickName = Console.ReadLine();


Random random = new Random();
int roll1 = random.Next(1, 21);
int roll2 = random.Next(1, 21);

Console.WriteLine($"{heroName} rolls {roll1} for initiative.");
Console.WriteLine($"{sidekickName} rolls {roll2} for initiative.");
