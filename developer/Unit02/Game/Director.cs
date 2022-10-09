using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        bool _isPlaying = true;
        int _score = 300;
        string _userGuess = "";
        int _currentCard = 0;
        int _nextCard = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            Card card = new Card();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to play a game.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Play again? [y/n] ");
            string playAgain = Console.ReadLine();
            _isPlaying = (playAgain == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 300;
            Card card = new Card();
            _currentCard = card.Draw();
            Console.WriteLine($"The current card is: {_currentCard}");
            Console.Write("Higher or Lower? [h/l]");
            string _userGuess = Console.ReadLine();
            _nextCard = card.Draw();
            Console.WriteLine($"Next card was: {_nextCard}");

            if (_userGuess == "h")
            {
                if (_nextCard > _currentCard)
                {
                    _score += 100;
                }
                else if (_nextCard < _currentCard)
                {
                    _score -= 75;
                }
            }
            else if (_userGuess == "l")
            {
                if (_nextCard > _currentCard)
                {
                    _score -= 75;
                }
                else if (_nextCard < _currentCard)
                {
                    _score += 100;
                }
            }
            
        }

        /// <summary>
        /// Displays the score. Also asks the player if they want to play again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }
            Console.WriteLine($"Your score is: {_score}\n");
            _isPlaying = (_score > 0);
        }
    }
}


