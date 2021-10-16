using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Hero : Character
    {
        public int heroXPosition;
        public int heroYPosition;
        public int heroHP;
        public new int maxHP;

        public Hero(int heroXPosition, int heroYPosition, int heroHP, int maxHP) : base(heroXPosition, heroYPosition, TileType.HERO, 2, heroHP, maxHP)
        {
            this.heroXPosition = heroXPosition;
            this.heroYPosition = heroYPosition;
            this.heroHP = heroHP;
            this.maxHP = maxHP;
        }

        public override Movement ReturnMove(Movement move)
        {
            //CheckRange movement against character vision array
            switch (move)
            {
                case Movement.UP:
                    return VisionArr[0].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.RIGHT:
                    return VisionArr[1].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.DOWN:
                    return VisionArr[2].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.LEFT:
                    return VisionArr[3].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                default:
                    return Movement.NOMOVEMENT;
            }
        }

        public override string ToString()
        {
            string Hero = "Player Stats:" + "\n HP" + HP + "/ " + MaxHP + "\n Damage: " + Damage + "\n [" + X + "," + Y + "]";

            return Hero;
        }
    }
}
