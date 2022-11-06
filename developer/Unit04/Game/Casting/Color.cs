using System.Collections.Generic;


namespace CSE210_Greed.Game.Casting
{
    public class Color ///setting all colors with values to be used privately
        {
            private int red = 0;
            private int green = 0;
            private int blue = 0;
            private int alpha = 255;



            public Color (int red, int green, int blue, int alpha)
            { /// setting colors with names and their corresponding colors
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.alpha = alpha;

            }

            public int GetBlue()
            { /// makes blue usable
                return blue;

            }

            public int GetGreen()
            { /// makes green usable
                return green;

            }

            public int GetRed() /// makes red usable
            {
                return red;

            }

            public int GetAlpha()
            { /// makes alpha usable
                return alpha;

            }

        }
}