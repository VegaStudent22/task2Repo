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
            UpdateForm();
        }

        public void UpdateForm()
        {
            richTextBox1.Text = gameEngine.ToString();
            lblHeroStat.Text = gameEngine.Map.Hero.ToString();

        }

        private void Up_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.UP);//moves hero up
            gameEngine.Map.Hero.Move(move);
            //gameEngine.Map.UpdateTile(gameEngine.Map.Hero);
            gameEngine.Map.UpdateVision();
            UpdateForm();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.DOWN);//moves hero right
            gameEngine.Map.Hero.Move(move);
            gameEngine.Map.UpdateVision();
            UpdateForm();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.LEFT);//moves hero left
            gameEngine.Map.Hero.Move(move);
            gameEngine.Map.UpdateVision();
            UpdateForm();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            var move = gameEngine.Map.Hero.ReturnMove(Movement.RIGHT);//moves hero right
            gameEngine.Map.Hero.Move(move);
            gameEngine.Map.UpdateVision();
            UpdateForm();
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



