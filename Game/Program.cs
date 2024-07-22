using Game;

class Program
{
    static GameParameters gameParameters = new GameParameters(6);

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Select language: en (English), de (Deutsch), lt (Lietuvių)");
            gameParameters.CurrentLanguage = Console.ReadLine().ToLower();                                                    
        }
        while (!(gameParameters.CurrentLanguage == "en" || gameParameters.CurrentLanguage == "de" || gameParameters.CurrentLanguage == "lt"));

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

        // English strings
        if (gameParameters.CurrentLanguage == "en")
        {
            gameParameters.LanguageStrings["welcome"] = "Welcome to Hangman!";
            gameParameters.LanguageStrings["select_category"] = "Please select a category:";
            gameParameters.LanguageStrings["invalid_choice"] = "Invalid choice! Restarting the game...";
            gameParameters.LanguageStrings["guess_word"] = "Word: ";
            gameParameters.LanguageStrings["attempts_left"] = "Attempts left: ";
            gameParameters.LanguageStrings["guessed_letters"] = "Guessed letters: ";
            gameParameters.LanguageStrings["guess_letter"] = "Guess a letter: ";
            gameParameters.LanguageStrings["already_guessed"] = "You already guessed that letter.";
            gameParameters.LanguageStrings["wrong_guess"] = "Wrong guess!";
            gameParameters.LanguageStrings["congratulations"] = "Congratulations! You guessed the word: ";
            gameParameters.LanguageStrings["sorry"] = "Sorry! You ran out of gameParameters.Attempts. The word was: ";
            gameParameters.LanguageStrings["play_again"] = "Do you want to play again? (y/n)";
            gameParameters.LanguageStrings["wrong_input"] = "Wrong input: ";
            gameParameters.LanguageStrings["random_name"] = "Random Name";
            gameParameters.LanguageStrings["country"] = "Country";
            gameParameters.LanguageStrings["english_word"] = "English Word";
            gameParameters.LanguageStrings["car_brand"] = "Car Brand";
            gameParameters.LanguageStrings["animal"] = "Animal";
        }
        // German strings
        else if (gameParameters.CurrentLanguage == "de")
        {
            gameParameters.LanguageStrings["welcome"] = "Willkommen bei Hangman!";
            gameParameters.LanguageStrings["select_category"] = "Bitte wählen Sie eine Kategorie aus:";
            gameParameters.LanguageStrings["invalid_choice"] = "Ungültige Wahl! Neustart des Spiels...";
            gameParameters.LanguageStrings["guess_word"] = "Wort: ";
            gameParameters.LanguageStrings["attempts_left"] = "Verbleibende Versuche: ";
            gameParameters.LanguageStrings["guessed_letters"] = "Geratene Buchstaben: ";
            gameParameters.LanguageStrings["guess_letter"] = "Errate einen Buchstaben: ";
            gameParameters.LanguageStrings["already_guessed"] = "Du hast diesen Buchstaben bereits geraten.";
            gameParameters.LanguageStrings["wrong_guess"] = "Falsches Raten!";
            gameParameters.LanguageStrings["congratulations"] = "Herzlichen Glückwunsch! Du hast das Wort erraten: ";
            gameParameters.LanguageStrings["sorry"] = "Es tut mir leid! Du hast keine Versuche mehr. Das Wort war: ";
            gameParameters.LanguageStrings["play_again"] = "Möchtest du noch einmal spielen? (j/n)";
            gameParameters.LanguageStrings["wrong_input"] = "Falsche Eingabe: ";
            gameParameters.LanguageStrings["random_name"] = "Zufälliger Name";
            gameParameters.LanguageStrings["country"] = "Land";
            gameParameters.LanguageStrings["english_word"] = "Englisches Wort";
            gameParameters.LanguageStrings["car_brand"] = "Automarke";
            gameParameters.LanguageStrings["animal"] = "Tier";
        }
        // Lithuanian strings
        else if (gameParameters.CurrentLanguage == "lt")
        {
            gameParameters.LanguageStrings["welcome"] = "Sveiki atvykę į Hangman!";
            gameParameters.LanguageStrings["select_category"] = "Prašome pasirinkti kategoriją:";
            gameParameters.LanguageStrings["invalid_choice"] = "Netinkamas pasirinkimas! Žaidimas paleidžiamas iš naujo...";
            gameParameters.LanguageStrings["guess_word"] = "Žodis: ";
            gameParameters.LanguageStrings["attempts_left"] = "Likę bandymai: ";
            gameParameters.LanguageStrings["guessed_letters"] = "Atspėtos raidės: ";
            gameParameters.LanguageStrings["guess_letter"] = "Spėkite raidę: ";
            gameParameters.LanguageStrings["already_guessed"] = "Jūs jau spėjote šią raidę.";
            gameParameters.LanguageStrings["wrong_guess"] = "Neteisingas spėjimas!";
            gameParameters.LanguageStrings["congratulations"] = "Sveikiname! Jūs atspėjote žodį: ";
            gameParameters.LanguageStrings["sorry"] = "Atsiprašome! Bandymų nebeliko. Žodis buvo: ";
            gameParameters.LanguageStrings["play_again"] = "Ar norite žaisti dar kartą? (t/n)";
            gameParameters.LanguageStrings["wrong_input"] = "Neteisinga įvestis: ";
            gameParameters.LanguageStrings["random_name"] = "Atsitiktinis vardas";
            gameParameters.LanguageStrings["country"] = "Šalis";
            gameParameters.LanguageStrings["english_word"] = "Angliškas žodis";
            gameParameters.LanguageStrings["car_brand"] = "Automobilių markė";
            gameParameters.LanguageStrings["animal"] = "Gyvūnas";
        }
    }

    static void LoadCategoryData()
    {
        if (gameParameters.CurrentLanguage == "en")
        {
            gameParameters.CategoryData["random_name"] = ["Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack"];
            gameParameters.CategoryData["country"] = ["Germany", "France", "Italy", "Spain", "Canada", "Brazil", "Australia", "India", "Japan", "Mexico"];
            gameParameters.CategoryData["english_word"] = ["computer", "programming", "hangman", "dictionary", "algorithm", "network", "database", "software", "hardware", "debugging"];
            gameParameters.CategoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            gameParameters.CategoryData["animal"] = ["elephant", "tiger", "giraffe", "kangaroo", "penguin", "dolphin", "crocodile", "rhinoceros", "hippopotamus", "flamingo"];
        }
        else if (gameParameters.CurrentLanguage == "de")
        {
            gameParameters.CategoryData["random_name"] = ["Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Greta", "Hannah", "Ivy", "Jakob"];
            gameParameters.CategoryData["country"] = ["Deutschland", "Frankreich", "Italien", "Spanien", "Kanada", "Brasilien", "Australien", "Indien", "Japan", "Mexiko"];
            gameParameters.CategoryData["english_word"] = ["Computer", "Programmieren", "Hangman", "Wörterbuch", "Algorithmus", "Netzwerk", "Datenbank", "Software", "Hardware", "Debugging"];
            gameParameters.CategoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            gameParameters.CategoryData["animal"] = ["Elefant", "Tiger", "Giraffe", "Känguru", "Pinguin", "Delfin", "Krokodil", "Nashorn", "Nilpferd", "Flamingo"];
        }
        else if (gameParameters.CurrentLanguage == "lt")
        {
            gameParameters.CategoryData["random_name"] = ["Alicija", "Bobas", "Čarlis", "Deividas", "Eva", "Frankas", "Gracija", "Hana", "Iva", "Džekas"];
            gameParameters.CategoryData["country"] = ["Vokietija", "Prancūzija", "Italija", "Ispanija", "Kanada", "Brazilija", "Australija", "Indija", "Japonija", "Meksika"];
            gameParameters.CategoryData["english_word"] = ["kompiuteris", "programavimas", "kartuvas", "žodynas", "algoritmas", "tinklas", "duomenų bazė", "programinė įranga", "aparatinė įranga", "derinimas"];
            gameParameters.CategoryData["car_brand"] = ["Toyota", "Honda", "Ford", "BMW", "Audi", "Mercedes", "Volkswagen", "Chevrolet", "Nissan", "Hyundai"];
            gameParameters.CategoryData["animal"] = ["dramblys", "tigras", "žirafa", "kengūra", "pingvinas", "delfinas", "krokodilas", "rinozauras", "begemotas", "flamingas"];
        }
    }

    static void PlayGame()
    {
        PrintGameSelectionInfo();

        var userInput = Console.ReadLine();

        bool validChoice = int.TryParse(userInput, out int choice);
        if (!validChoice || choice < 1 || choice > 5)
        {
            Console.WriteLine(gameParameters.LanguageStrings["invalid_choice"]);
            return;
        }              

        Random random = new Random();
        switch (choice)
        {
            case 1:
                gameParameters.WordToGuess = gameParameters.CategoryData["random_name"][random.Next(gameParameters.CategoryData["random_name"].Length)];
                gameParameters.SelectedCategory = gameParameters.LanguageStrings["random_name"];
                break;
            case 2:
                gameParameters.WordToGuess = gameParameters.CategoryData["country"][random.Next(gameParameters.CategoryData["country"].Length)];
                gameParameters.SelectedCategory = gameParameters.LanguageStrings["country"];
                break;
            case 3:
                gameParameters.WordToGuess = gameParameters.CategoryData["english_word"][random.Next(gameParameters.CategoryData["english_word"].Length)];
                gameParameters.SelectedCategory = gameParameters.LanguageStrings["english_word"];
                break;
            case 4:
                gameParameters.WordToGuess = gameParameters.CategoryData["car_brand"][random.Next(gameParameters.CategoryData["car_brand"].Length)];
                gameParameters.SelectedCategory = gameParameters.LanguageStrings["car_brand"];
                break;
            case 5:
                gameParameters.WordToGuess = gameParameters.CategoryData["animal"][random.Next(gameParameters.CategoryData["animal"].Length)];
                gameParameters.SelectedCategory = gameParameters.LanguageStrings["animal"];
                break;
        }        

        gameParameters.WordToGuess = gameParameters.WordToGuess.ToUpper();

        char[] guessedWord = gameParameters.EmptyLine();

        while (gameParameters.Attempts > 0 && !gameParameters.WordGuessed)
        {
            do
            {
                Console.Clear();

                PrintGameStatus(guessedWord);

                userInput = Console.ReadLine();
            } while (userInput == null || userInput == "");

            char guessedLetter = char.ToUpper(userInput[0]);

            if (gameParameters.GuessedLetters.Contains(guessedLetter))
            {
                Console.WriteLine(gameParameters.LanguageStrings["already_guessed"]);
                continue;
            }

            gameParameters.GuessedLetters.Add(guessedLetter);

            if (gameParameters.WordToGuess.Contains(guessedLetter))
            {
                for (int i = 0; i < gameParameters.WordToGuess.Length; i++)
                {
                    if (gameParameters.WordToGuess[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                    }
                }
            }
            else
            {
                gameParameters.Attempts--;
                Console.WriteLine(gameParameters.LanguageStrings["wrong_guess"]);
            }

            gameParameters.WordGuessed = new string(guessedWord) == gameParameters.WordToGuess;
        }

        Console.Clear();
        DisplayHangman(6 - gameParameters.Attempts);

        if (gameParameters.WordGuessed)
        {
            Console.WriteLine("\n" + gameParameters.LanguageStrings["congratulations"] + gameParameters.WordToGuess);
        }
        else
        {
            Console.WriteLine("\n" + gameParameters.LanguageStrings["sorry"] + gameParameters.WordToGuess);
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
            Console.WriteLine($"\n{gameParameters.LanguageStrings["play_again"]}");
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
                    Console.WriteLine($"\n{gameParameters.LanguageStrings["wrong_input"]} {response}.\n");
                    doContinue = true;
                    break;
            }

        } while (doContinue);

        return doPlayAgain;
    }

    static void PrintGameStatus(char[] guessedWord)
    {
        Console.Clear();
        DisplayHangman(6 - gameParameters.Attempts);
        Console.WriteLine("\n" + gameParameters.LanguageStrings["guess_word"] + new string(guessedWord));
        Console.WriteLine(gameParameters.LanguageStrings["attempts_left"] + gameParameters.Attempts);
        Console.WriteLine(gameParameters.LanguageStrings["guessed_letters"] + string.Join(", ", gameParameters.GuessedLetters));
        Console.WriteLine("Selected Category: " + gameParameters.SelectedCategory);
        Console.Write(gameParameters.LanguageStrings["guess_letter"]);
    }

    static void PrintGameSelectionInfo()
    {
        Console.WriteLine(gameParameters.LanguageStrings["welcome"]);
        Console.WriteLine(gameParameters.LanguageStrings["select_category"]);
        Console.WriteLine("1. " + gameParameters.LanguageStrings["random_name"]);
        Console.WriteLine("2. " + gameParameters.LanguageStrings["country"]);
        Console.WriteLine("3. " + gameParameters.LanguageStrings["english_word"]);
        Console.WriteLine("4. " + gameParameters.LanguageStrings["car_brand"]);
        Console.WriteLine("5. " + gameParameters.LanguageStrings["animal"]);
    }
}