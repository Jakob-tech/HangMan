namespace Game
{
    public class GameParameters
    {
        public string WordToGuess { get; set; }
        public List<char> GuessedLetters { get; set; }
        public int Attempts { get; set; }
        public bool WordGuessed { get; set; }

        public GameParameters(int atempts) 
        {
            WordToGuess = "";
            GuessedLetters = new List<char>();
            Attempts = atempts;
            WordGuessed = false;
        }

        public char[] EmptyLine()
        {
            return new string('_', WordToGuess.Length).ToCharArray();
        }
    }
}
