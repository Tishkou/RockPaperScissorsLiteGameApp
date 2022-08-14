using RockPaperScissorsLiteGame.Models;


Logic person = new Logic();



do
{
    Console.Clear();
    person.UserInput = QuestionUser();
    person.Opponent = OpponentRandomize();
    DisplayShot(person);
    WinnerIndetify(person);


    Console.ReadLine();
    

} while (ContinueGame());

Console.Clear();

DisplayWinningCounter(person);










static string QuestionUser()
{
    string output;
    do
    {
        Console.Write("Enter Rock, Paper, Scissors: ");
        output = Console.ReadLine();
    } while (output.ToLower() != "rock" && output.ToLower() != "paper" && output.ToLower() != "scissors");

    return output;

}

static string OpponentRandomize()
{
    string output = "";
    Random random = new Random();
    switch (random.Next(1, 3))
    {
        case 1:
            output = "Rock";
            break;
        case 2:
            output = "Paper";
            break;
        case 3:
            output = "Scissors";
            break;
    }

    return output;
}

static void DisplayShot(Logic person)
{
    Console.WriteLine();

    Console.WriteLine("Player: " + person.UserInput);
    Console.WriteLine("Opponent: " + person.Opponent);
    Console.WriteLine();
}

static void WinnerIndetify(Logic person)
{
    person.playerWinnerCounter += 0;
    person.opponentWinnerCounter += 0;
    person.drawCounter += 0;

    

    switch (person.UserInput.ToLower())
    {

        case "rock":
            if (person.Opponent == "Rock")
            {
                Console.WriteLine("DRAW!");
                person.drawCounter++;




            }
            else if (person.Opponent == "Paper")
            {
                Console.WriteLine("YOU LOSE!");
                person.opponentWinnerCounter++;

            }
            else
            {
                Console.WriteLine("YOU WON!");
                person.playerWinnerCounter++;

            }
            break;

        case "paper":
            if (person.Opponent == "Rock")
            {
                Console.WriteLine("YOU WON!");
                person.playerWinnerCounter++;

            }
            else if (person.Opponent == "Paper")
            {
                Console.WriteLine("DRAW!");
                person.drawCounter++;

            }
            else
            {
                Console.WriteLine("YOU LOSE!");
                person.opponentWinnerCounter++;
            }
            break;
        case "scissors":
            if (person.Opponent == "Rock")
            {
                Console.WriteLine("YOU LOSE!");
                person.opponentWinnerCounter++;

            }
            else if (person.Opponent == "Paper")
            {
                Console.WriteLine("YOU WON!");
                person.playerWinnerCounter++;

            }
            else
            {
                Console.WriteLine("DRAW!");
                person.drawCounter++;
            }
            break;
    }

}

static bool ContinueGame()
{
    bool output = false;
    string continueGame;
    Console.Write("Continue the game Y/N: ");
    continueGame = Console.ReadLine();





    if (continueGame.ToLower() == "y")
    {
        output = true;
    }
    else
    {
        output = false;
    }


    return output;
}

static void DisplayWinningCounter(Logic person)
{
    Console.WriteLine($"You won: {person.playerWinnerCounter} times.");
    Console.WriteLine($"You lose: {person.opponentWinnerCounter} times.");
    Console.WriteLine($"You draw: {person.drawCounter} times.");
}

