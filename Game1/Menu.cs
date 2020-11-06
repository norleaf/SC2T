using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Menu
    {
        public List<Button> Buttons { get; set; }

        public Menu(Texture2D pixel)
        {
            Buttons = new List<Button>() ;
            Buttons.Add(new Button
            {
                Text = "Start",
                Size = new Point(200, 100),
                Position = new Vector2(1920 / 2 - 100, 200),
                Action = (match) => { match.state = GameState.PlayerTurn; },
                Texture2D = pixel
            });
        }
    }
}
