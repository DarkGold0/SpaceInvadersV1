using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms.VisualStyles;

namespace SpaceInvadersV1
{
    public partial class Form1 : Form
    {
        bool menu = false;
        bool goRight, goLeft, goUp, goDown;
        int playerSpeed = 12;
        int enemySpeed = 4;
        int kills = 0;
        int score = 0;
        int time = 0;
        int gameOver = -1;
        int enemyBulletTimer = 300;

        PictureBox[] enemyArray;
        bool shooting;
        bool isGameOver;

        public Form1()
        {
            InitializeComponent();
            GameSetup();
            //ClearAll();


        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            

            killsTxt.Text = "Kills: " + kills;
            scoreTxt.Text = "Score: " + score;

            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight && player.Left < 1162)
            {
                player.Left += playerSpeed;
            }
            if (goUp && player.Top > 540)
            {
                player.Top -= playerSpeed;
            }
            if (goDown && player.Top < 739)
            {
                player.Top += playerSpeed;
            }




            enemyBulletTimer -= 10;

            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                MakeBullet("enemyBullet");
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    x.Left += enemySpeed;
                    if (x.Left > 1280) //730
                    {
                        x.Top += 100;  //65
                        x.Left = -100;  //80
                    }
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver = 0;
                        GameOver(0);
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                kills += 1;
                                score += x.Top * 2;
                                if (player.Top >= 750)
                                {
                                    score += player.Top;
                                }
                                else
                                {
                                    score += Convert.ToInt32(player.Top * 0.5);
                                }
                                shooting = false;
                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20;
                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);
                        shooting = false;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemyBullet")
                {
                    x.Top += 20;

                    if (x.Top > 900)
                    {
                        this.Controls.Remove(x);
                    }
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver = 0;
                        GameOver(0);
                    }
                }
            }
            if (kills > 8)
            {
                enemySpeed = 8;
            }
            if (kills == enemyArray.Length)
            {
                gameOver = 1;
                GameOver(1);
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Enter && menu == true)
            {
                GameSetup();
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                MakeBullet("bullet");
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true && menu == false)
            {
                RemoveAll();

                if (gameOver == 0)
                {
                    GameSetup();
                }
                else if (gameOver == 1)
                {
                    Form2 Livello2 = new Form2();
                    Livello2.Show();
                    this.Hide();
                }
            }
        }

        private void MakeInvaders()
        {
            //string enemyPath = @"C:\Users\alessandro.mercandi\source\repos\DarkGold0\SpaceInvadersV1\SpaceInvadersV1\Images\enemy1.png";
            //string enemyPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "images", "enemySad.png"));
            enemyArray = new PictureBox[12];
            int left = 0;
            int top = 0;
            string enemyPath = "";

            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            Random rand4 = new Random();

            for (int i = 0; i < enemyArray.Length; i++)
            {
                int randPath = Convert.ToInt32(rand1.Next(1,4));
                switch (randPath)
                {
                    case 1:
                        enemyPath = @"..\..\..\images\enemy2_.png";
                        break;
                    case 2:
                        enemyPath = @"..\..\..\images\enemy3_.png";
                        break;
                    case 3:
                        enemyPath = @"..\..\..\images\enemy4_.png";
                        break;
                }
                int randLeft = Convert.ToInt32(rand2.Next(90, 200));
                int randSize = Convert.ToInt32(rand3.Next(70, 90));
                int randTop = Convert.ToInt32(rand4.Next(1, 4));
                switch (randTop)
                {
                    case 1:
                        top = 67;
                        break;
                    case 2:
                        top = 67 + randSize;
                        break;
                    case 3:
                        top = 67 + randSize + randSize;
                        break;
                }
                enemyArray[i] = new PictureBox();
                enemyArray[i].Size = new Size(randSize, randSize);
                enemyArray[i].Image = Image.FromFile(enemyPath);
                enemyArray[i].Top = top;
                enemyArray[i].Tag = "enemy";
                enemyArray[i].Left = left;
                enemyArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(enemyArray[i]);
                left -= randLeft;
            }
        }
        private void RandomSprite()
        {

        }

        private void GameSetup()
        {
            menu = false;
            scoreTxt.Text = "Score: 0";
            kills = 0;
            score = 0;
            isGameOver = false;
            gameOverTxt.Visible = false;
            retryTxt.Visible = false;
            winTxt.Visible = false;
            continueTxt.Visible = false;


            enemyBulletTimer = 300;
            enemySpeed = 4;
            shooting = false;

            MakeInvaders();
            gameTimer.Start();
        }

        private void GameOver(int x)
        {
            isGameOver = true;
            gameTimer.Stop();
            //scoreTxt.Text = "Score: " + score + " " + message;
            if (x == 1)
            {
                winTxt.Visible = true;
                continueTxt.Visible = true;
            }
            else
            {
                gameOverTxt.Visible = true;
                retryTxt.Visible = true;
            }
        }

        private void RemoveAll()
        {
            foreach (PictureBox i in enemyArray)
            {
                this.Controls.Remove(i);
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "enemyBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void MakeBullet(string bulletTag)
        {
            //string bulletPath = @"C:\Users\alessandro.mercandi\source\repos\DarkGold0\SpaceInvadersV1\SpaceInvadersV1\Images\bullet1.png";
            string bulletPath = @"..\..\..\images\bullet1.png";
            PictureBox bullet = new PictureBox();
            bullet.Image = Image.FromFile(bulletPath);
            bullet.Size = new Size(5, 20);
            bullet.Tag = bulletTag;
            bullet.Left = player.Left + playerSpeed / 2;

            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = player.Top - 20;
            }
            else if ((string)bullet.Tag == "enemyBullet")
            {
                bullet.Top = -100;
            }

            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void ClearAll()
        {
            kills = 0;
            score = 0;
            isGameOver = false;
            shooting = false;
            gameTimer.Stop();

            player.Visible = false;
            scoreTxt.Visible = false;
            killsTxt.Visible = false;
            pictureBox1.Visible = false;
            panel1.Visible = false;
        }

        private void labelLivello_Click(object sender, EventArgs e)
        {

        }
    }
}

//https://www.youtube.com/watch?v=mV01KuIN8PA&t=2s
//minuto 37
