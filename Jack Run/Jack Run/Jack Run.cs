using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
namespace Jack_Run
{
    public partial class Jack_Run : Form
    {
        int PlayerSpeed = 10;
        int Score = 0;
        Random rand = new Random();
        string EnemyDirection1;
        PictureBox Enemy1;
        PictureBox Enemy2;
        PictureBox Enemy3;
        PictureBox pbPlayer;
        PictureBox bullet;
        PictureBox Ebullet;
        int PlayerHealth = 3;
        int PbulletSpeed = 40;
        int EbulletSpeed = 30;
        int EnemySpeed1 = 8, count;
        int ECurrentFireTime1;
        int EFireGenTime1;
        List<PictureBox> PLayerFire = new List<PictureBox>();
        List<PictureBox> EnemyFire = new List<PictureBox>();
        bool jump, KeyPick, gameOver;
        bool right = true, left;
        int jumpSpeed = 10;
        int force = 8;
        
        public Jack_Run()
        {
            InitializeComponent();
        }
        private void Jack_Run_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }
        private void Jack_Run_KeyUp(object sender, KeyEventArgs e)
        {
            if (jump == true)
            {
                jump = false;
            }
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (PlayerHealth <= 0)
            {
                gameOver = true;
                GameLoop.Stop();
                this.Hide();
                GameOver g = new GameOver();
                g.Show();
            }
            lblScore.Text = "Score: " + Score;
            if (!(pbPlayer.Top + jumpSpeed <= 0))
            {
                pbPlayer.Top += jumpSpeed;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow) && pbPlayer.Left + (pbPlayer.Width + 40) < this.Width)
            {
                pbPlayer.Left = pbPlayer.Left + PlayerSpeed;
                pbPlayer.Image = Properties.Resources.Run__005;
                right = true;
                left = false;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow) && pbPlayer.Left > 60)
            {
                pbPlayer.Left = pbPlayer.Left - PlayerSpeed;
                pbPlayer.Image = Properties.Resources.left;
                left = true;
                right = false;
            }
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                this.Hide();
                Menu form = new Menu();
                form.Show();
            }
            if (Keyboard.IsKeyPressed(Key.B))
            {
                PlayerBullet();
            }

            if (jump == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if (jump == true && force < 0)
            {
                jump = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" && jump == false)
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        force = 8;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();

                }
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        Score += 1;
                    }

                }

            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        PlayerHealth -= 1;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "Pbullet" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            Score++;
                            this.Controls.Remove(j);
                            j.Visible = false;

                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();

                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "Pbullet" && x is PictureBox && (string)x.Tag == "RandomEnemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            Score++;
                            this.Controls.Remove(j);
                            j.Visible = false;
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            createEnemy3();
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "player" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            reduceLife();
                            PlayerHealth--;
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "player" && x is PictureBox && (string)x.Tag == "RandomEnemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            reduceLife();
                            PlayerHealth--;
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "player" && x is PictureBox && (string)x.Tag == "Ebullet")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            reduceLife();
                            PlayerHealth--;

                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "Pbullet" && x is PictureBox && (string)x.Tag == "platform")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(j);
                            j.Visible = false;
                        }
                    }
                    if (j is PictureBox && (string)j.Tag == "Ebullet" && x is PictureBox && (string)x.Tag == "platform")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(j);
                            j.Visible = false;
                        }
                    }
                }
            }

            if (pbPlayer.Bounds.IntersectsWith(pbKey.Bounds))
            {
                pbKey.Visible = false;
                KeyPick = true;
            }
            if (pbPlayer.Bounds.IntersectsWith(pbDoorOpen.Bounds) && KeyPick == true)
            {
                GameLoop.Stop();
                this.Hide();
                LevelUp l = new LevelUp();
                l.ShowDialog();
            }
            MoveEnemy1();
            MoveEnemy2();
            MovePbullet();
            ECurrentFireTime1++;
            if (ECurrentFireTime1 == EFireGenTime1)
            {
                GenEnemyBullet();
                ECurrentFireTime1 = 0;
            }
            MoveEbullet();
            //RemovePbullet();
        }
        private void reduceLife()
        {
            count++;
            if(count == 1)
            {
                life3.Visible = false;
            }
            if (count == 2)
            {
                life2.Visible = false;
            }
            if (count == 3)
            {
                life3.Visible = false;
            }
        }
        private void GenEnemyBullet()
        {
            Ebullet = new PictureBox();
            Ebullet.BackColor = Color.Maroon;
            Ebullet.Height = 5;
            Ebullet.Width = 10;
            Ebullet.Tag = "Ebullet";
            Ebullet.Left = Enemy3.Left - Enemy3.Width;
            Ebullet.Top = Enemy3.Top + (Enemy3.Height / 2);
            EnemyFire.Add(Ebullet);
            this.Controls.Add(Ebullet);
        }
        private void MoveEbullet()
        {
            foreach (PictureBox bullet in EnemyFire)
            {
                bullet.Left -= EbulletSpeed;
                if (bullet.Right <= 0)
                {
                    this.Controls.Remove(bullet);
                }
            }
        }
        private void MovePbullet()
        {
            foreach (PictureBox bullet in PLayerFire)
            {
                if (right)
                {
                    bullet.Left += PbulletSpeed;
                }
                if (left)
                {
                    bullet.Left -= PbulletSpeed;

                }
                if (bullet.Left >= 990 || bullet.Left <= 5)
                {
                    this.Controls.Remove(bullet);
                    bullet.Dispose();
                }
            }
        }
        private void MoveEnemy2()
        {
            if (Enemy2.Left <= 310)
            {
                EnemyDirection1 = "Right";
            }
            if (Enemy2.Left >= 375)
            {
                EnemyDirection1 = "Left";
            }
            if (EnemyDirection1 == "Left")
            {
                Enemy2.Left = Enemy2.Left - EnemySpeed1;
                Enemy2.Image = Properties.Resources.alien1;

            }
            if (EnemyDirection1 == "Right")
            {
                Enemy2.Left = Enemy2.Left + EnemySpeed1;
                Image img = Properties.Resources.rightAlien;
                Enemy2.Image = img;
                Enemy2.BackColor = Color.Transparent;

            }
        }
        private void MoveEnemy1()
        {
            if (Enemy1.Left <= 298)
            {
                EnemyDirection1 = "Right";
            }
            if (Enemy1.Left >= 372)
            {
                EnemyDirection1 = "Left";
            }
            if (EnemyDirection1 == "Left")
            {
                Enemy1.Left = Enemy1.Left - EnemySpeed1;
                Enemy1.Image = Properties.Resources.alien1;

            }
            if (EnemyDirection1 == "Right")
            {
                Enemy1.Left = Enemy1.Left + EnemySpeed1;
                Image img = Properties.Resources.rightAlien;
                Enemy1.Image = img;
                Enemy1.BackColor = Color.Transparent;

            }
        }

        private void PlayerBullet()
        {
            bullet = new PictureBox();
            Image img = Properties.Resources.bullet2;
            bullet.Image = img;
            bullet.BackColor = Color.Transparent;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Height = img.Height;
            bullet.Width = img.Width;
            bullet.Tag = "Pbullet";
            bullet.Left = pbPlayer.Left + pbPlayer.Width;
            bullet.Top = pbPlayer.Top + (pbPlayer.Height / 2);
            PLayerFire.Add(bullet);
            this.Controls.Add(bullet);
        }

        private void Jack_Run_Load(object sender, EventArgs e)
        {
            EnemySpeed1 = 4;
            createEnemy();
            createPlayer();
            createEnemy2();
            createEnemy3();
            Random random = new Random();
            ECurrentFireTime1 = 0;
            EFireGenTime1 = 20;
        }
        private void createEnemy()
        {
            Enemy1 = new PictureBox();
            Image img = Properties.Resources.alien12;
            Enemy1.Image = img;
            Enemy1.Tag = "enemy";
            Enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy1.Height = img.Height - 30;
            Enemy1.Width = img.Width - 30;
            Enemy1.BackColor = Color.Transparent;
            Enemy1.Left = (this.Width / 2) - 165;
            Enemy1.Top = this.Height - 300;
            this.Controls.Add(Enemy1);
            EnemyDirection1 = "Left";
        }
        private void createEnemy2()
        {
            Enemy2 = new PictureBox();
            Image img = Properties.Resources.alien12;
            Enemy2.Image = img;
            Enemy2.Tag = "enemy";
            Enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy2.Height = img.Height - 30;
            Enemy2.Width = img.Width - 30;
            Enemy2.BackColor = Color.Transparent;
            Enemy2.Left = 366;
            Enemy2.Top = 31;
            this.Controls.Add(Enemy2);
            EnemyDirection1 = "Left";
        }
        private void createEnemy3()
        {
            Enemy3 = new PictureBox();
            Image img = Properties.Resources.skeleton_animation_00;
            Enemy3.Image = img;
            Enemy3.Tag = "RandomEnemy";
            Enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy3.Height = img.Height - 510;
            Enemy3.Width = img.Width - 350;
            Enemy3.BackColor = Color.Transparent;

            Enemy3.Left = rand.Next(785, 970);
            Enemy3.Top = rand.Next(313, 385);
            this.Controls.Add(Enemy3);
        }
        private void createPlayer()
        {
            pbPlayer = new PictureBox();
            Image img = Properties.Resources.Run__004;
            pbPlayer.Image = img;
            pbPlayer.Tag = "player";
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer.Height = img.Height - 430;
            pbPlayer.Width = img.Width - 360;
            pbPlayer.BackColor = Color.Transparent;
            pbPlayer.Left = (this.Width / 2) - 470;
            pbPlayer.Top = this.Height - 300;
            this.Controls.Add(pbPlayer);
        }
    }
}

