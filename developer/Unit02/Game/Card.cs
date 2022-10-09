using System;


namespace Unit02.Game
{
    /// <summary>
    /// Individual cards that are represented as a number from 1 to 13.
    /// 
    /// The responsibility of the card is to hold the value and to see if it is higher
    /// or lower than the guessed value by the user.
    ///
    /// The player starts with 300 points. 
    /// </summary>
    public class Card
    {
        public int _cardValue = 0;

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>

        public Card()
        {

        }
        
        /// <summary>
        /// Generates a random card from 1 to 13.
        /// And store the value.
        ///  
        /// </summary>

        public int Draw()
        {
            Random random = new Random();
            _cardValue = random.Next(1, 13);
            return _cardValue;
        }

    }

}