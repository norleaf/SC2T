using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Starcraft2Turnbased
{
    public abstract class Tech
    {
        public UiPart uiPart { get; set; }
        public int BuildTime { get; set; }
        public int Supply { get; set; }
        public int HP { get; set; }
        public int HPMax { get; set; }
        public int Armor { get; set; }
        public double Move { get; set; }
        public int SightRange { get; set; }
        public int Minerals { get; set; }
        public int Gas { get; set; }
        public Attack Ground { get; set; }
        public Attack Air { get; set; }
        public List<Keywords> Attributes { get; set; }
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

        public Tech()
        {
            Attributes = new List<Keywords>();
        }

        public Tech(Tech prototype)
        {
            BuildTime = prototype.BuildTime;
            Supply = prototype.Supply;
            HP = prototype.HP;
            HPMax = prototype.HPMax;
            Armor = prototype.Armor;
            Move = prototype.Move;
            SightRange = prototype.SightRange;
            Minerals = prototype.Minerals;
            Gas = prototype.Gas;
            Ground = prototype.Ground;
            Air = prototype.Air;
            Attributes = prototype.Attributes;
            Height = prototype.Height;
            Width = prototype.Width;
        }

        protected Tech(int buildTime, int supply, int hP, int hPMax, int armor, double move, int sightRange, int minerals, int gas, Attack ground, Attack air, List<Keywords> attributes, int height, int width)
        {
            

            BuildTime = buildTime;
            Supply = supply;
            HP = hP;
            HPMax = hPMax;
            Armor = armor;
            Move = move;
            SightRange = sightRange;
            Minerals = minerals;
            Gas = gas;
            Ground = ground;
            Air = air;
            Attributes = attributes;
            Height = height;
            Width = width;
        }

        public void Update(DrawTools drawTools)
        {
            drawTools.Draw(uiPart);
        }

        public static List<Keywords> ListWords(params Keywords[] words)
        {
            return words.ToList();
        }

    }

    public class Attack
    {
        public double Cooldown{get;set;}
        public int Range{get;set;}
        public int Damage{get;set;}

        public Attack(double cooldown, int range, int damage)
        {
            Cooldown = cooldown;
            Range = range;
            Damage = damage;
        }
    }
}
