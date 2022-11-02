namespace Assignment2_TrevorWithers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.player1NameLbl = new System.Windows.Forms.Label();
            this.targetWordLbl = new System.Windows.Forms.Label();
            this.player2NameLbl = new System.Windows.Forms.Label();
            this.userGuessLbl = new System.Windows.Forms.Label();
            this.player1ScoreLbl = new System.Windows.Forms.Label();
            this.player2ScoreLbl = new System.Windows.Forms.Label();
            this.guessLetter = new System.Windows.Forms.Button();
            this.currentTurnLabel = new System.Windows.Forms.Label();
            this.winsLabel1 = new System.Windows.Forms.Label();
            this.lossesLabel1 = new System.Windows.Forms.Label();
            this.winsLabel2 = new System.Windows.Forms.Label();
            this.lossesLabel2 = new System.Windows.Forms.Label();
            this.lossesPlayer1 = new System.Windows.Forms.Label();
            this.winsPlayer1 = new System.Windows.Forms.Label();
            this.winsPlayer2 = new System.Windows.Forms.Label();
            this.lossesPlayer2 = new System.Windows.Forms.Label();
            this.prizes = new System.Windows.Forms.PictureBox();
            this.guessedLettersLabel = new System.Windows.Forms.Label();
            this.playerGuess = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.targetWord = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.playerCurrentTurn = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.guessedLetters = new System.Windows.Forms.Label();
            this.resetGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prizes)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(73, 60);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(135, 34);
            this.player1Name.TabIndex = 0;
            this.player1Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.player1Name_KeyDown);
            // 
            // player2Name
            // 
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(648, 60);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(125, 34);
            this.player2Name.TabIndex = 2;
            this.player2Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.player2Name_KeyDown);
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(363, 88);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(104, 35);
            this.startGame.TabIndex = 5;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // player1NameLbl
            // 
            this.player1NameLbl.AutoSize = true;
            this.player1NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLbl.Location = new System.Drawing.Point(59, 28);
            this.player1NameLbl.Name = "player1NameLbl";
            this.player1NameLbl.Size = new System.Drawing.Size(171, 29);
            this.player1NameLbl.TabIndex = 9;
            this.player1NameLbl.Text = "Player 1 Name";
            // 
            // targetWordLbl
            // 
            this.targetWordLbl.AutoSize = true;
            this.targetWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWordLbl.Location = new System.Drawing.Point(84, 202);
            this.targetWordLbl.Name = "targetWordLbl";
            this.targetWordLbl.Size = new System.Drawing.Size(182, 29);
            this.targetWordLbl.TabIndex = 10;
            this.targetWordLbl.Text = "Word To Guess";
            // 
            // player2NameLbl
            // 
            this.player2NameLbl.AutoSize = true;
            this.player2NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLbl.Location = new System.Drawing.Point(627, 28);
            this.player2NameLbl.Name = "player2NameLbl";
            this.player2NameLbl.Size = new System.Drawing.Size(171, 29);
            this.player2NameLbl.TabIndex = 11;
            this.player2NameLbl.Text = "Player 2 Name";
            // 
            // userGuessLbl
            // 
            this.userGuessLbl.AutoSize = true;
            this.userGuessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuessLbl.Location = new System.Drawing.Point(64, 305);
            this.userGuessLbl.Name = "userGuessLbl";
            this.userGuessLbl.Size = new System.Drawing.Size(170, 29);
            this.userGuessLbl.TabIndex = 12;
            this.userGuessLbl.Text = "Guess A Letter";
            // 
            // player1ScoreLbl
            // 
            this.player1ScoreLbl.AutoSize = true;
            this.player1ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLbl.Location = new System.Drawing.Point(96, 697);
            this.player1ScoreLbl.Name = "player1ScoreLbl";
            this.player1ScoreLbl.Size = new System.Drawing.Size(170, 29);
            this.player1ScoreLbl.TabIndex = 13;
            this.player1ScoreLbl.Text = "Player 1 Score";
            // 
            // player2ScoreLbl
            // 
            this.player2ScoreLbl.AutoSize = true;
            this.player2ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLbl.Location = new System.Drawing.Point(659, 697);
            this.player2ScoreLbl.Name = "player2ScoreLbl";
            this.player2ScoreLbl.Size = new System.Drawing.Size(170, 29);
            this.player2ScoreLbl.TabIndex = 14;
            this.player2ScoreLbl.Text = "Player 2 Score";
            // 
            // guessLetter
            // 
            this.guessLetter.Enabled = false;
            this.guessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLetter.Location = new System.Drawing.Point(90, 377);
            this.guessLetter.Name = "guessLetter";
            this.guessLetter.Size = new System.Drawing.Size(112, 40);
            this.guessLetter.TabIndex = 15;
            this.guessLetter.Text = "Guess";
            this.guessLetter.UseVisualStyleBackColor = true;
            this.guessLetter.Click += new System.EventHandler(this.guessLetter_Click);
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTurnLabel.Location = new System.Drawing.Point(342, 5);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(148, 29);
            this.currentTurnLabel.TabIndex = 17;
            this.currentTurnLabel.Text = "Current Turn";
            // 
            // winsLabel1
            // 
            this.winsLabel1.AutoSize = true;
            this.winsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel1.Location = new System.Drawing.Point(77, 107);
            this.winsLabel1.Name = "winsLabel1";
            this.winsLabel1.Size = new System.Drawing.Size(117, 29);
            this.winsLabel1.TabIndex = 19;
            this.winsLabel1.Text = "# of Wins:";
            // 
            // lossesLabel1
            // 
            this.lossesLabel1.AutoSize = true;
            this.lossesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLabel1.Location = new System.Drawing.Point(53, 136);
            this.lossesLabel1.Name = "lossesLabel1";
            this.lossesLabel1.Size = new System.Drawing.Size(141, 29);
            this.lossesLabel1.TabIndex = 20;
            this.lossesLabel1.Text = "# of Losses:";
            // 
            // winsLabel2
            // 
            this.winsLabel2.AutoSize = true;
            this.winsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel2.Location = new System.Drawing.Point(627, 107);
            this.winsLabel2.Name = "winsLabel2";
            this.winsLabel2.Size = new System.Drawing.Size(117, 29);
            this.winsLabel2.TabIndex = 21;
            this.winsLabel2.Text = "# of Wins:";
            // 
            // lossesLabel2
            // 
            this.lossesLabel2.AutoSize = true;
            this.lossesLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLabel2.Location = new System.Drawing.Point(603, 136);
            this.lossesLabel2.Name = "lossesLabel2";
            this.lossesLabel2.Size = new System.Drawing.Size(141, 29);
            this.lossesLabel2.TabIndex = 22;
            this.lossesLabel2.Text = "# of Losses:";
            // 
            // lossesPlayer1
            // 
            this.lossesPlayer1.AutoSize = true;
            this.lossesPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesPlayer1.Location = new System.Drawing.Point(200, 136);
            this.lossesPlayer1.Name = "lossesPlayer1";
            this.lossesPlayer1.Size = new System.Drawing.Size(26, 29);
            this.lossesPlayer1.TabIndex = 24;
            this.lossesPlayer1.Text = "0";
            // 
            // winsPlayer1
            // 
            this.winsPlayer1.AutoSize = true;
            this.winsPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsPlayer1.Location = new System.Drawing.Point(200, 107);
            this.winsPlayer1.Name = "winsPlayer1";
            this.winsPlayer1.Size = new System.Drawing.Size(26, 29);
            this.winsPlayer1.TabIndex = 25;
            this.winsPlayer1.Text = "0";
            // 
            // winsPlayer2
            // 
            this.winsPlayer2.AutoSize = true;
            this.winsPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsPlayer2.Location = new System.Drawing.Point(750, 107);
            this.winsPlayer2.Name = "winsPlayer2";
            this.winsPlayer2.Size = new System.Drawing.Size(26, 29);
            this.winsPlayer2.TabIndex = 26;
            this.winsPlayer2.Text = "0";
            // 
            // lossesPlayer2
            // 
            this.lossesPlayer2.AutoSize = true;
            this.lossesPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesPlayer2.Location = new System.Drawing.Point(750, 136);
            this.lossesPlayer2.Name = "lossesPlayer2";
            this.lossesPlayer2.Size = new System.Drawing.Size(26, 29);
            this.lossesPlayer2.TabIndex = 27;
            this.lossesPlayer2.Text = "0";
            // 
            // prizes
            // 
            this.prizes.Image = ((System.Drawing.Image)(resources.GetObject("prizes.Image")));
            this.prizes.Location = new System.Drawing.Point(937, 37);
            this.prizes.Name = "prizes";
            this.prizes.Size = new System.Drawing.Size(400, 400);
            this.prizes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.prizes.TabIndex = 7;
            this.prizes.TabStop = false;
            // 
            // guessedLettersLabel
            // 
            this.guessedLettersLabel.AutoSize = true;
            this.guessedLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedLettersLabel.Location = new System.Drawing.Point(332, 273);
            this.guessedLettersLabel.Name = "guessedLettersLabel";
            this.guessedLettersLabel.Size = new System.Drawing.Size(189, 29);
            this.guessedLettersLabel.TabIndex = 28;
            this.guessedLettersLabel.Text = "Guessed Letters";
            // 
            // playerGuess
            // 
            this.playerGuess.Enabled = false;
            this.playerGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerGuess.Location = new System.Drawing.Point(122, 337);
            this.playerGuess.Mask = "L";
            this.playerGuess.Name = "playerGuess";
            this.playerGuess.Size = new System.Drawing.Size(52, 34);
            this.playerGuess.TabIndex = 29;
            this.playerGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerGuess_KeyDown);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(363, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(104, 36);
            this.save.TabIndex = 30;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(363, 171);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(104, 35);
            this.load.TabIndex = 31;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // targetWord
            // 
            this.targetWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWord.Location = new System.Drawing.Point(47, 249);
            this.targetWord.Name = "targetWord";
            this.targetWord.Size = new System.Drawing.Size(262, 39);
            this.targetWord.TabIndex = 32;
            this.targetWord.Text = " ";
            this.targetWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2Score
            // 
            this.player2Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(698, 666);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(100, 31);
            this.player2Score.TabIndex = 34;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerCurrentTurn
            // 
            this.playerCurrentTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCurrentTurn.Location = new System.Drawing.Point(310, 37);
            this.playerCurrentTurn.Name = "playerCurrentTurn";
            this.playerCurrentTurn.Size = new System.Drawing.Size(211, 31);
            this.playerCurrentTurn.TabIndex = 35;
            this.playerCurrentTurn.Text = " ";
            this.playerCurrentTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player1Score
            // 
            this.player1Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(126, 666);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(100, 31);
            this.player1Score.TabIndex = 36;
            this.player1Score.Text = "0";
            this.player1Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guessedLetters
            // 
            this.guessedLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.5F);
            this.guessedLetters.Location = new System.Drawing.Point(310, 305);
            this.guessedLetters.Name = "guessedLetters";
            this.guessedLetters.Size = new System.Drawing.Size(232, 214);
            this.guessedLetters.TabIndex = 37;
            this.guessedLetters.Text = " ";
            this.guessedLetters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetGame
            // 
            this.resetGame.Enabled = false;
            this.resetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGame.Location = new System.Drawing.Point(648, 305);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(173, 35);
            this.resetGame.TabIndex = 38;
            this.resetGame.Text = "Reset Game";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 828);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.guessedLetters);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.playerCurrentTurn);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.targetWord);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.playerGuess);
            this.Controls.Add(this.guessedLettersLabel);
            this.Controls.Add(this.lossesPlayer2);
            this.Controls.Add(this.winsPlayer2);
            this.Controls.Add(this.winsPlayer1);
            this.Controls.Add(this.lossesPlayer1);
            this.Controls.Add(this.lossesLabel2);
            this.Controls.Add(this.winsLabel2);
            this.Controls.Add(this.lossesLabel1);
            this.Controls.Add(this.winsLabel1);
            this.Controls.Add(this.currentTurnLabel);
            this.Controls.Add(this.guessLetter);
            this.Controls.Add(this.player2ScoreLbl);
            this.Controls.Add(this.player1ScoreLbl);
            this.Controls.Add(this.userGuessLbl);
            this.Controls.Add(this.player2NameLbl);
            this.Controls.Add(this.targetWordLbl);
            this.Controls.Add(this.player1NameLbl);
            this.Controls.Add(this.prizes);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Name = "Form1";
            this.Text = "Wheel Of Fortune";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox prizes;
        private System.Windows.Forms.Label player1NameLbl;
        private System.Windows.Forms.Label targetWordLbl;
        private System.Windows.Forms.Label player2NameLbl;
        private System.Windows.Forms.Label userGuessLbl;
        private System.Windows.Forms.Label player1ScoreLbl;
        private System.Windows.Forms.Label player2ScoreLbl;
        private System.Windows.Forms.Button guessLetter;
        private System.Windows.Forms.Label currentTurnLabel;
        private System.Windows.Forms.Label winsLabel1;
        private System.Windows.Forms.Label lossesLabel1;
        private System.Windows.Forms.Label winsLabel2;
        private System.Windows.Forms.Label lossesLabel2;
        private System.Windows.Forms.Label lossesPlayer1;
        private System.Windows.Forms.Label winsPlayer1;
        private System.Windows.Forms.Label winsPlayer2;
        private System.Windows.Forms.Label lossesPlayer2;
        private System.Windows.Forms.Label guessedLettersLabel;
        private System.Windows.Forms.MaskedTextBox playerGuess;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label targetWord;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label playerCurrentTurn;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label guessedLetters;
        private System.Windows.Forms.Button resetGame;
    }
}

