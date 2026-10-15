Console.WriteLine("Rock Paper Scissors");

Random random = new Random();
int computerNumber = random.Next(1, 4);
string computerChoice;

switch (computerNumber)
{
    case 1:
        computerChoice = "rock";
        break;
    case 2:
        computerChoice = "paper";
        break;
    case 3:
        computerChoice = "scissors";
        break;
    default:
        computerChoice = "unknown";
        break;
}


Console.Write("Your choice (r/p/s): ");
string input = Console.ReadLine();
input = input.ToLower();
string playerChoice;
switch (input)
{
    case "r":
    case "rock":
        playerChoice = "rock";
        break;
    case "p":
    case "paper":
        playerChoice = "paper";
        break;
    case "s":
    case "scissors":
        playerChoice = "scissors";
        break;
    default:
        playerChoice = "invalid";
        break;
}

Console.WriteLine();


if (playerChoice == "invalid")
{
    Console.WriteLine("Invalid choice. Please type r, p or s.");
}
else
{
    Console.WriteLine($"You chose {playerChoice}.");
    Console.WriteLine($"Computer chose {computerChoice}.");

    if (playerChoice == computerChoice)
    {
        Console.WriteLine("It's a tie!");
    }
    else if ((playerChoice == "rock" && computerChoice == "scissors") || (playerChoice == "paper" && computerChoice == "rock") || (playerChoice == "scissors" && computerChoice == "paper"))
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("Computer wins!");
    }
}