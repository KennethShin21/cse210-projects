using System;

namespace CSE210_Greed.Game.Casting
{
    public class Actor
    {
        private string text = " ";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255, 255);
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        /// <summary>
        /// Creates a new instance of actor
        /// </summary>
        public Actor()
        {

        }
        /// <summary>
        /// returns the color for the different instances of actor
        /// </summary>
        public Color GetColor()
        {
            return color;
        }

        /// <summary>
        /// returns the font size for the different instances of actor
        /// </summary>
        public int GetFontSize()
        {
            return fontSize;
        }

        /// <summary>
        /// returns the position for the different instances of actor
        /// </summary>
        public Point GetPosition()
        {
            return position;
        }

        /// <summary>
        /// returns the text for the different instances of actor
        /// </summary>
        public string GetText()
        {
            return text;
        }

        /// <summary>
        /// returns the velocity for the different instances of actor
        /// </summary>
        public Point GetVelocity()
        {
            return velocity;
        }
        
        /// <summary>
        /// Calculates the next position for the robot, and wraps the robot if
        /// it goes too far to one side
        /// </summary>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        public void GetNextPosition(int maxX, int maxY)
        {
            int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            position = new Point(x, y);
        }

        /// <summary>
        /// Sets the color for the instance of actor
        /// </summary>
        /// <param name="color"></param>
        public void SetColor(Color color)
        {
            this.color = color;
        }

        /// <summary>
        /// Sets the position for the instance of actor
        /// </summary>
        /// <param name="position"></param>
        public void SetPosition(Point position)
        {
            this.position = position;
        }

        /// <summary>
        /// Sets the text character for the instance of actor
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Sets the velocity for the instance of actor
        /// </summary>
        /// <param name="velocity"></param>
        public void SetVelocity(Point velocity)
        {
            this.velocity = velocity;
        }

        /// <summary>
        /// Sets the font size for the instance of actor
        /// </summary>
        /// <param name="fontSize"></param>
        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }


    }
}