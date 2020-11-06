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
        private SpriteFont defaultFont;
        private InputController inputController;
        private Texture2D pixel;

        List<Sprite> sprites;
        Draw3DUtils Draw3D;
        Menu menu;
        Match match;
        public Game1()
        {

            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            sprites = new List<Sprite>();
           


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
            match = new Match();
            inputController = new InputController(match);
            
            
            Draw3D = new Draw3DUtils(GraphicsDevice, Content);


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
            defaultFont = Content.Load<SpriteFont>("def");
            pixel = Content.Load<Texture2D>("pixel");
            menu = new Menu(pixel);
            inputController.Buttons.AddRange(menu.Buttons);
            //Console.WriteLine(Environment.CurrentDirectory);
            //Console.WriteLine(Content.RootDirectory);

            sprites.Add(Content.Load<Texture2D>("Terran/Structures/Command_Center").ToSprite());
            

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
            if (match.state == GameState.PlayerTurn)
            {
                foreach (var sprite in sprites)
                {

                    spriteBatch.Draw(sprite.Texture2D, sprite.Slice, Color.White);
                }
            }
            if(match.state == GameState.Menu)
            {
                foreach (var button in menu.Buttons)
                {
                    button.Draw(spriteBatch, defaultFont);
                }
            }
            //spriteBatch.Draw(Correct.Tex, Correct.Pos, Color.White);
            //  spriteBatch.Draw(tankTank, Vector2.Zero, Color.White);


            //Draw3D.Draw();


            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

