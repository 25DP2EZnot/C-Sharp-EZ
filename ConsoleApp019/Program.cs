//Guessing game

// Set up the game

Random random = new Random();

Console.WriteLine("I'm thinking of a number between 1 and 20.");
Console.WriteLine("You have 5 guesses. Good luck!");

int secretNumber = random.Next(0, 21);

int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

 // Ask the player to guess

while (maxGuesses != guessCount || hasWon == true)
{
    Console.Write($"Guess #{guessCount+1}: ");
    int guess = int.Parse(Console.ReadLine() ?? "0");

    // Check the guess and give feedback

    if (secretNumber == guess)
    {
        Console.WriteLine($"Correct! You got it in {guessCount + 1} guesses.");
        hasWon = true;
        break;
    }
    else
    {
        guessCount++;

        if (guess < secretNumber)
        {
            Console.WriteLine("Too low.");
        }
        else
        {
            Console.WriteLine("Too high.");
        }

        Console.WriteLine($"You have {maxGuesses - guessCount} guesses left. try again!");
    }

    if (guessCount == maxGuesses)
    {
        Console.WriteLine($"Out of guesses! The number was {secretNumber}.");
    }
}

 // Announce the result

 if (hasWon == true)
{
    Console.WriteLine("You guessed curecly!");
}
else
{
    Console.WriteLine("You did not guess curecly :(");
}