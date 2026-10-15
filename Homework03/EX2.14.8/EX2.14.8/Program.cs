Console.Write("Enter your name: ");
string playersname= Console.ReadLine();
Random rng = new Random();
int roll = rng.Next(1,7);
Console.WriteLine($"{playersname}, you rolled a {roll}!");