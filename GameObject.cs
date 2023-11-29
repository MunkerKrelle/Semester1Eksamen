using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester1Projekt
{
    internal class GameObject
    {
        protected Vector2 position;
        protected Texture2D sprite;
        protected SpriteFont spritefont;
        protected Rectangle rectangle;



        public virtual void LoadContent(ContentManager content) 
        {

        }

        public virtual void Update(GameTime gameTime) 
        {
        
        }

        public virtual void Draw(SpriteBatch spriteBatch) 
        {

        }

        //public Rectangle GetCollisionBox()
        //{
        //    get
        //    {
        //        return new Rectangle
        //            (
        //            (int)(position.X - spriteSize.X / 2)
        //            (int)(position.Y - spriteSize.Y / 2)
        //            (int) spriteSize.X,
        //            (int) spriteSize.Y
        //            )
        //    }
        //}

        //public bool IsColliding(GameObject other)
        //{
        //    if (this == other)
        //    {
        //        return false;

        //        return CollisionBox.Intersects(other.CollisionBox);
        //    }
        //}

        public virtual void OnCollision(GameObject other)
        {

        }


    }
}
