using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Starcraft2Turnbased;
using System;

namespace Game1
{
    public class Button 
    {
        public Vector2 Position { get; set; }
        public Point Size { get; set; }
        private Rectangle rect;
        public Rectangle Rectangle()
        {
            if (rect == null || rect.Size == Point.Zero)
            {
                rect = new Rectangle((int)Position.X, (int)Position.Y, Size.X, Size.Y);
            }
            return rect;
        }
        public char[] KeyShortcut { get; set; }
        public string Text { get; set; }
        public Texture2D Texture2D { get; set; }
        public Action<Match> Action { get; set; }
        private Vector2 center;
        public Vector2 Center()
        {
            if (center == null || center == Vector2.Zero)
            {
                center = new Vector2(Position.X + Size.X / 2, Position.Y + Size.Y / 2);
            }
            return center;
        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont defaultFont)
        {
            spriteBatch.Draw(Texture2D, Rectangle(), Color.Black);

            spriteBatch.DrawString(defaultFont, Text, Position+Vector2.One, Color.White);
                ;
        }



    }
}
