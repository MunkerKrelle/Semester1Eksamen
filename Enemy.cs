using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester1Projekt
{
    internal class Enemy : GameObject
    {
        private int enemyHealth;
        private int enemyDamage;
        private Vector2 enemyPosition;
        private Vector2 checkpointTarget;
        private int enemyMovementSpeed;
        private Texture2D enemySprite;
        private Vector2 direction;
        private Texture2D[] enemySprites;
        protected float fps;
        private float timeElapsed;
        private int currentIndex;
        private Nexus myNexus;
        private Enemy myEnemy;


        //public static List<Enemy> enemies = new List<Enemy>();

        public int EnemyHealth
        {
            get { return enemyHealth; }
            set { enemyHealth = value; }
        }


        public Vector2 EnemyPosition
        {
            get { return enemyPosition; }
            set { enemyPosition = value; }
        }
        public Enemy()
        {
        }

        public Enemy(int enemyHealth, Vector2 enemyPosition, int enemyMovementSpeed, int enemyDamage, float fps)
        {
            this.enemyHealth = enemyHealth;
            this.enemyDamage = enemyDamage;
            this.enemyPosition = enemyPosition;
            this.enemyMovementSpeed = enemyMovementSpeed;
            this.fps = fps;
        }

        //public void Pathing()// Mangler parametre
        //{
        //    //Enemy poul = new Enemy(50, enemyPosition, 5, 10);
        //    //Vector2 direction = new Vector2();
        //    //direction = 
        //}

        //public void DamageNexus()// Mangler parametre
        //{

        //}


        public override void LoadContent(ContentManager content)
        {
            enemySprites = new Texture2D[8];

            for (int i = 0; i < enemySprites.Length; i++)
            {
                enemySprites[i] = content.Load<Texture2D>("GoblinRun0");
            }

            enemySprite = enemySprites[0];

            //enemySprite = content.Load<Texture2D>("GoblinRun0");

            base.LoadContent(content);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            enemyPosition = new Vector2(500, 40);

            spriteBatch.Draw(enemySprite, enemyPosition, Color.White);
        }
        public override void OnCollision(GameObject other)
        {
            //if isColliding == true;
            //Animation + remove Enemy
        }

        protected void Animate(GameTime gametime)
        {
            timeElapsed += (float)gametime.ElapsedGameTime.TotalSeconds;

            currentIndex = (int)(timeElapsed * fps);

            enemySprite = enemySprites[currentIndex];

            if (currentIndex >= enemySprites.Length - 1)
            {
                timeElapsed = 0;
                currentIndex = 0;
            }
        }
        
        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Vector2 moveDirection = myNexus.NexusPosition - myEnemy.EnemyPosition;
            moveDirection.Normalize();

            myEnemy.EnemyPosition += moveDirection * myEnemy.enemyMovementSpeed * dt;
        }
    }
}
