using jetpackGame.model;
using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace jetpackGame
{
    public partial class Form1 : Form
    {
        public static int SpecialCoordX()
        {
            Random random3 = new Random();

            int specialX;
            do
            {
                specialX = random3.Next(20, 1100);
            }
            while (((specialX > 170 && specialX < 370) || (specialX > 790 && specialX < 990)));

            return specialX;

        }
        public static int specialCoordY()
        {
            Random random4 = new Random();
            int specialY;
            do
            {
                specialY = random4.Next(30, 740);
            }
            while ((specialY > 200 && specialY < 470));

            return specialY;
        }

        Image oyuncu;
        List<string> playerMovements = new List<string>();
        internal List<string> gameImages = new List<string>();
        PLAYER player = new PLAYER();

        BULLET bullet1 = new BULLET(0, 650);
        BULLET bullet2 = new BULLET(0, 150);
        BULLET bullet3 = new BULLET(1000, 40);
        BULLET bullet4 = new BULLET(200, 680);

        FUEL fuel = new FUEL(SpecialCoordX(), specialCoordY());
        STAR star = new STAR(SpecialCoordX(), specialCoordY());

        POISON poison = new POISON(240, 300);
        POISON poison2 = new POISON(860, 300);

        int animationStep;
        int score;
        int rightDie = 13;
        int leftDie = 4;

        bool difficultyPoint = false;
        bool goLeft, goRight, goUp, goDown;
        bool invincible = false;
        bool drawStar = false;
        bool invTimer = false;
        bool starControl = false;
        bool fuelcontrol = false;

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }
        public void gameEnd()
        {
            fuelbarTimer.Stop();
            movementTimer.Stop();
            bulletTimer.Stop();
            scoreTimer.Stop();
            dieTimer.Start();
            endLabel.Visible = true;
            button1.Visible = true;
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(oyuncu, player.PLAYERX, player.PLAYERY, player.PLAYERWIDTH, player.PLAYERHEIGHT);
            g.DrawImage(poison.POISONIMAGE, poison.POISONX, poison.POISONY, poison.POISONWIDTH, poison.POISONHEIGHT);
            g.DrawImage(poison.POISONIMAGE, poison2.POISONX, poison2.POISONY, poison2.POISONWIDTH, poison2.POISONHEIGHT);

            g.DrawImage(bullet1.BULLETIMAGE, bullet1.BULLETX, bullet1.BULLETY, bullet1.BULLETWIDTH, bullet1.BULLETHEIGHT);

            if (!fuelcontrol)
            {
                g.DrawImage(fuel.FUELIMAGE, fuel.FUELX, fuel.FUELY, fuel.FUELWIDTH, fuel.FUELHEIGHT);
            }
            else if (fuelcontrol)
            {
                fuel.FUELX = SpecialCoordX();
                fuel.FUELY = specialCoordY();
                fuelcontrol = false;
            }

            if (drawStar && starControl)
            {
                g.DrawImage(star.STARIMAGE, SpecialCoordX(), specialCoordY(), 45, 45);
                star.STARX = SpecialCoordX();
                star.STARY = specialCoordY();
                drawStar = false;
                starControl = false;
            }
            //starın invincible bittikten sonra ve gereken sure gectikten sonra cizilmesini saglar.
            else if (!invincible && !invTimer)
            {
                if (!((star.STARX < poison.POISONX + 30) && (star.STARX > poison.POISONX - 30) && (star.STARY < poison.POISONY + 35) && (star.STARY > poison.POISONY - 35)))
                {
                    g.DrawImage(star.STARIMAGE, star.STARX, star.STARY, 45, 45);
                }
                else
                {
                    g.DrawImage(star.STARIMAGE, SpecialCoordX(), specialCoordY(), 45, 45);
                }
            }

            // mermimiz siniri astiginda yeniden cizer.
            if (bullet1.BULLETX > ClientSize.Width)
            {
                bullet1.BULLETX = 0;
                bullet1.BULLETY = 650;
                g.DrawImage(bullet1.BULLETIMAGE, bullet1.BULLETX, bullet1.BULLETY, bullet1.BULLETWIDTH, bullet1.BULLETHEIGHT);
            }
            //bullet2 cizimi
            if (score >= 6 && difficultyPoint == true)
            {
                g.DrawImage(bullet2.BULLETIMAGE, bullet2.BULLETX, bullet2.BULLETY, bullet2.BULLETWIDTH, bullet2.BULLETHEIGHT);
            }
            if (bullet2.BULLETX > ClientSize.Width)
            {
                bullet2.BULLETX = 0;
                bullet2.BULLETY = 150;
                g.DrawImage(bullet2.BULLETIMAGE, bullet2.BULLETX, bullet2.BULLETY, bullet2.BULLETWIDTH, bullet2.BULLETHEIGHT);
            }
            // bullet3 cizimi
            if (score >= 11 && difficultyPoint == true)
            {
                bullet3.BULLETHEIGHT = 45;
                g.DrawImage(bullet3.BULLETIMAGE, bullet3.BULLETX, bullet3.BULLETY, bullet3.BULLETWIDTH, bullet3.BULLETHEIGHT);
            }
            if (bullet3.BULLETY > ClientSize.Height)
            {
                bullet3.BULLETX = 1000;
                bullet3.BULLETY = 40;
                g.DrawImage(bullet3.BULLETIMAGE, bullet3.BULLETX, bullet3.BULLETY, bullet3.BULLETWIDTH, bullet3.BULLETHEIGHT);
            }
            //bullet4 cizimi
            if (score >= 17 && difficultyPoint == true)
            {
                bullet4.BULLETHEIGHT = 45;
                bullet4.BULLETWIDTH = 15;
                g.DrawImage(bullet4.BULLETIMAGE, bullet4.BULLETX, bullet4.BULLETY, bullet4.BULLETWIDTH, bullet4.BULLETHEIGHT);
            }
            if (bullet4.BULLETY < 0)
            {
                bullet4.BULLETX = 200;
                bullet4.BULLETY = 680;
                g.DrawImage(bullet4.BULLETIMAGE, bullet4.BULLETX, bullet4.BULLETY, bullet4.BULLETWIDTH, bullet4.BULLETHEIGHT);
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            if (goLeft && player.PLAYERX > 0)
            {
                AnimatePlayer(0, 3);
                player.PLAYERX -= player.PLAYERSPEED;
            }
            if (goRight && player.PLAYERX + player.PLAYERWIDTH < ClientSize.Width)
            {
                AnimatePlayer(9, 12);
                player.PLAYERX += player.PLAYERSPEED;
            }
            if (goUp && player.PLAYERY > 0)
            {
                player.PLAYERY -= player.PLAYERSPEED;
            }
            if (goDown && player.PLAYERY + player.PLAYERHEIGHT < 801)
            {
                player.PLAYERY += player.PLAYERSPEED;
            }

            //invicible stari alindiginda timeri baslatir
            if (!drawStar)
            {
                if ((player.PLAYERY > star.STARY - 140) && (player.PLAYERY < star.STARY + 22) && (player.PLAYERX > star.STARX - 120) && (player.PLAYERX < star.STARX))
                {
                    invincible = true;
                    invincibleTimer.Start();
                    drawStar = true;
                }
            }

            //Hitbox Algorithm while invicible == false
            if (invincible == false)
            {
                if (((player.PLAYERY > poison.POISONY - 90) && (player.PLAYERY < poison.POISONY + 140)) && (player.PLAYERX < poison.POISONX + 130) && (player.PLAYERX > poison.POISONX - 65))
                {
                    gameEnd();
                }
                if (((player.PLAYERY > poison2.POISONY - 90) && (player.PLAYERY < poison2.POISONY + 140)) && (player.PLAYERX < poison2.POISONX + 130) && (player.PLAYERX > poison2.POISONX - 65))
                {
                    gameEnd();
                }
                if ((player.PLAYERY > bullet1.BULLETY - 140) && (player.PLAYERY < bullet1.BULLETY + 10) && ((player.PLAYERX < bullet1.BULLETX - 10) && (player.PLAYERX > bullet1.BULLETX - 110)))
                {
                    gameEnd();
                }
                if (score >= 6)
                {
                    if ((player.PLAYERY > bullet2.BULLETY - 140) && (player.PLAYERY < bullet2.BULLETY + 10) && ((player.PLAYERX < bullet2.BULLETX - 10) && (player.PLAYERX > bullet2.BULLETX - 110)))
                    {
                        gameEnd();
                    }
                }
                if (score >= 11)
                {
                    if ((player.PLAYERY > bullet3.BULLETY - 140) && (player.PLAYERY < bullet3.BULLETY + 10) && ((player.PLAYERX < bullet3.BULLETX - 15) && (player.PLAYERX > bullet3.BULLETX - 110)))
                    {
                        gameEnd();
                    }
                }
                if (score >= 17)
                {
                    if (((player.PLAYERY > bullet4.BULLETY - 140) && (player.PLAYERY < bullet4.BULLETY + 10) && (player.PLAYERX < bullet4.BULLETX - 5) && (player.PLAYERX > bullet4.BULLETX - 110)))
                    {
                        gameEnd();
                    }
                }
            }

            //fuel alma algoritmasi

            if ((player.PLAYERY > fuel.FUELY - 140) && (player.PLAYERY < fuel.FUELY + 22) && (player.PLAYERX > fuel.FUELX - 120) && (player.PLAYERX < fuel.FUELX))
            {

                fuelcontrol = true;
                if (fuelbar.Value + 8 > fuelbar.Maximum)
                {
                    fuelbar.Value += fuelbar.Maximum - fuelbar.Value;
                }
                else
                {
                    fuelbar.Value += 10;
                }
            }

            // timer intervaline bagli olarak surekli olarak karakterimizin cizilmesini saglar.
            Invalidate();

            label1.Text = ($"X:{player.PLAYERX}");
            label2.Text = ($"Y:{player.PLAYERY}");

            if (invincible)
            {
                label3.Visible = true;
            }
            else if (invincible != true)
            {
                label3.Visible = false;
            }

        }

        public void SetUp()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;

            playerMovements = Directory.GetFiles("karakter", "*.png").ToList();
            oyuncu = Image.FromFile(playerMovements[4]);

            gameImages = Directory.GetFiles("gameImages", "*.png").ToList();
            BackgroundImage = Image.FromFile(gameImages[0]);
            bullet1.BULLETIMAGE = Image.FromFile(gameImages[1]);
            bullet2.BULLETIMAGE = Image.FromFile(gameImages[1]);
            bullet3.BULLETIMAGE = Image.FromFile(gameImages[2]);
            bullet4.BULLETIMAGE = Image.FromFile(gameImages[3]);
            poison.POISONIMAGE = Image.FromFile(gameImages[5]);
            star.STARIMAGE = Image.FromFile(gameImages[6]);
            //fuel
            fuel.FUELIMAGE = Image.FromFile(gameImages[4]);

            //baslangictaki yakit miktarimiz.
            fuelbar.Maximum = 200;
            fuelbar.Value = 200;

            int score = 0;
            scoreLabel.Text = ($"Score: {score}");
        }
        private void AnimatePlayer(int start, int end)
        {
            animationStep++;
            if ((animationStep > end || animationStep < start))
            {
                animationStep = start;
            }
            oyuncu = Image.FromFile(playerMovements[animationStep]);
        }
        private void fuelbarTimer_Tick(object sender, EventArgs e)
        {
            if (fuelbar.Value > 0)
            {
                fuelbar.Value -= 5;
            }
            else if (fuelbar.Value == 0)
            {
                gameEnd();
            }
        }
        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            bullet1.BULLETX += bullet1.BULLETSPEED;
            if (score >= 6)
            {
                bullet2.BULLETX += bullet2.BULLETSPEED;
            }
            if (score >= 11)
            {
                bullet3.BULLETX -= bullet3.BULLETSPEED - 2;
                bullet3.BULLETY += bullet3.BULLETSPEED;
            }
            if (score >= 17)
            {
                bullet4.BULLETY -= bullet4.BULLETSPEED;
            }
            Invalidate();
        }
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            score += 1;
            if (score == 5)
            {
                difficultyPoint = true;
            }
            if (score == 11)
            {
                difficultyPoint = true;
            }
            if (score == 17)
            {
                difficultyPoint = true;
            }
            scoreLabel.Text = ($"Score: {score}");
        }
        private void invincibleTimer_Tick(object sender, EventArgs e)
        {
            invincible = false;
            invTimer = true;
            invincibleTimer.Stop();
            star.STARX = SpecialCoordX();
            star.STARY = specialCoordY();
            drawStarTimer.Start();
        }
        private void drawStarTimer_Tick(object sender, EventArgs e)
        {
            //invincible hali gectikten sonra starın cizilmesi icin sure baslatir.
            drawStar = true;
            starControl = true;
            invTimer = false;
            drawStarTimer.Stop();
        }
        private void dieTimer_Tick(object sender, EventArgs e)
        {
            //die animation part
            if (animationStep >= 9 && animationStep <= 13 && rightDie < 17)
            {
                rightDie++;
                oyuncu = Image.FromFile(playerMovements[rightDie]);
                Invalidate();
            }
            if (animationStep >= 0 && animationStep <= 4 && leftDie < 8)
            {
                leftDie++;
                oyuncu = Image.FromFile(playerMovements[leftDie]);
                Invalidate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

