using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Isabella Da Silva
// First Game

namespace GuessingGame
{
    public class Game
    {
        private readonly Random random;
        private int secretNumber;
        private int attemptsLeft;

        public Game()
        {
            random = new Random();
            StartNewGame();
        }

        public void StartNewGame()
        {
            secretNumber = random.Next(1, 11);
            attemptsLeft = 5;
        }

        public int AttemptsLeft { get { return attemptsLeft; } }
        public int SecretNumber { get { return secretNumber; } }

        public bool CheckGuess(int guess, out string resultMessage)
        {
            if (guess == secretNumber)
            {
                resultMessage = "Congratulations! You guessed the number!";
                return true;
            }
            else
            {
                attemptsLeft--;
                if (attemptsLeft == 0)
                {
                    resultMessage = "Sorry, you've run out of attempts. The number was " + secretNumber;
                    return false;
                }
                else
                {
                    resultMessage = guess < secretNumber ? "Too low! Try again." : "Too high! Try again.";
                    return false;
                }
            }
        }
    }
}
