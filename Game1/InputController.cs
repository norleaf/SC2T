using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;


namespace Game1
{
    public class InputController
    {

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
        }
    }
}
