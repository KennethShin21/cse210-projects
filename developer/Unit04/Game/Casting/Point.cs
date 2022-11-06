namespace CSE210_Greed.Game.Casting
{
    public class Point
    {
        private int x = 0;
        private int y = 0;

        /// <summary>
        /// Creates a new instance of Location with x and y coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Adds the previous location with the old location to create the new coordinates
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Point Add(Point other)
        {
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();
            return new Point(x, y);
        }

        /// <summary>
        /// Returns if the new location is the same as the old location
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Point other)
        {
            return this.x == other.GetX() && this.y == other.GetY();
        }

        /// <summary>
        /// Returns the x coordinate
        /// </summary>
        public int GetX()
        {
            return x;
        }
         /// <summary>
        /// Returns the y coordinate
        /// </summary>
        public int GetY()
        {
            return y;
        }

        /// <summary>
        /// Factors the x and y coordinates to fit on the game grid
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public Point Scale(int factor)
        {
            int x = this.x * factor;
            int y = this.y * factor;
            return new Point(x, y);
        }


    }
    
    
}