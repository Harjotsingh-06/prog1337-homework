//concatenation

Console.Write("Character name: ");
string characterName = Console.ReadLine();

Console.Write(" Location: ");
string location = Console.ReadLine();
Console.WriteLine(characterName+" arrives at  "+location);

//interpolation

Console.Write("Character name: ");
string characterName1 = Console.ReadLine();

Console.Write(" Location: ");
string location1 = Console.ReadLine();
Console.WriteLine($"{ characterName1 } arrives at  { location1}");