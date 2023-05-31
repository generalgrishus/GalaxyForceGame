using GalaxyForceGame.PlayerInfo;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace GalaxyForceGame
{
    public class Sprite : ICloneable    
    {
        public Texture2D Texture;

        public Vector2 Position;        

        public bool IsRemoved; 

        public float Speed;

        public float LifeDuration;

        public InputInfo InputInfo;

        //Создание коллижн модели
        public Rectangle CollisionModel
        {
            get
            {
                return new Rectangle((int)Position.X,(int)Position.Y,Texture.Width,Texture.Height);
            }
        }

        public Sprite(Texture2D texture) 
        {
            Texture = texture;
        }

        public virtual void Update(GameTime gameTime,List<Sprite> sprites) 
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch) 
        {
            //Texture,Position,Color.White
            spriteBatch.Draw(Texture,Position,null,Color.White,0f,
                new Vector2(0,0),1f,SpriteEffects.None,0.001f);
        }

        // Нужно для клонирования пуль
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
