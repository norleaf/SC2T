using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Starcraft2Turnbased;

namespace Game1
{
    public class InputController
    {
        public List<Button> Buttons { get; set; }
        private Match match;

        public InputController(Match match)
        {
            this.match = match;
            Buttons = new List<Button>();
        }

        private bool mousePressed = false;
        public void Update()
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mousePressed == false)
            {
                mousePressed = true;
                //UpdateMousePress();
            }
            else if (Mouse.GetState().LeftButton == ButtonState.Released && mousePressed == true)
            {
                mousePressed = false;
            }

            if (mousePressed)
            {
                var button = Buttons.SingleOrDefault(b => b.Rectangle().Contains(Mouse.GetState().Position));
                if(button != null)
                {
                    button.Action(match);
                }
            }
        }
    }
}
