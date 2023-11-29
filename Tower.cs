using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Semester1Projekt
{
    internal class Tower : GameObject
    {
        protected string type;
        protected int level;
        protected int price;
        protected int damage;
        protected float attackSpeed;
        protected float upgradeTime;
        protected float range;
        private float distance;
        private Enemy closestEnemy;
        private Enemy target;
        public Enemy Target
        {
            get { return target; }
            set { target = value; }
        }

        public Tower()
        {
            range = 250;
            position.X = 50;
            position.Y = 50;
        }
        public void ScanForEnemies(Enemy[] enemyWave) //set wavemanger's array of enemies here as arguement. WaveManager currentWave
        {
            foreach (Enemy enemy in enemyWave)
            {
                distance = Vector2.Distance(position, enemy.EnemyPosition);

                if (distance <= range && enemy.Health >= 0)
                {
                    closestEnemy = enemy;
                    //range = distance;
                }
                //code for resetting range to 250
                
            }
            Targeting(closestEnemy);
        }

        public void Targeting(Enemy enemyTargeted) 
        {
            target = enemyTargeted;
            distance = Vector2.Distance(position, enemyTargeted.EnemyPosition); //use new variable for distance?
            if (distance > 250 || target.Health <= 0) 
            {
                range = 250;
            }

        }

        public void ScanForEnemies2(Enemy[] enemy) //set wavemanger's array of enemies here as arguement. WaveManager currentWave
        {
            //distance = range;

            for (int i = 0; i < enemy.Length; i++) //instead of 10 for i, use enemy array .Lenght
            {
                distance = Vector2.Distance(position, enemy[i].EnemyPosition);

                if (distance <= Vector2.Distance(position, enemy[i+1].EnemyPosition))
                {
                    //closestEnemy = distance;
                    //target = enemy[i];
                }

            }
        }
    }
}
