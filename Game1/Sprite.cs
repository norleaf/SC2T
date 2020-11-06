using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Sprite 
    {
        public Texture2D Texture2D { get; set; }
        public Vector3  Position { get; set; }
        public Rectangle Slice { get; set; }
        public Sprite(Texture2D texture2D) 
        {
            Texture2D = texture2D;
            Slice = new Rectangle(0, 0, texture2D.Width, texture2D.Height);
            Position = Vector3.Zero;
        }

       
    }

    public static class TextureExtension
    {
        public static Sprite ToSprite(this Texture2D texture2D)
        {
            return new Sprite(texture2D);
        }
    }
}
