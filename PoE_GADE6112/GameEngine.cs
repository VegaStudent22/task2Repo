using System;
using System.Collections.Generic;
using System.Text;
using static PoE_GADE6112.Character;
using static PoE_GADE6112.Tile;

namespace PoE_GADE6112
{
    public class GameEngine
    {
        private Map map;
        public Map Map { get { return this.map; } set { map = value; } }

        public GameEngine()
        {
            map = new Map(0, 10, 0, 10, 3);//to check if values are fine like this?

        }
        public bool MovePlayer(Movement move)
        {
            var isValid = false;
            //CheckRange movement against character vision array
            switch (move)
            {
                case Movement.UP:
                    isValid = Map.Hero.VisionArr[0].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.RIGHT:
                    isValid = Map.Hero.VisionArr[1].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.DOWN:
                    isValid = Map.Hero.VisionArr[2].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.LEFT:
                    isValid = Map.Hero.VisionArr[3].tileType != TileType.OBSTACLE ? true : false;
                    break;
                default:
                    break;
            }

            if (isValid)
            {
                Map.UpdateVision();
            }
            return isValid;
        }

        public override string ToString()
        {
            string grid = string.Empty;
            for (int i = 0; i < Map.Width; i++)
            {
                for (int j = 0; j < Map.Height; j++)
                {
                    grid += Map.Tile[i, j];
                }
                grid += "\n";
            }
            return grid;
        }

    }
}


    
   