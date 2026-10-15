Console.Write("enter attack : ");
int attack = Convert.ToInt32(Console.ReadLine());

Console.Write("enter multiplier : ");
int multiplier = Convert.ToInt32(Console.ReadLine());
int defense = 3;
int damage = (attack * multiplier - defense);
Console.WriteLine($" {attack} attack x {multiplier} - {defense} defense = {damage} damage ");