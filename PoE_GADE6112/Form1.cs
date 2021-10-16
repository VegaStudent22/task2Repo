using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PoE_GADE6112.Character;

namespace PoE_GADE6112
{
    public partial class Form1 : Form
    {
        private const int V = 0;
        private const int V1 = 0;
        private Random random = new Random();
        public Random Random { get { return this.random; } set { random = value; } }
        Map _map = new Map(0, 20, 0, 20, 4);
        Hero hero;
        public Form1()
        {
            InitializeComponent();
            hero = new Hero((_map.Width / 2), (_map.Height / 2), 10, 10);
            _map.Hero = hero;
        }



        public void create_Goblin(int goblinNumber)
        {

            for (int i = 0; i < goblinNumber; i++)
            {
                int randomX = this.random.Next(0, _map.Width);
                int randomY = this.random.Next(0, _map.Height);
                new Goblin(randomX, randomY);
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            hero.ReturnMove(Movement.UP);//moves hero up
        }

        private void Down_Click(object sender, EventArgs e)
        {
            hero.ReturnMove(Movement.DOWN);//moves hero right
        }

        private void Left_Click(object sender, EventArgs e)
        {
            hero.ReturnMove(Movement.LEFT);//moves hero left
        }

        private void Right_Click(object sender, EventArgs e)
        {
            hero.ReturnMove(Movement.RIGHT);//moves hero right
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            string ShowMap = richTextBox1.Text;

        }

        public override string ToString()
        {
            int j = hero.heroXPosition;
            int k = hero.heroYPosition; 

            //updates the map where the hero will show
            string grid = string.Empty;
            for (int j = 0; j < _map.Width; j++)
            {
                for (int k = 0; k < _map.Height; k++)
                {
                    grid += _map.Tile[j, k];
                }
                grid += "\n";
            }
            return grid;
        }

        public void UpdateVision()
        {
            int x = 0, y = 0;

            //get position of Hero first
            for (int i = 0; i < _map.Width; i++)
            {
                for (int j = 0; j < _map.Height; j++)
                {
                    if (_map.Tile.X == hero.heroXPosition && _map.Tile.Y == hero.heroYPosition)
                    {
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

                //update vision character 
                hero.VisionArr[0] = Tile[x, y + 1];//up
                hero.VisionArr[1] = Tile[x + 1, y];//right
                hero.VisionArr[2] = Tile[x, y - 1];//down
                hero.VisionArr[3] = Tile[x - 1, y];//left

            }
        }
    }
}



