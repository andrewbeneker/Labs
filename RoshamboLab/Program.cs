using RoshamboLab;

Console.WriteLine("Welcome to Roshambo");

Console.WriteLine("What is your name?");

HumanPlayer humanPlayer = new HumanPlayer();
humanPlayer.Name = Console.ReadLine();

RandomPlayer randomPlayer = new RandomPlayer();
randomPlayer.Name = "Chester";
RockPlayer rockPlayer = new RockPlayer();
rockPlayer.Name = "Billy";

Console.WriteLine($"Hello, {humanPlayer.Name}.");

bool keepPlaying = true;

int playerWins = 0;
int playerLoses = 0;
int playerTies = 0;



while (keepPlaying)
{

    
    Console.WriteLine("Please select an opponent. You can choose Chester or Billy");

    string computerOpponent = Console.ReadLine().ToLower().Trim();
    bool validInput = false;

    while (validInput == false)
    {
        if (computerOpponent == "chester" || computerOpponent == "billy")
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter Chester or Billy");
            computerOpponent = Console.ReadLine().ToLower().Trim();

        }
    }

    Console.WriteLine($"You've chosen {computerOpponent}.");

    string playerChoice = humanPlayer.GenerateRoshambo();

    Console.WriteLine($"Thank you, {humanPlayer.Name}. You chose {playerChoice}.");

    string computerChoice = "";

    switch(computerOpponent)
    {
        case "chester":
            computerChoice = randomPlayer.GenerateRoshambo();
            break;
        case "billy":
            computerChoice = rockPlayer.GenerateRoshambo();
            break;
    }

    Console.Clear();
    Console.WriteLine("Press any key to roshambo will all your might!");
    Console.ReadKey();
    Console.Clear();

    switch (computerChoice)
    {
        case "Rock":
            Console.WriteLine($"{computerOpponent} played rock.");
            if (playerChoice == "Rock")
            {
                Console.WriteLine("It's a tie.");
                playerTies++;
            }
            else if (playerChoice == "Paper")
            {
                Console.WriteLine("Paper beats rock. You win!");
                playerWins++;
            }
            else if (playerChoice == "Scissors")
            {
                Console.WriteLine("Rock beats scissors. You lose!");
                playerLoses++;
            }    
            break;
        case "Paper":
            Console.WriteLine($"{computerOpponent} played paper.");
            if(playerChoice == "Rock")
            {
                Console.WriteLine("Paper beats rock. You lose!");
                playerLoses++;
            }
            else if (playerChoice == "Paper")
            {
                Console.WriteLine("It's a tie.");
                playerTies++;
            }
            else if (playerChoice == "Scissors")
            {
                Console.WriteLine("Scissors beats paper. You win!");
                playerWins++;
            }
            break;
        case "Scissors":
            Console.WriteLine($"{computerOpponent} played scissors.");
            if(playerChoice == "Rock")
            {
                Console.WriteLine("Rock beats scissors. You win!");
                playerWins++;
            }
            else if (playerChoice == "Paper")
            {
                Console.WriteLine("Scissors beats paper. You lose.");
                playerLoses++;
            }
            else if (playerChoice == "Scissors")
            {
                Console.WriteLine("It's a tie.");
                playerTies++;
            }
            break;
    }

    Console.WriteLine("Here's the leaderboard:");
    Console.WriteLine($"Wins = {playerWins}");
    Console.WriteLine($"Losses = {playerLoses}");
    Console.WriteLine($"Ties = {playerTies}");
    Console.WriteLine();


    Console.WriteLine("Would you like to play again? y/n");
    string playAgain = Console.ReadLine().ToLower();
    if (playAgain == "n")
    {
        keepPlaying = false;
    }
    else
    {
        Console.Clear();
        continue;
        
    }
    Console.Clear();
}

Console.WriteLine("Have a nice day.... Coward.");
Console.WriteLine("Press any key to exit");
Console.ReadKey();