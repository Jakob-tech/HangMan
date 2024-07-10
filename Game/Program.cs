using System;
using System.Collections.Generic;

class Hangman
{
    static void Main(string[] args)
    {
        do
        {
            PlayGame();
        } while (AskToPlayAgain());
    }

    static void PlayGame()
    {
        string[] randomNames = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack" };
        string[] countries = { "Germany", "France", "Italy", "Spain", "Canada", "Brazil", "Australia", "India", "Japan", "Mexico" };
        string[] englishWords = { "computer", "programming", "hangman", "dictionary", "algorithm", "network", "database", "software", "hardware", "debugging" };
        string[] carBrands = { "Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai" };
        string[] animals = { "elephant", "tiger", "giraffe", "kangaroo", "penguin", "dolphin", "crocodile", "rhinoceros", "hippopotamus", "flamingo" };

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Please select a category:");
        Console.WriteLine("1. Random Name");
        Console.WriteLine("2. Country");
        Console.WriteLine("3. English Word");
        Console.WriteLine("4. Car Brand");
        Console.WriteLine("5. Animal");

        bool validChoice = int.TryParse(Console.ReadLine(), out int choice);
        if (!validChoice || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid choice! Restarting the game...");
            return;
        }

        string wordToGuess = "";

        Random random = new Random();
        switch (choice)
        {
            case 1:
                wordToGuess = randomNames[random.Next(randomNames.Length)];
                break;
            case 2:
                wordToGuess = countries[random.Next(countries.Length)];
                break;
            case 3:
                wordToGuess = englishWords[random.Next(englishWords.Length)];
                break;
            case 4:
                wordToGuess = carBrands[random.Next(carBrands.Length)];
                break;
            case 5:
                wordToGuess = animals[random.Next(animals.Length)];
                break;
        }

        wordToGuess = wordToGuess.ToUpper();
        char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
        List<char> guessedLetters = new List<char>();
        int attempts = 6;
        bool wordGuessed = false;

        while (attempts > 0 && !wordGuessed)
        {
            Console.Clear();
            DisplayHangman(6 - attempts);
            Console.WriteLine("\nWord: " + new string(guessedWord));
            Console.WriteLine("Attempts left: " + attempts);
            Console.WriteLine("Guessed letters: " + string.Join(", ", guessedLetters));
            Console.Write("Guess a letter: ");
            char guessedLetter = char.ToUpper(Console.ReadLine()[0]);

            if (guessedLetters.Contains(guessedLetter))
            {
                Console.WriteLine("You already guessed that letter.");
                continue;
            }

            guessedLetters.Add(guessedLetter);

            if (wordToGuess.Contains(guessedLetter))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                    }
                }
            }
            else
            {
                attempts--;
                Console.WriteLine("Wrong guess!");
            }

            wordGuessed = new string(guessedWord) == wordToGuess;
        }

        Console.Clear();
        DisplayHangman(6 - attempts);

        if (wordGuessed)
        {
            Console.WriteLine("\nCongratulations! You guessed the word: " + wordToGuess);
        }
        else
        {
            Console.WriteLine("\nSorry! You ran out of attempts. The word was: " + wordToGuess);
        }
    }

    static void DisplayHangman(int incorrectGuesses)
    {
        switch (incorrectGuesses)
        {
            case 0:
                Console.WriteLine("  ___\n |    |\n |\n |\n |\n |\n|_");
                break;
            case 1:
                Console.WriteLine("  ___\n |    |\n |    O\n |\n |\n |\n|_");
                break;
            case 2:
                Console.WriteLine("  ___\n |    |\n |    O\n |    |\n |\n |\n|_");
                break;
            case 3:
                Console.WriteLine("  ___\n |    |\n |    O\n |   /|\n |\n |\n|_");
                break;
            case 4:
                Console.WriteLine("  ___\n |    |\n |    O\n |   /|\\\n |\n |\n|_");
                break;
            case 5:
                Console.WriteLine("  ___\n |    |\n |    O\n |   /|\\\n |   /\n |\n|_");
                break;
            case 6:
                Console.WriteLine("  ___\n |    |\n |    O\n |   /|\\\n |   / \\\n |\n|_");
                break;
        }
    }

    static bool AskToPlayAgain()
    {
        Console.WriteLine("\nDo you want to play again? (yes/no)");
        string response = Console.ReadLine().Trim().ToLower();
        return response == "yes";
    }
}