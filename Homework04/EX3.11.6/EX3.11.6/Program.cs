Random rng = new Random();
int roll = rng.Next(1, 7);
bool isHighRoll = (roll>=4);
Console.WriteLine($"You rolled {roll}.");
Console.WriteLine($"High roll: {isHighRoll}");
