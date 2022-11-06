using Raylib_cs;
using CSE210_Greed.Game.Casting;


namespace CSE210_Greed.Game.Services
{
    /// <summary>
    /// Allows use of keyboard.
    /// </summary>
    public class KeyboardService
    {
        private int cellSize = 15;

        /// <summary>
        /// Constructor  --  Sets how far each arrow will move.
        /// </summary>
        public KeyboardService(int cellSize)
        {
            this.cellSize = cellSize;
        }

        /// <summary>
        /// Converts keyboard presses into movement.
        /// </summary>
        public Location GetDirection(string downText = "")
        {
            int dx = 0;
            int dy = 0;
            // string  = "";
            if (downText == "down")
            {
                dy = 1;
                Location direction1 = new Location(dx, dy);
                direction1 = direction1.Scale(cellSize);

                return direction1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }


            Location direction = new Location(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }
    }
}