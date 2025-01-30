using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Isabella Da Silva
// First Game

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private Game game;
        private Player player;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            player = new Player("");
            DisplayPlayerStats();
            HideGameElements();
        }

        private void StartNewGame()
        {
            game.StartNewGame();
            attemptsLabel.Text = "Attempts left:" + game.AttemptsLeft;
            guessTextBox.Text = "";
            resultLabel.Text = "";
        }

        private void CheckGuess()
        {
            int guess;
            if (int.TryParse(guessTextBox.Text, out guess))
            {
                string resultMessage;
                bool isCorrect = game.CheckGuess(guess, out resultMessage);
                resultLabel.Text = resultMessage;

                if (isCorrect)
                {
                    resultPictureBox.Image = Properties.Resources.guessed;
                    PromptPlayAgain();
                }
                else if (game.AttemptsLeft == 0)
                {
                    resultPictureBox.Image = Properties.Resources.lose;
                    PromptPlayAgain();
                }
                else
                {

                    DisplayPlayerStats();
                    attemptsLabel.Text = "Attempts left:" + game.AttemptsLeft;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void DisplayPlayerStats()
        {
            gamesPlayedLabel.Text = "Games Played: " + player.GamesPlayed;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        private void PromptPlayAgain()
        {
            player.IncrementGamesPlayed();
            DisplayPlayerStats();
            if (MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StartNewGame();
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameMaskedTextBox.Text))
            {
                player = new Player(nameMaskedTextBox.Text);
                ShowGameElements();
                StartNewGame();
            }
            else
            {
                MessageBox.Show("Please enter your name.");
            }
        }
        private void HideGameElements()
        {
            guessButton.Enabled = false;
            guessTextBox.Enabled = false;
            attemptsLabel.Visible = false;
            resultLabel.Visible = false;
            resultPictureBox.Visible = false;
        }

        private void ShowGameElements()
        {
            guessButton.Enabled = true;
            guessTextBox.Enabled = true;
            attemptsLabel.Visible = true;
            resultLabel.Visible = true;
            resultPictureBox.Visible = true;
        }
    }
}
