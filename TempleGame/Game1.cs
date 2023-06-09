﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.ComponentModel;
using System.Runtime.Versioning;

namespace TempleGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        GraphicsDevice gpu;

        Texture2D Background;
        Texture2D Gumba;

        Vector2 backgroundposition = new Vector2(0,0);
        Vector2 Gumbaposition = new Vector2(100,100);

        /*------------------------------------Variablen-----------------------------*/




        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            graphics.PreferredDepthStencilFormat = DepthFormat.None;
            graphics.PreferredBackBufferWidth = 1104;
            graphics.PreferredBackBufferHeight = 621;
            graphics.ApplyChanges();
            gpu = GraphicsDevice;
            spriteBatch = new SpriteBatch(gpu);

            //Initialisierung hier

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Background = Content.Load<Texture2D>("wallpaper");
            Gumba = Content.Load<Texture2D>("gumba");

            //Song SongExample;
            //SongExample = Content.Load<Song>("SongExample");
            //MediaPlayer.Play(SongExample);
            //MediaPlayer.IsRepeating = true;


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            /*------------------------------------------*/
            KeyboardState state = Keyboard.GetState();

            if (Gumbaposition.X == 1050)
            {
                Gumbaposition.X = 1000;

            }

            if (Gumbaposition.X == 0)
            {
                Gumbaposition.X = 10;

            }

            if (Gumbaposition.Y == 600)
            {
                Gumbaposition.Y = 500;

            }

            if (Gumbaposition.Y == 0)
            {
                Gumbaposition.Y = 10;

            }

            if (state.IsKeyDown(Keys.D))
            {

            if (state.IsKeyDown(Keys.LeftShift))
            {
                Gumbaposition.X += 15;
                

            }

                Gumbaposition.X += 10;


            }

            if (state.IsKeyDown(Keys.A))
            {
            if (state.IsKeyDown(Keys.LeftShift))
            {
                Gumbaposition.X -= 15;
                

            }
                Gumbaposition.X -= 10;

            }


            if (state.IsKeyDown(Keys.W))
            {
                            if (state.IsKeyDown(Keys.LeftShift))
            {
                Gumbaposition.Y -= 15;
                

            }
                Gumbaposition.Y -= 10;

            }

            if (state.IsKeyDown(Keys.S))
            {
                            if (state.IsKeyDown(Keys.LeftShift))
            {
                Gumbaposition.Y += 15;
                

            }
                Gumbaposition.Y += 10;

            }
            
            /*----------------------Steuerung----------------------------*/
            

            /* if (Gumbaposition.X + -10 == Gegnerposition.X + -10 && Gumbaposition.Y + -10 == Ufoposition.Y + -10)
             {
                 Song Hit;
                 Hit = Content.Load<Song>("Explode");
                 MediaPlayer.Play(Hit);
                 MediaPlayer.IsRepeating = false;
             }
            */

            /*----------------------Feindkontakt----------------------------*/




            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(Background, backgroundposition, Color.White);
            spriteBatch.Draw(Gumba, Gumbaposition,Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}