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
    internal class Nexus : GameObject
    {
        private int nexusLives;
        private Vector2 nexusPosition;
        private Texture2D nexusSprite;

        //Get og set nexusLives

        public Vector2 NexusPosition
        {
            get { return nexusPosition; }
        }

        public Nexus()
        {

        }

        public void GameOver()
        {
            
        }


        public override void LoadContent(ContentManager content)
        {
            nexusSprite = content.Load<Texture2D>("Red Crystal Cluster");

            base.LoadContent(content);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(nexusSprite, nexusPosition, Color.White);
        }
    }
}
