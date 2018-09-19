using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Developer: Yuan Chen (27044044)

// This game is called Funny Shooting Game. 

// Users just need to simply press arrow keys to move the peppa pig(Avatar) to left, right, up or down.

// Press ENTER to start or replay the game while space bar would used to shoot the banana(weapon) towards the target.

namespace Shoot_em_up_Game
{  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
        private void picTarget_Click(object sender, EventArgs e)
        {
        }
        // Target character would be moving  at the top horizontally at random 

        private void timer4Target_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(0, Width - picTarget.Width);
            picTarget.Location = new Point(x, 100);

            // OR below Target character would be moving  at the top from side to side

            //bool stopMove = false;

            //if (picTarget.Left < Width - 200 && stopMove == false)
            //{
            //    picTarget.Left += 200;
            //}
            // if(picTarget.Location.X > Width - 200)
            // or

            //if(picTarget.Left > Width)
            //{
            //    stopMove = true;
            //}
            //if(picTarget.Left > 0 && stopMove == true)
            //{
            //    picTarget.Left -= 200;
            //}
            //if (picTarget.Location.X < 200)
            //{
            //    stopMove = false;
            //}

        }   // Retrieved from  https://www.codeproject.com/Questions/460897/Random-motion-of-a-picture-box

        private void picAvatar_Click(object sender, EventArgs e)
        {
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // After pressing ENTER, instruction will invisible 

            if (e.KeyCode == Keys.Enter)
            {
                timer4Target.Enabled = true;
               
                label1.Visible = false;
            }
            // press arrows to move Avatar
            
            if (e.KeyCode == Keys.Left)
            {
                if (picAvatar.Left > 0)
                {
                    picAvatar.Image = Properties.Resources.Peppa_Pig_Left;
                    picAvatar.Left -= 30;                          
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (picAvatar.Right < Width)
                {
                    picAvatar.Left += 30;
                    picAvatar.Image = Properties.Resources.Peppa_Pigpig;

                    // OR
                   //  picAvatar.Location = new Point(picAvatar.Location.X + 30, picAvatar.Location.Y);                                       
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (picAvatar.Top > 160 + picTarget.Top)
                {
                    picAvatar.Top -= 30;                                 
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (picAvatar.Bottom < Height - 60)
                {
                    picAvatar.Top += 30;                             
                }
            }
            // press SPACE BAR to shoot
            if (e.KeyCode == Keys.Space && progressBar.Value != 0)
            {
                picWeapon.Visible = true;
                picWeapon.Top -= 30;

                if (picWeapon.Top < 0)
                {
                picWeapon.Location = new Point(picAvatar.Location.X + 30, picAvatar.Location.Y - 100);
                }
            }          
        } // Retrieved from https://www.mooict.com/c-tutorial-create-a-zombie-survival-shooting-game-in-visual-studio/

        private void picWeapon_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // When the progress bar is NOT 0 once shot
            if (picTarget.Bounds.IntersectsWith(picWeapon.Bounds) && progressBar.Value > 0)
            {
                progressBar.Value -= 25;

                picWeapon.Visible = false;

                picTarget.Visible = false;

                picShootAtT.Visible = true;

                MessageBox.Show("Good shot!");
                picShootAtT.Visible = false;
              
                picTarget.Visible = true;
            }
            // When the progress bar is 0 and game over / play again
            if ( progressBar.Value == 0)
            {
                picWeapon.Visible = false;

                picTarget.Visible = false;

                picShootAtT.Visible = true;

                timer4Target.Enabled = false;

                MessageBox.Show("YOU WON!!!GAME OVER\n\n press ENTER to play again");

                playAgain();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            picWeapon.Visible = false;
        }
        private void playAgain()
        {
            progressBar.Value = 100;

            timer4Target.Enabled = true;

            picWeapon.Visible = false;

            picTarget.Visible = true;  
        }
        private void picShootAtT_Click(object sender, EventArgs e)
        {
        }
        private void progressBar_Click(object sender, EventArgs e)
        {            
        }
    }
}
