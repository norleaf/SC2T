﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public abstract class Visible
    {
        public UiPart uiPart { get; set; }
        public Vector3 Position { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        private Rectangle rectangle;
        public Rectangle Rectangle
        {
            get
            {
                if (rectangle == null) 
                    rectangle = new Rectangle((int)Position.X - Width / 2, (int)Position.Y - Height / 2, Width, Height);
                return rectangle;
            }
        }
        public int Left { get { return Rectangle.Left; } }
        public int Right { get { return Rectangle.Right; } }
        public int Top { get { return Rectangle.Top; } }
        public int Bottom { get { return Rectangle.Bottom; } }

        public void Update(DrawTools drawTools)
        {
            drawTools.Draw(uiPart);
        }

    }
}