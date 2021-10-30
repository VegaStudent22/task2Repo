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
        GameEngine gameEngine;
        public Form1()
        {
            InitializeComponent();
            gameEngine = new GameEngine();
            richTextBox1.Text = gameEngine.ToString();
        }

        /*public void create_Goblin(int goblinNumber)
        {
            for (int i = 0; i < goblinNumber; i++)
            {
                int randomX = this.random.Next(0, _map.Width);
                int randomY = this.random.Next(0, _map.Height);
                new Goblin(randomX, randomY);
            }
        }*/

        private void Up_Click(object sender, EventArgs e)
        {
            gameEngine.Map.Hero.ReturnMove(Movement.UP);//moves hero up
        }

        private void Down_Click(object sender, EventArgs e)
        {
            gameEngine.Map.Hero.ReturnMove(Movement.DOWN);//moves hero right
        }

        private void Left_Click(object sender, EventArgs e)
        {
            gameEngine.Map.Hero.ReturnMove(Movement.LEFT);//moves hero left
        }

        private void Right_Click(object sender, EventArgs e)
        {
            gameEngine.Map.Hero.ReturnMove(Movement.RIGHT);//moves hero right
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = gameEngine.Map.ToString();
        }        

        private void minWidth_TextChanged(object sender, EventArgs e)
        {
            //confirm if this implementation is correct
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            gameEngine.Save();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            //gameEngine.EnemyAttacks();
            //gameEngine.Map.Hero.Attack();
        }

        private void maxWidth_TextChanged(object sender, EventArgs e)
        {
            //confirm if this implementation is correct
        }

        private void minHeight_TextChanged(object sender, EventArgs e)
        {
            //confirm if this implementation is correct
        }

        private void maxHeight_TextChanged(object sender, EventArgs e)
        {
            //confirm if this implementation is correct
        }
    }
}



