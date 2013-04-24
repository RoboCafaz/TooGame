using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using TooGame.MapEngine;
using System.Threading;

namespace TooGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D pixel;
        GenSettings settings;

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

            base.Initialize();
            MapType.Initialize();

            MapType type;
            MapType.MapTypes.TryGetValue("Grass", out type);
            MapGenerator.CreateMap(256, 256, type, 3, true, 50000, 50);
            Thread popupThread = new Thread(new ThreadStart(delegate()
            {
                settings = new GenSettings();
                settings.ShowDialog();
            }));
            popupThread.Start();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            pixel = Content.Load<Texture2D>("pixel");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            TileType[,] world = MapGenerator.GetMap();
            int width = world.GetLength(0);
            int height = world.GetLength(1);

            spriteBatch.Begin();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = Color.Black;
                    switch(world[i,j])
                    {
                        case TileType.GRASS:
                            color = Color.DarkGreen;
                            break;
                        case TileType.WATER:
                            color = Color.Blue;
                            break;
                        case TileType.SAND:
                            color = Color.LightCoral;
                            break;
                        case TileType.SNOW:
                            color = Color.LightCyan;
                            break;
                        case TileType.SPACE:
                        default:
                            color = Color.Black;
                            break;
                    }
                    spriteBatch.Draw(pixel, new Rectangle(i * 5, j * 5, 5, 5), color);
                }
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
