using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//using Sprites;
using System;
using System.IO;
using System.Text;
using Starcraft2Turnbased;

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
        
        Texture2D tankSiege, tankTank;

        Draw3DUtils Draw3D;

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

            Draw3D = new Draw3DUtils(GraphicsDevice, Content);

            new Stimpack();

          //  ClassAutomation.CreateClassesByFileNames();
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
            //  spriteBatch.Draw(tankTank, Vector2.Zero, Color.White);


            //Draw3D.Draw();


            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

