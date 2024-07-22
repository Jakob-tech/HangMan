namespace Game
{
    public class GameParameters
    {
        public string WordToGuess { get; set; }
        public List<char> GuessedLetters { get; set; }
        public int Attempts { get; set; }
        public bool WordGuessed { get; set; }
        public Dictionary<string, string> LanguageStrings { get; set; }
        public string CurrentLanguage { get; set; }
        public Dictionary<string, string[]> CategoryData { get; set; }
        public string SelectedCategory { get; set; }



        public GameParameters(int atempts) 
        {
            WordToGuess = "";
            GuessedLetters = new List<char>();
            Attempts = atempts;
            WordGuessed = false;
            LanguageStrings = new Dictionary<string, string>();
            CurrentLanguage = "en";
            CategoryData = new Dictionary<string, string[]>();
            SelectedCategory = "";
        }

        public char[] EmptyLine()
        {
            return new string('_', WordToGuess.Length).ToCharArray();
        }
    }
}
