using GalaxyForceGame.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace GalaxyForceGame.States
{
    public class InfoState : State
    {
        private SpriteFont infoTextFont;

        private List<Component> components;
        public InfoState(Game1 game, GraphicsDevice graphicsDevice, ContentManager contentManager) : base(game, graphicsDevice, contentManager)
        {
            Game.IsMouseVisible = true;
        }

        public override void LoadContent()
        {
            infoTextFont = ContentManager.Load<SpriteFont>("MinecraftFont");

            var buttonTexture = ContentManager.Load<Texture2D>("button");

            var buttonFont = ContentManager.Load<SpriteFont>("MinecraftFont");

            var menuButton = new Buttons(buttonTexture, buttonFont, Color.Black)
            {
                Position = new Vector2(Game1.ScreenWidth / 2 - buttonTexture.Width / 2, 
                5 * Game1.ScreenHeight / 6),
                Text = "Go back",
            };

            components = new List<Component> { menuButton };

            menuButton.Click += MenuButton_Click;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Game.ChangeState(new MenuState(Game, GraphicDevice, ContentManager));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(infoTextFont, "W A S D - movement",new Vector2(100,100),Color.White);
            spriteBatch.DrawString(infoTextFont, "Q - use shield", new Vector2(100, 200), Color.White);
            spriteBatch.DrawString(infoTextFont, "E - use ultimate", new Vector2(100, 300), Color.White);
            spriteBatch.DrawString(infoTextFont, "Space - shoot", new Vector2(100, 400), Color.White);

            foreach (var component in components)
            {
                component.Draw(gameTime, spriteBatch);
            }

            spriteBatch.End();
        }        

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in components)
            {
                component.Update(gameTime);
            }
        }
    }
}
