using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Mage : Enemy
    {
        public Mage(int x, int y): base(x,y,5,5,10,TileType.ENEMY)//find out what is the ma HP for enemy
        {

        }
        public override Movement ReturnMove(Movement move = Movement.NOMOVEMENT)
        {
            return Movement.NOMOVEMENT;
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);// not sure if correct?
        }
    }
}
