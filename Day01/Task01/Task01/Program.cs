
// Create a Random object
Random randomNumber = new Random();

// Generate a random number between 1 and 10
int generatedNumber = randomNumber.Next(1, 11);

//number of tries
int Tries = 0;

int maxTries = 3;

//using this variable we can check if the user guessed the number or not.
bool guessedCorrectly = false;

Console.WriteLine("Guess the number between 1 and 10, you have 3 chances");

//while i have tries i can continue playing.
while (Tries < maxTries)
{
    Console.Write("Enter your guess: ");

    //userGuess is input(new variable) which parsed to an integer to check the answer.
    if (int.TryParse(Console.ReadLine(), out int userGuess))
    {

        if (userGuess == generatedNumber)
        {
            guessedCorrectly = true;
            break;
        }
        else
        {
            int triesLeft = maxTries - Tries - 1;
            Console.WriteLine($"Wrong Number, Tries left: {triesLeft}");
            Tries++;
        }
    }
}

//final result
if (guessedCorrectly)
{
    Console.WriteLine("Congratulations! You guessed the correct number: " + generatedNumber);
}
else
{
    Console.WriteLine("you failed The correct number was: " + generatedNumber);
}
