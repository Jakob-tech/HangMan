using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> languageStrings;
    static string currentLanguage = "en";
    static Dictionary<string, string[]> categoryData;
    static string selectedCategory = "";

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Select language: en (English), de (Deutsch), lt (Lietuvių)");
            currentLanguage = Console.ReadLine().ToLower();                                                    
        }
        while (!(currentLanguage == "en" || currentLanguage == "de" || currentLanguage == "lt"));

        LoadLanguageStrings();
        LoadCategoryData();

        do
        {
            PlayGame();
        } while (AskToPlayAgain());

        //for your info
        //var raide = 'd';
        //Console.WriteLine((int)raide);
    }

    static void LoadLanguageStrings()
    {
        languageStrings = new Dictionary<string, string>();

        // English strings
        if (currentLanguage == "en")
        {
            languageStrings["welcome"] = "Welcome to Hangman!";
            languageStrings["select_category"] = "Please select a category:";
            languageStrings["invalid_choice"] = "Invalid choice! Restarting the game...";
            languageStrings["guess_word"] = "Word: ";
            languageStrings["attempts_left"] = "Attempts left: ";
            languageStrings["guessed_letters"] = "Guessed letters: ";
            languageStrings["guess_letter"] = "Guess a letter: ";
            languageStrings["already_guessed"] = "You already guessed that letter.";
            languageStrings["wrong_guess"] = "Wrong guess!";
            languageStrings["congratulations"] = "Congratulations! You guessed the word: ";
            languageStrings["sorry"] = "Sorry! You ran out of attempts. The word was: ";
            languageStrings["play_again"] = "Do you want to play again? (y/n)";
            languageStrings["wrong_input"] = "Wrong input: ";
            languageStrings["random_name"] = "Random Name";
            languageStrings["country"] = "Country";
            languageStrings["english_word"] = "English Word";
            languageStrings["car_brand"] = "Car Brand";
            languageStrings["animal"] = "Animal";
        }
        // German strings
        else if (currentLanguage == "de")
        {
            languageStrings["welcome"] = "Willkommen bei Hangman!";
            languageStrings["select_category"] = "Bitte wählen Sie eine Kategorie aus:";
            languageStrings["invalid_choice"] = "Ungültige Wahl! Neustart des Spiels...";
            languageStrings["guess_word"] = "Wort: ";
            languageStrings["attempts_left"] = "Verbleibende Versuche: ";
            languageStrings["guessed_letters"] = "Geratene Buchstaben: ";
            languageStrings["guess_letter"] = "Errate einen Buchstaben: ";
            languageStrings["already_guessed"] = "Du hast diesen Buchstaben bereits geraten.";
            languageStrings["wrong_guess"] = "Falsches Raten!";
            languageStrings["congratulations"] = "Herzlichen Glückwunsch! Du hast das Wort erraten: ";
            languageStrings["sorry"] = "Es tut mir leid! Du hast keine Versuche mehr. Das Wort war: ";
            languageStrings["play_again"] = "Möchtest du noch einmal spielen? (j/n)";
            languageStrings["wrong_input"] = "Falsche Eingabe: ";
            languageStrings["random_name"] = "Zufälliger Name";
            languageStrings["country"] = "Land";
            languageStrings["english_word"] = "Englisches Wort";
            languageStrings["car_brand"] = "Automarke";
            languageStrings["animal"] = "Tier";
        }
        // Lithuanian strings
        else if (currentLanguage == "lt")
        {
            languageStrings["welcome"] = "Sveiki atvykę į Hangman!";
            languageStrings["select_category"] = "Prašome pasirinkti kategoriją:";
            languageStrings["invalid_choice"] = "Netinkamas pasirinkimas! Žaidimas paleidžiamas iš naujo...";
            languageStrings["guess_word"] = "Žodis: ";
            languageStrings["attempts_left"] = "Likę bandymai: ";
            languageStrings["guessed_letters"] = "Atspėtos raidės: ";
            languageStrings["guess_letter"] = "Spėkite raidę: ";
            languageStrings["already_guessed"] = "Jūs jau spėjote šią raidę.";
            languageStrings["wrong_guess"] = "Neteisingas spėjimas!";
            languageStrings["congratulations"] = "Sveikiname! Jūs atspėjote žodį: ";
            languageStrings["sorry"] = "Atsiprašome! Bandymų nebeliko. Žodis buvo: ";
            languageStrings["play_again"] = "Ar norite žaisti dar kartą? (t/n)";
            languageStrings["wrong_input"] = "Neteisinga įvestis: ";
            languageStrings["random_name"] = "Atsitiktinis vardas";
            languageStrings["country"] = "Šalis";
            languageStrings["english_word"] = "Angliškas žodis";
            languageStrings["car_brand"] = "Automobilių markė";
            languageStrings["animal"] = "Gyvūnas";
        }
    }

    static void LoadCategoryData()
    {
        categoryData = new Dictionary<string, string[]>();

        if (currentLanguage == "en")
        {
            categoryData["random_name"] = ["Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack"];
            categoryData["country"] = ["Germany", "France", "Italy", "Spain", "Canada", "Brazil", "Australia", "India", "Japan", "Mexico"];
            categoryData["english_word"] = ["computer", "programming", "hangman", "dictionary", "algorithm", "network", "database", "software", "hardware", "debugging"];
            categoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            categoryData["animal"] = ["elephant", "tiger", "giraffe", "kangaroo", "penguin", "dolphin", "crocodile", "rhinoceros", "hippopotamus", "flamingo"];
        }
        else if (currentLanguage == "de")
        {
            categoryData["random_name"] = ["Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Greta", "Hannah", "Ivy", "Jakob"];
            categoryData["country"] = ["Deutschland", "Frankreich", "Italien", "Spanien", "Kanada", "Brasilien", "Australien", "Indien", "Japan", "Mexiko"];
            categoryData["english_word"] = ["Computer", "Programmieren", "Hangman", "Wörterbuch", "Algorithmus", "Netzwerk", "Datenbank", "Software", "Hardware", "Debugging"];
            categoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            categoryData["animal"] = ["Elefant", "Tiger", "Giraffe", "Känguru", "Pinguin", "Delfin", "Krokodil", "Nashorn", "Nilpferd", "Flamingo"];
        }
        else if (currentLanguage == "lt")
        {
            categoryData["random_name"] = ["Alicija", "Bobas", "Čarlis", "Deividas", "Eva", "Frankas", "Gracija", "Hana", "Iva", "Džekas"];
            categoryData["country"] = ["Vokietija", "Prancūzija", "Italija", "Ispanija", "Kanada", "Brazilija", "Australija", "Indija", "Japonija", "Meksika"];
            categoryData["english_word"] = ["kompiuteris", "programavimas", "kartuvas", "žodynas", "algoritmas", "tinklas", "duomenų bazė", "programinė įranga", "aparatinė įranga", "derinimas"];
            categoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            categoryData["animal"] = ["dramblys", "tigras", "žirafa", "kengūra", "pingvinas", "delfinas", "krokodilas", "rinozauras", "begemotas", "flamingas"];
        }
    }

    static void PlayGame()
    {
        Console.WriteLine(languageStrings["welcome"]);
        Console.WriteLine(languageStrings["select_category"]);
        Console.WriteLine("1. " + languageStrings["random_name"]);
        Console.WriteLine("2. " + languageStrings["country"]);
        Console.WriteLine("3. " + languageStrings["english_word"]);
        Console.WriteLine("4. " + languageStrings["car_brand"]);
        Console.WriteLine("5. " + languageStrings["animal"]);

        var userInput = Console.ReadLine();

        bool validChoice = int.TryParse(userInput, out int choice);
        if (!validChoice || choice < 1 || choice > 5)
        {
            Console.WriteLine(languageStrings["invalid_choice"]);
            return;
        }

        string wordToGuess = "";
        Random random = new Random();
        switch (choice)
        {
            case 1:
                wordToGuess = categoryData["random_name"][random.Next(categoryData["random_name"].Length)];
                selectedCategory = languageStrings["random_name"];
                break;
            case 2:
                wordToGuess = categoryData["country"][random.Next(categoryData["country"].Length)];
                selectedCategory = languageStrings["country"];
                break;
            case 3:
                wordToGuess = categoryData["english_word"][random.Next(categoryData["english_word"].Length)];
                selectedCategory = languageStrings["english_word"];
                break;
            case 4:
                wordToGuess = categoryData["car_brand"][random.Next(categoryData["car_brand"].Length)];
                selectedCategory = languageStrings["car_brand"];
                break;
            case 5:
                wordToGuess = categoryData["animal"][random.Next(categoryData["animal"].Length)];
                selectedCategory = languageStrings["animal"];
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
            Console.WriteLine("\n" + languageStrings["guess_word"] + new string(guessedWord));
            Console.WriteLine(languageStrings["attempts_left"] + attempts);
            Console.WriteLine(languageStrings["guessed_letters"] + string.Join(", ", guessedLetters));
            Console.WriteLine("Selected Category: " + selectedCategory);
            Console.Write(languageStrings["guess_letter"]);
            char guessedLetter = char.ToUpper(Console.ReadLine()[0]);

            if (guessedLetters.Contains(guessedLetter))
            {
                Console.WriteLine(languageStrings["already_guessed"]);
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
                Console.WriteLine(languageStrings["wrong_guess"]);
            }

            wordGuessed = new string(guessedWord) == wordToGuess;
        }

        Console.Clear();
        DisplayHangman(6 - attempts);

        if (wordGuessed)
        {
            Console.WriteLine("\n" + languageStrings["congratulations"] + wordToGuess);
        }
        else
        {
            Console.WriteLine("\n" + languageStrings["sorry"] + wordToGuess);
        }
    }

    static void DisplayHangman(int incorrectGuesses)
    {
        switch (incorrectGuesses)
        {
            case 0:
                Console.WriteLine("  __\n |    |\n |\n |\n |\n |\n|");
                break;
            case 1:
                Console.WriteLine("  __\n |    |\n |    O\n |\n |\n |\n|");
                break;
            case 2:
                Console.WriteLine("  __\n |    |\n |    O\n |    |\n |\n |\n|");
                break;
            case 3:
                Console.WriteLine("  __\n |    |\n |    O\n |   /|\n |\n |\n|");
                break;
            case 4:
                Console.WriteLine("  __\n |    |\n |    O\n |   /|\\\n |\n |\n|");
                break;
            case 5:
                Console.WriteLine("  __\n |    |\n |    O\n |   /|\\\n |   /\n |\n|");
                break;
            case 6:
                Console.WriteLine("  __\n |    |\n |    O\n |   /|\\\n |   / \\\n |\n|");
                break;
        }
    }

    static bool AskToPlayAgain()
    {
        bool doContinue = false;
        bool doPlayAgain = false;

        do
        {
            Console.WriteLine($"\n{languageStrings["play_again"]}");
            var response = $"{Console.ReadLine()}".ToLower();

            switch (response)
            {
                case "y":
                case "j":
                case "t":
                    doPlayAgain = true;
                    doContinue = false;
                    Console.Clear();
                    break;
                case "n":
                    doPlayAgain = false;
                    doContinue = false;
                    break;
                default:
                    Console.WriteLine($"\n{languageStrings["wrong_input"]} {response}.\n");
                    doContinue = true;
                    break;
            }

        } while (doContinue);

        return doPlayAgain;
    }
}