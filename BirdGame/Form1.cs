using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 8;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeFreeTime = 0;

        System.Media.SoundPlayer die = new System.Media.SoundPlayer();
        System.Media.SoundPlayer slapsh = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Swoosh = new System.Media.SoundPlayer();
        System.Media.SoundPlayer point = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            die.SoundLocation = "die.WAV";
            slapsh.SoundLocation = "slapsh.WAV";
            Swoosh.SoundLocation = "Swoosh.WAV";
            point.SoundLocation = "point.WAV";
        }

        private void gameTimeTickEvent(object sender, EventArgs e)
        {
            birdFaidingEffect();

            lifeFreeTime += 20; 
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeDawn.Left -= pipeSpeed;
            exLife.Left -= pipeSpeed;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 650;
                gameScore++;
                point.Play();
            }
            if (pipeDawn.Left < -80)
            {
                pipeDawn.Left = 850;
                gameScore++;
                point.Play();
            }

            if(bird.Bounds.IntersectsWith(pipeBottom.Bounds) || bird.Bounds.IntersectsWith(pipeDawn.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (bird.Bounds.IntersectsWith(exLife.Bounds) && lifeCount < 3)
            {
                extralifeFunction();
              
            }

            if(exLife.Left < -10)
            {
                exLife.Left = 10000;
            }

            if(lifeCount == 1)
            {
                life1.Visible = true;
            }
            if (lifeCount == 2)
            {
                life2.Visible = true;
            }
            if (lifeCount == 3)
            {
                life3.Visible = true;
            }

            
            lblscore.Text = "Score" + gameScore;
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
                
        }

        private void KeyDawnEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void endGame()
        {
           
            if (lifeCount == 0 && lifeFreeTime > 3000)
            {
                gameTime.Stop();
                gameOverlbl.Text = "Game Over !!! \n Your score is :" + gameScore;
                gameOverlbl.Visible = true;
                die.Play();
            }
            else
            {
                switch (lifeCount)
                {
                    case 3:
                        if(lifeFreeTime > 2500)
                        {
                            life3.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            slapsh.Play();
                        }
                       
                        break;
                    case 2:
                        if (lifeFreeTime > 2500)
                        {
                            life2.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            slapsh.Play();
                        }
                        break;
                    case 1:
                        if (lifeFreeTime > 2500)
                        {
                            life1.Visible = false;
                            lifeCount--;
                            lifeFreeTime = 0;
                            slapsh.Play();
                        }
                        break;

                }

                    
            }
           
        }

        private void birdFaidingEffect()
        {
            if(bird.Visible == true && lifeCount < 2500)
            {
                bird.Visible = false;

            }
            else if(bird.Visible == false && lifeCount < 2500)

            {
                bird.Visible = true;
            }
            else
            {
                bird.Visible = true;
            }
        }

        private void extralifeFunction()
        {
           if( lifeCount < 3)
            {
                lifeCount++;
                exLife.Left = 15000;
                Swoosh.Play();
            }
            
        }
    }
}
