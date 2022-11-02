using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Trevor Withers
/// <summary>
/// This a program to play the game Wheel Of Fortune
/// </summary>

namespace Assignment2_TrevorWithers
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Game game1;

        public Form1()
        {
            InitializeComponent();
            Game.TargetWords = new string[] { "Elephant", "Dragon", "Marble", "Seahorse", "Canada", "Eiffel Tower" };
            Game.Prizes = new int[] { 500, 550, 600, 650, 700, 800, 900, 5000 };
            Game.NewGame = true;
        }

        /// <summary>
        /// Shows welcome message and instructions
        /// </summary>
        private void ShowWelcomeMsg()
        {
            MessageBox.Show("\t\tHello! Welcome to The Wheel of Fortune!\nTo play the game " +
                            "enter your's and your opponent's name in the name box.\nYou can press enter to move to the " +
                            "next box or the corresponding button.\nGuess 1 letter at a time and press the guess button " +
                            "to guess or press enter.");
            MessageBox.Show("You can also save your game using the save button or load a previously saved game.\n" +
                            "You can also reset your game at any time using the reset button, " +
                            "but you will loose all progress and scores!");
        }

        /// <summary>
        /// Creates a string filled with the underscore 
        /// character representing each letter of the alphabet.
        /// </summary>
        /// <returns>letters</returns>
        public string FillGuessedLetters()
        {
            guessedLetters.Text = "";
            string letters = "";

            for (int ctr = 0; ctr < 26; ctr++)
            {
                letters += "_";
            }

            return letters;
        }
        /// <summary>
        /// Event handler for the start game button. Calls the StartTheGame() function.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void startGame_Click(object sender, EventArgs e)
        {
            StartTheGame();
        }
        /// <summary>
        /// Primary function for running the game mechanics.
        /// </summary>
        private void StartTheGame()
        {
            //Ensures that both player name boxes are filled.
            if (player1Name.Text == "" || player2Name.Text == "")
            {
                MessageBox.Show("You cannot leave the player name boxes blank.");
            }
            else
            {
                //Determines if this is the first time that the game has run and only creates the objects once.
                if (Game.NewGame)
                {
                    save.Enabled = true;
                    guessLetter.Enabled = true;
                    playerGuess.Enabled = true;
                    resetGame.Enabled = true;
                    player1 = new Player(player1Name.Text);
                    player2 = new Player(player2Name.Text);
                    game1 = new Game();
                    Game.NewGame = false;
                }
                else
                {
                    //Resets the player scores.
                    player1Score.Text = "0";
                    player2Score.Text = "0";
                }
                ResetPlayerGuess();

                game1.AssignTargetWord();

                //Fills the targetWord box.
                game1.HiddenWord = game1.GenerateHidden(game1.TargetWord.Length);
                targetWord.Text = game1.HiddenWord;

                //Fills the guessed letters box with underscores.
                game1.GuessedLettersBox = FillGuessedLetters();
                guessedLetters.Text = game1.GuessedLettersBox;

                RandomizePrize();

                DeterminePlayerTurn(false, false, true);

                startGame.Enabled = false;
                player1Name.ReadOnly = true;
                player2Name.ReadOnly = true;
            }
        }

        /// <summary>
        /// Changes the prizes picture box to the appropriate picture.
        /// </summary>
        private async void RandomizePrize()
        {
            prizes.Image = Assignment2_TrevorWithers.Properties.Resources.spinningWheel;

            //Forces the program to wait to allow the gif to play for 500 milliseconds.
            await Task.Delay(500);


            game1.RandomPrize();
            switch (game1.CurrentPrize)
            {
                case 500:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._500_Pink;
                    break;
                case 550:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._550_Blue;
                    break;
                case 600:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._600_Red;
                    break;
                case 650:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._650_Purple;
                    break;
                case 700:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._700_Yellow;
                    break;
                case 800:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._800_Red;
                    break;
                case 900:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._900_Orange;
                    break;
                default:
                    prizes.Image = Assignment2_TrevorWithers.Properties.Resources._5000;
                    break;
            }
        }

        /// <summary>
        /// Event handler for the guessLetter button.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void guessLetter_Click(object sender, EventArgs e)
        {
            GuessALetter();
        }

        /// <summary>
        /// Event handler for the playerGuess text box that listens for the enter key being pressed
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void playerGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GuessALetter();
            }
        }

        /// <summary>
        /// Searched the GuessedLettersArray to determine if the letter has been guessed and returns true or false.
        /// </summary>
        /// <returns>haveGuessed</returns>
        private bool HaveGuessedLetter()
        {
            bool haveGuessed = false;
            for (int index = 0; index < game1.GuessedLettersLength; index++)
            {
                if (game1.GuessedLettersArray[index] == Char.Parse(playerGuess.Text))
                {
                    haveGuessed = true;
                }
            }
            return haveGuessed;
        }

        /// <summary>
        /// Primary function for the letter guessing mechanics of the game.
        /// </summary>
        private void GuessALetter()
        {
            //Ensures that the playerGuess text box is not blank and that the letter has not been guessed.
            if (playerGuess.Text == "" || HaveGuessedLetter())
            {
                MessageBox.Show("You cannot re-guess the same letter or leave the box empty.");
            }
            else
            {
                UpdateGuessedLetterArray();

                //Determines if the letter was incorrect.
                if (SearchForLetter() == false)
                {
                    MessageBox.Show("Sorry, you have guessed incorrectly.");
                }

                UpdateLettersGuessedBox();

                DetermineWordGuessed();


                game1.PlayerTurn = DeterminePlayerTurn(false, true, false);
                RandomizePrize();
            }
            ResetPlayerGuess();
        }

        /// <summary>
        /// Resets the playerGuess box and focuses on it.
        /// </summary>
        private void ResetPlayerGuess()
        {
            playerGuess.Text = "";
            playerGuess.Focus();
        }

        /// <summary>
        /// Updates the array for storing guessed letters
        /// and updates the number of letters guessed.
        /// </summary>
        private void UpdateGuessedLetterArray()
        {
            game1.GuessedLettersArray[game1.GuessedLettersLength] = Char.Parse(playerGuess.Text);
            game1.GuessedLettersLength++;
        }

        /// <summary>
        /// Searches the target word for the guessed letter and updates if found. Returns false if none found.
        /// </summary>
        /// <returns>guessedCorrectly</returns>
        private bool SearchForLetter()
        {
            char[] secretWord = targetWord.Text.ToCharArray();
            int pos = 0;
            bool guessedCorrectly = false;

            for (; pos < game1.TargetWord.Length; pos++)
            {
                if (game1.TargetWord[pos] == Char.Parse(playerGuess.Text.ToLower()))
                {
                    if (pos == 0 || secretWord[pos - 1] == ' ')
                    {
                        secretWord[pos] = Char.Parse(playerGuess.Text.ToUpper());
                    }
                    else
                    {
                        secretWord[pos] = Char.Parse(playerGuess.Text.ToLower());
                    }
                    string convertChar = new string(secretWord);
                    game1.HiddenWord = convertChar;
                    targetWord.Text = game1.HiddenWord;
                    DeterminePlayerTurn(true, false, false);
                    guessedCorrectly = true;
                }
            }
            return guessedCorrectly;
        }

        /// <summary>
        /// Determines the player turn and returns it as an int.
        /// Allows for the function to be called in different scenarios.
        /// </summary>
        /// <param>name="addScore"</param>
        /// <param>name="switchTurn"</param>
        /// <param>name="firstTurn"</param>
        /// <returns>playerTurnNumber</returns>
        private int DeterminePlayerTurn(bool addScore, bool switchTurn, bool firstTurn)
        {
            int playerTurnNumber = game1.PlayerTurn;

            switch (game1.PlayerTurn)
            {
                case 1:
                    if (addScore)
                    {
                        player1.PlayerScore += game1.CurrentPrize;
                        player1Score.Text = "" + player1.PlayerScore;
                    }
                    if (switchTurn)
                    {
                        playerTurnNumber = 2;
                        playerCurrentTurn.Text = UpdatePlayerCurrentPlayerTurnBox(player2.PlayerName);
                    }
                    else if(firstTurn)
                    {
                        playerCurrentTurn.Text = UpdatePlayerCurrentPlayerTurnBox(player1.PlayerName);
                    }
                    
                    break;
                default:
                    if(addScore)
                    {
                        player2.PlayerScore += game1.CurrentPrize;
                        player2Score.Text = "" + player2.PlayerScore;
                    }

                    if (switchTurn)
                    {
                        playerTurnNumber = 1;
                        playerCurrentTurn.Text = UpdatePlayerCurrentPlayerTurnBox(player1.PlayerName);
                    }
                    else if(firstTurn)
                    {
                        playerCurrentTurn.Text = UpdatePlayerCurrentPlayerTurnBox(player2.PlayerName);
                    }

                    break;
            }

            return playerTurnNumber;
        }

        /// <summary>
        /// Creates a string to inform the user of the current turn.
        /// </summary>
        /// <param>name="currentPlayer"</param>
        /// <returns>currentPlayerStringMsg</returns>
        private string UpdatePlayerCurrentPlayerTurnBox(string currentPlayer)
        {
            string currentPlayerStringMsg = "It is " + currentPlayer + "'s turn";
            return currentPlayerStringMsg;
        }

        /// <summary>
        /// Uses ascii values to search through the letters of the alphabet
        /// and assigns the letter that the user guessed to the guessed letters text box.
        /// </summary>
        private void UpdateLettersGuessedBox()
        {
            for (int ctr = 65; ctr < 90; ctr++)
            {
                if (ctr == Char.Parse(playerGuess.Text.ToUpper()))
                {
                    string s = Encoding.ASCII.GetString(new byte[] { byte.Parse(ctr + "") });
                    game1.GuessedLettersBox = game1.GuessedLettersBox.Remove(ctr - 65, 1);
                    game1.GuessedLettersBox = game1.GuessedLettersBox.Insert(ctr - 65, s);
                    guessedLetters.Text = game1.GuessedLettersBox;
                }
            }
        }

        /// <summary>
        /// Determines if the word has been guessed.
        /// </summary>
        private void DetermineWordGuessed()
        {
            if (targetWord.Text.ToLower() == game1.TargetWord)
            {
                game1.RemoveGuessedWord(game1.HiddenWord);
                DetermineWinner();
            }
        }

        /// <summary>
        /// Determines the winner based on the score.
        /// </summary>
        private void DetermineWinner()
        {
            string winner;
            if (player1.PlayerScore > player2.PlayerScore)
            {
                winner = player1.PlayerName;
                player1.NumOfWins++;
                winsPlayer1.Text = player1.NumOfWins + "";
                player2.NumOfLosses++;
                lossesPlayer2.Text = player2.NumOfLosses + "";
            }
            else
            {
                winner = player2.PlayerName;
                player2.NumOfWins++;
                winsPlayer2.Text = player2.NumOfWins + "";
                player1.NumOfLosses++;
                lossesPlayer1.Text = player1.NumOfLosses + "";
            }
            game1.GuessedLettersLength = 0;
            ShowWinnerMessage(winner);
            
        }

        /// <summary>
        /// Displays the winning player to a message box.
        /// Also checks if all words have been guessed and ends the game if they have.
        /// </summary>
        /// <param>name="pWinner"</param>
        private void ShowWinnerMessage(string pWinner)
        {
            if(game1.TargetWordsLength > 0)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show(pWinner + " is the winner! Do you want to play again?",
                                                "Word guessed!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    StartTheGame();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("The program will now close...");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("All words have been guessed. I hope you had fun! The program will now close.");
                Application.Exit();
            }
        }

        /// <summary>
        /// Event handler for the player 1 name box that listens for the enter key press.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void player1Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                player2Name.Focus();
            }
        }

        /// <summary>
        /// Event handler for the player 2 name box that listens for the enter key press.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void player2Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                StartTheGame();
            }
        }

        /// <summary>
        /// Event handler for the save button that allows the user to save all current game detail to play later.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void save_Click(object sender, EventArgs e)
        {
            FileStream player1_O = new FileStream("..\\..\\player1.dat", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(player1_O, player1);
            player1_O.Close();
            FileStream player2_O = new FileStream("..\\..\\player2.dat", FileMode.OpenOrCreate);
            binaryFormatter.Serialize(player2_O, player2);
            player2_O.Close();
            FileStream game_O = new FileStream("..\\..\\game.dat", FileMode.OpenOrCreate);
            binaryFormatter.Serialize(game_O, game1);
            game_O.Close();
        }

        /// <summary>
        /// Loads a previous save game from a file.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void load_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter =new BinaryFormatter();

            FileStream player1_I = new FileStream("..\\..\\player1.dat", FileMode.Open);
                
            player1 = (Player)binaryFormatter.Deserialize(player1_I);
                
            player1Name.Text = player1.PlayerName;
                winsPlayer1.Text = player1.NumOfWins+ "";
                lossesPlayer1.Text = player1.NumOfLosses + "";
                player1Score.Text = player1.PlayerScore + "";
            player1_I.Close();

            FileStream player2_I = new FileStream("..\\..\\player2.dat", FileMode.Open);
                player2 = (Player)binaryFormatter.Deserialize(player2_I);
                player2Name.Text = player2.PlayerName;
                winsPlayer2.Text = player2.NumOfWins + "";
                lossesPlayer2.Text = player2.NumOfLosses + "";
                player2Score.Text = player2.PlayerScore + "";
            player2_I.Close();

            FileStream game1_I = new FileStream("..\\..\\game.dat", FileMode.Open);
                game1 = (Game)binaryFormatter.Deserialize(game1_I);
                targetWord.Text = game1.HiddenWord;
                guessedLetters.Text = game1.GuessedLettersBox;
                DeterminePlayerTurn(false, false, true);
                save.Enabled = true;
                playerGuess.Enabled = true;
                guessLetter.Enabled = true;
                resetGame.Enabled = true;
                playerGuess.Focus();
                Game.NewGame = false;
                player1Name.ReadOnly = true;
                player2Name.ReadOnly = true;
                startGame.Enabled = false;
            game1_I.Close();
        }

        /// <summary>
        /// Calls the welcome message function.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowWelcomeMsg();
        }

        /// <summary>
        /// Resets the game values to blank or 0 and resets all game conditions.
        /// </summary>
        /// <param>name="sender"</param>
        /// <param>name="e"</param>
        private void resetGame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to reset your game? " +
                                           "All progress and scores will be lost.",
                                           "Reset Game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                player1Name.Focus();
                Game.NewGame = true;
                startGame.Enabled = true;
                save.Enabled = false;
                guessLetter.Enabled = false;
                playerGuess.Enabled = false;
                player1Name.ReadOnly = false;
                player2Name.ReadOnly = false;
                player1Name.Text = "";
                winsPlayer1.Text = "0";
                lossesPlayer1.Text = "0";
                player2Name.Text = "";
                winsPlayer2.Text = "0";
                lossesPlayer2.Text = "0";
                player1Score.Text = "0";
                player2Score.Text = "0";
                playerCurrentTurn.Text = "";
                targetWord.Text = "";
                guessedLetters.Text = "";
                resetGame.Enabled = false;
            }
        }
    }
}