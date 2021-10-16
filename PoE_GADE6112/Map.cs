using System;
using System.Collections.Generic;
using System.Text;
using static PoE_GADE6112.Tile;

namespace PoE_GADE6112
{
    public class Map
    {
        private Tile[,] tile;
        public Tile[,] Tile { get { return this.tile; } set { tile = value; } }
        private Hero hero;
        public Hero Hero { get { return this.hero; } set { hero = value; } }
        private Enemy[] enemyArr;
        public Enemy[] EnemyArr { get { return this.enemyArr; } set { enemyArr = value; } }
        private int width;
        public int Width { get { return this.width; } set { width = value; } }

        private int height;
        public int Height { get { return this.height; } set { height = value; } }
        private Random random = new Random();
        public Random Random { get { return this.random; } set { random = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfEnemies)
        {
            this.Width = this.Random.Next(minWidth, maxWidth);
            this.Height = this.Random.Next(minHeight, maxHeight);
            this.EnemyArr = new Enemy[numberOfEnemies];
            this.Tile = new Tile[this.Width, this.Height];
            //call create
            Create(TileType.HERO);
            //loop through enemies
            for (int i=0; i< numberOfEnemies; i++)
            {
                Create(TileType.ENEMY);
            }
            //call update Vision
            UpdateVision();
        }

        private Tile Create(TileType tileType)
        {
            int x = this.Random.Next(0, Width);
            int y = this.Random.Next(0, Height);

            switch (tileType)
            {
                case TileType.HERO:
                    Hero hero = new Hero(x, y, 10, 10);//is the HP 10 ok?
                    return hero;
                case TileType.ENEMY:
                    Goblin goblin = new Goblin(x, y);
                    return goblin;
                default:
                    return null;
            }            
        }

        public void UpdateVision()
        {
            int x = 0, y = 0;
            
            //get position of Hero first
            for(int i = 0; i< width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(Tile[i,j] == Hero)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            //update vision character 
            Hero.VisionArr[0] = Tile[x, y + 1];//up
            Hero.VisionArr[1] = Tile[x + 1, y];//right
            Hero.VisionArr[2] = Tile[x, y - 1];//down
            Hero.VisionArr[3] = Tile[x - 1, y];//left
        }        
    }
}
