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
        private int health;
        private int damage;
        private Vector2 enemyPosition;
        private Vector2 checkpointTarget;
        private float enemyMovementSpeed;
        
        //Get og set på health

        public Enemy(int health, Vector2 enemyPosition, float enemyMovementSpeed, int damage)
        {
            this.health = health;
            this.damage = damage;
            this.enemyPosition = enemyPosition;
            this.enemyMovementSpeed = enemyMovementSpeed;
        }

        public void Pathing()// Mangler parametre
        {

        }

        public void DamageNexus()// Mangler parametre
        {

        }
    }
}
