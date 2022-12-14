using System;
///Here we have the board of our game. Here we will create the men and the spaces for our game.
namespace Unit03.Game
{
    public class Jumper 
    {
        public Jumper()
        {            
        }

        public string[] DisplayParachute()
        {
            string[] parachute = {
                "  ___"," |___|",
                " L   J",
                "  I I",
                "   O",
                "  J|L","   JL",
                "          ",
                "^^^^^^^^"};

                  return parachute;
        }
        public string[] GameOver()
        {
            string[] noParachute = {
                "   X",
                "  J|L","   JL",
                "          ",
                "^^^^^^^^"};

                  return noParachute;
        }
        public string[] Hint()
        {
            string[] hint = {
                "_ ",
                "_ ",
                "_ ",
                "_ ",
            };

            return hint;
        }
    }
}