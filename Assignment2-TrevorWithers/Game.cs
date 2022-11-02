using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Trevor Withers
/// <summary>
/// Tracks the game word and current prize
/// </summary>

namespace Assignment2_TrevorWithers
{
    [Serializable]
    internal class Game
    {
        public static string[] TargetWords { get; set; }
        public static int[] Prizes { get; set; }
        public static bool NewGame { get; set; }
        public char[] GuessedLettersArray { get; set; }
        public string TargetWord { get; set; }
        public string GuessedLettersBox { get; set; }
        public string HiddenWord { get; set; }
        public int TargetWordsLength { get; set; } = 6;
        public int CurrentPrize { get; set; }
        public int PlayerTurn { get; set; }
        public int GuessedLettersLength { get; set; }
        private const int LETTERSARRAYLENGTH = 26;


        public Game()
        {
            GuessedLettersArray = new char[LETTERSARRAYLENGTH];
            GuessedLettersLength = 0;

            //Determines which player goes first.
            Random rand = new Random();
            int whoGoesFirst = rand.Next() % 2 + 1;
            PlayerTurn = whoGoesFirst;
        }

        /// <summary>
        /// Randomizes the prize value.
        /// </summary>
        public void RandomPrize()
        {
            Random rand = new Random();
            int prizeAmt = rand.Next() % Prizes.Length;
            CurrentPrize = Prizes[prizeAmt];
        }

        /// <summary>
        /// Assigns the random target word for the round.
        /// </summary>
        public void AssignTargetWord()
        {
            Random rand = new Random();
            int randWord = 0;
            if (TargetWordsLength > 0)
            {
                randWord = rand.Next() % TargetWordsLength;
            }
            TargetWord = TargetWords[randWord];
            TargetWord = TargetWord.ToLower();
        }

        /// <summary>
        /// Creates the string of dashes that represent the target word.
        /// </summary>
        /// <param>name="passedLength"</param>
        /// <returns>hiddenWord</returns>
        public string GenerateHidden(int passedLength)
        {
            string hiddenWord = "";

            for (int index = 0; index < passedLength; index++)
            {
                if (TargetWord[index] == Char.Parse(" "))
                {
                    hiddenWord += " ";
                }
                else
                {
                    hiddenWord += "-";
                }
            }

            return hiddenWord;
        }

        /// <summary>
        /// Removes the guessed word from the array so that it cannot be guessed again.
        /// </summary>
        /// <param>name="pGuessedWord"</param>
        public void RemoveGuessedWord(string pGuessedWord)
        {
            int pos = 0;
            for (; pos < TargetWordsLength; pos++)
            {
                if (TargetWords[pos] == pGuessedWord)
                {
                    TargetWords[pos] = "";
                    break;
                }
            }

            TargetWordsLength--;
            for (int index = pos; index < TargetWordsLength; index++)
            {
                TargetWords[index] = TargetWords[index + 1];
            }

            
        }
    }
}
