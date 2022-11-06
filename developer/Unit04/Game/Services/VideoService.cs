// /*
using System.Collections.Generic;
using Raylib_cs;
using CSE210_Greed.Game.Casting;
// dotnet restore

namespace CSE210_Greed.Game.Services
{
    /// <summary>
    /// Top Text - Bottom Text
    /// </summary>
    public class VideoService
    {
        private int cellSize = 15;
        private string caption = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        

        /// <summary>
        /// text
        /// </summary>
        public VideoService(string caption, int width, int height, int cellSize, int frameRate)
        {
            this.caption = caption;
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.frameRate = frameRate;
        }

        /// <summary>
        /// Terminates code when window is closed.
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// <Summary>
        /// text
        /// </summary>
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
        }

        /// <Summary>
        /// text
        /// </summary>
        public void DrawActor(Actor actor)
        {
            string text = actor.GetText();
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int fontSize = actor.GetFontSize();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            Raylib.DrawText(text, x, y, fontSize, color);
        }

        /// <Summary>
        /// text
        /// </summary>
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }

        /// <Summary>
        /// text
        /// </summary>
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// <Summary>
        /// text
        /// </summary>
        public int GetCellSize()
        {
            return cellSize;
        }
        
        /// <Summary>
        /// text
        /// </summary>
        public int GetHeight()
        {
            return height;
        }

        /// <Summary>
        /// text
        /// </summary>
        public int GetWidth()
        {
            return width;
        }

        /// <Summary>
        /// text
        /// </summary>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// <Summary>
        /// text
        /// </summary>
        public void OpenWindow()
        {
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        /// <Summary>
        /// text
        /// </summary>
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }
    }
}
// */