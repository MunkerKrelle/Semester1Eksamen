using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Semester1Projekt
{
    internal class Enemy : GameObject
    {
        protected Vector2 enemyPosition;
        protected int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Vector2 EnemyPosition
        {
            get { return enemyPosition; }
            set { enemyPosition = value; }
        }

        public Enemy() //istedet for enemyPostion, use gameobjects position
        {
            //enemyPosition.X = 50;
            //enemyPosition.Y = 50;
            Random enemyPos = new Random();
            enemyPosition.X = enemyPos.Next(1, 200);
            enemyPosition.Y = enemyPos.Next(1, 200);
            health = 10;

        }
    }
}
