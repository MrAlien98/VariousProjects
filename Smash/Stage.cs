using GameModel;
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Smash
{
    public partial class Stage : Form
    {

        public Thread hilo;
        public Thread tPlayer1;
        public GameHandler game;

        public Stage()
        {
            //string name1 = Interaction.InputBox("What is your name, Player One?", "Write your nick name", "Example: MonsterMora");
            //string name2 = Interaction.InputBox("What is your name, Player Two?", "Write your nick name", "Example: MonsterMora");

            string name1 = "";
            string name2 = "";

            game = new GameHandler(name1, name2);

            InitializeComponent();

            imgPlayer1.Image = Image.FromFile("characters/player_1_Right_Realistic.png");
            imgPlayer2.Image = Image.FromFile("characters/player_2_Right_Realistic.png");

            imgPlayer1.Location = new System.Drawing.Point(game.getPlayer1().getPosX(), game.getPlayer1().getPosY());
            imgPlayer2.Location = new System.Drawing.Point(game.getPlayer2().getPosX(), game.getPlayer2().getPosY());

            KeyDown += (object sender, KeyEventArgs e) => movementMethod(e);
        }

        public void job1(){
            CheckForIllegalCrossThreadCalls = false;
            game.getPlayer2().setJumping(true);
            if (game.getPlayer2().isJumping())
            {
                Thread.Sleep(500);
                game.getPlayer2().jump();
                imgPlayer2.Location = new Point(game.getPlayer2().getPosX(), game.getPlayer2().getPosY());
            }
        }

        public void leftP1()
        {
            CheckForIllegalCrossThreadCalls = false;
            game.getPlayer1().move();
            imgPlayer1.Location = new System.Drawing.Point(game.getPlayer1().getPosX(), game.getPlayer1().getPosY());
        }

        public void movementMethod(KeyEventArgs e)
        {
            /*Movimiento Player2*/
            if (e.KeyValue == 37)
            {
                //Left Arrow
                game.getPlayer2().setDirection('I');
                game.getPlayer2().move();
                imgPlayer2.Location = new System.Drawing.Point(game.getPlayer2().getPosX(), game.getPlayer2().getPosY());
            }
            else if (e.KeyValue == 38)
            {
                //Up Arrow
                hilo= new Thread(job1);
                hilo.Start();
            }
            else if(e.KeyValue == 39)
            {
                //Right Arrow
                game.getPlayer2().setDirection('D');
                game.getPlayer2().move();
                imgPlayer2.Location = new System.Drawing.Point(game.getPlayer2().getPosX(), game.getPlayer2().getPosY());
            }
            /*else if (e.KeyValue == 40)
            {
                //Down Arrow
                MessageBox.Show("Flecha abajo");
            }*/
            /*Movimiento Player1*/
            else if (e.KeyValue == 87)
            {
                //W
                MessageBox.Show("Tecla W");
            }
            else if (e.KeyValue == 65)
            {
                //A
                tPlayer1 = new Thread(leftP1);
                game.getPlayer1().setDirection('I');
                tPlayer1.Start();
            }
            /*else if (e.KeyValue == 83)
            {
                //S
                MessageBox.Show("Tecla S");
            }*/
            else if (e.KeyValue ==68)
            {
                //D
                game.getPlayer1().setDirection('D');
                game.getPlayer1().move();
                imgPlayer1.Location = new System.Drawing.Point(game.getPlayer1().getPosX(), game.getPlayer1().getPosY());
            }
        }

        private void CoordinatesP2_Click(object sender, System.EventArgs e)
        {

        }
    }
}

