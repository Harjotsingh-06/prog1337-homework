int sides = 6;
Random rnd = new Random();
int roll1 = rnd.Next(1, sides + 1);
int roll2 = rnd.Next(1, sides + 1);
int roll3 = rnd.Next(1, sides + 1);
Console.WriteLine($"Roll 1: {roll1}");
Console.WriteLine($"Roll 2: {roll2}");
Console.WriteLine($"Roll 3: {roll3}");
Console.WriteLine($"The rolls are {roll1}, {roll2}, and {roll3}");