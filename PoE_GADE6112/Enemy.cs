using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public abstract class Enemy : Character
    {
        protected Random randomNumber = new Random();

        //to check implementation
        public Enemy(int enemyXPosition, int enemyYPosition, int enemyDamage, int enemyStartingHP, int enemyMaxHP, TileType enemySymbol) :
            base(enemyXPosition, enemyYPosition, enemySymbol, enemyDamage, enemyStartingHP, enemyMaxHP)
        {
        }
        public override string ToString()
        {
            string EnemyClassName = this.GetType().Name;

            return EnemyClassName + " at [" + X + "," + Y + "] " + Damage;
        }
    }
}
