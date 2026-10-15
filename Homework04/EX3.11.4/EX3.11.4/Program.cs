//For Even numbers
Console.Write("Enter a number: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
bool isEven = (number% 2 == 0);
Console.WriteLine($"{input} is even: {isEven}");