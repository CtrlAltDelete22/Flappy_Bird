using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipedown.Left -= pipespeed;
            pipeup.Left -= pipespeed;
            scoretxt.Text = "score: "+ score;
            if(pipedown.Left < -150) 
            {
                pipedown.Left = 800;
                score++;
            }
            if(pipeup.Left < -180) 
            {
                pipeup.Left = 950;
                score++;
            }
            if(FlappyBird.Bounds.IntersectsWith(pipedown.Bounds)||FlappyBird.Bounds.IntersectsWith(pipeup.Bounds)||FlappyBird.Bounds.IntersectsWith(ground.Bounds))
                {
                endGame();
            }
            if(FlappyBird.Top < -25) 
            {
                endGame();
            }
            if(score > 5) 
            {
                pipespeed = 15;
            }
        }
        private void GameKeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) 
            {
                gravity = -5;
            }
        }

        private void GameKeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame() 
        {
            gameTimer.Stop();
            scoretxt.Text += "  Game Over!!!";
        }

      
    }
}
