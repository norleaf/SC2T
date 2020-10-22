using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Draw3DUtils
    {
        Model tank, sieged;
        Matrix world, view, projection;
        float rot = 0.1f;
        Vector3 camera;
        public Draw3DUtils(GraphicsDevice GraphicsDevice, ContentManager Content)
        {
            world = Matrix.CreateWorld(Vector3.Zero, Vector3.Forward, Vector3.Up);
            view = Matrix.CreateLookAt(Vector3.One, Vector3.Forward, Vector3.Up);
            projection = Matrix.CreateOrthographicOffCenter(new Rectangle(0, 0, GraphicsDevice.DisplayMode.Width, GraphicsDevice.DisplayMode.Height), 0, 1000);
            camera = new Vector3(10, 500, -1000);


            sieged = Content.Load<Model>("3D/Siegemode");
        }

        public void Draw()
        {
            //Vector3 pos1 = new Vector3(-200, 0, 0);
            Vector3 pos2 = new Vector3(300, 0, 0);

            //// Perspective view
            ////Vector3 camera = new Vector3(2000, 1200, 0);

            //// Ortho View
            

            //tank.DrawModel( rot, pos1, camera);
            sieged.DrawModel(rot, pos2, camera);

            rot += 0.01f;
        }
    }
}
