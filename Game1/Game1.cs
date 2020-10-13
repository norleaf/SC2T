using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//using Sprites;
using System;
using System.IO;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private InputController inputController;
        Model tank;
        Matrix world, view, projection;
        float rot = 0.1f;

        public Game1()
        {

            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";


        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.HardwareModeSwitch = false;
            graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            //   graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            this.IsMouseVisible = true;
            inputController = new InputController();

            world = Matrix.CreateWorld(Vector3.Zero, Vector3.Forward, Vector3.Up);
            view = Matrix.CreateLookAt(Vector3.One, Vector3.Forward, Vector3.Up);
            projection = Matrix.CreateOrthographicOffCenter(new Rectangle(0, 0, GraphicsDevice.DisplayMode.Width, GraphicsDevice.DisplayMode.Height), 0, 1000);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Content.RootDirectory);

            tank = Content.Load<Model>("Tank");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();



            inputController.Update();



            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);
            spriteBatch.Begin();
            //spriteBatch.Draw(Target.Tex, new Rectangle((int)Target.Pos.X, (int)Target.Pos.Y, 700, 700), Color.White);
            //foreach (var sprite in choices)
            //{

            //    spriteBatch.Draw(sprite.Tex, new Rectangle((int)sprite.Pos.X, (int)sprite.Pos.Y, 250, 250), Color.White);
            //}
            //spriteBatch.Draw(Correct.Tex, Correct.Pos, Color.White);
            //spriteBatch.Draw(Wrong.Tex, Wrong.Pos, Color.White);


            //tank.Draw(Matrix.CreateTranslation(200, 100, -500), view, projection);
            //Matrix.CreateScale(2) *

            Vector3 pos = new Vector3(0, 0, 0);

            // Perspective view
            //Vector3 camera = new Vector3(2000, 1200, 0);

            // Ortho View
            Vector3 camera = new Vector3(10, 500, -1000);
            
            DrawModel(tank, rot, pos, camera);

            rot += 0.01f;


            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public void DrawModel(Model myModel, float modelRotation, Vector3 modelPosition, Vector3 cameraPosition     )
        {
            // Copy any parent transforms.
            Matrix[] transforms = new Matrix[myModel.Bones.Count];
            myModel.CopyAbsoluteBoneTransformsTo(transforms);

            // Draw the model. A model can have multiple meshes, so loop.
            foreach (ModelMesh mesh in myModel.Meshes)
            {
                // This is where the mesh orientation is set, as well 
                // as our camera and projection.
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.World = transforms[mesh.ParentBone.Index] *
                                    Matrix.CreateRotationY(modelRotation) *
                                    Matrix.CreateTranslation(modelPosition);
                    effect.View = Matrix.CreateLookAt(cameraPosition,
                                    Vector3.Zero, Vector3.Up);
                    // effect.Projection = Matrix.CreatePerspectiveFieldOfView( MathHelper.ToRadians(45.0f), 1.333f, 1.0f, 10000.0f);
                    effect.Projection = Matrix.CreateOrthographicOffCenter(-1000, 1000, -1000, 1000, -1000, 10000);
                    effect.LightingEnabled = true; // turn on the lighting subsystem.
                    effect.DirectionalLight0.DiffuseColor = new Vector3(0.5f, 0, 0); // a red light
                    effect.DirectionalLight0.Direction = new Vector3(1, 0, 0);  // coming along the x-axis
                    effect.DirectionalLight0.SpecularColor = new Vector3(0, 1, 0); // with green highlights
                }
                // Draw the mesh, using the effects set above.
                mesh.Draw();
            }
        }
    }
}

