using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frame.Movement;
using Frame.Enums;
using Frame.Collision;
using Frame.Core;
using Frame.Firings;

namespace Consumer
{
    public partial class Stage1 : Form
    {
        Game g;
        Random rand;
        int StoneCurrentTime, StoneFallTime;
        Point boundary;
        Point boundary1;
        GameObject PObject;
        int score;
        Label lblScore = new Label();
        
        public Stage1()
        {
            InitializeComponent();
        }
        private void updateScore()
        {
            if (g.KeyDetection() == true)
            {
                score += 10;
            }
        }
        private void Space_Load(object sender, EventArgs e)
        {
            // g = new Game(4);
            g = new Game();
            rand = new Random(); 
            boundary = new Point(this.Width, this.Height);
            boundary1 = new Point(this.Width, this.Top + 100);
            StoneCurrentTime = 0;
            StoneFallTime = 50;
            //Event Handlers
            g.onAddingGameObject += new EventHandler(addIntoControls);
            g.onAddFiring += new EventHandler(addIntoControls);
            //Adding Game Objects
            PObject = g.addGameObject(Consumer.Properties.Resources.Halicopter, 200, 120, new Keyboard(15, boundary), gameObjType.player);
            g.addGameObject(Consumer.Properties.Resources.alien1, 197, 847, new Vertical(5, boundary, "up"), gameObjType.enemy);
            g.addGameObject(Consumer.Properties.Resources.alien3, 50, 20, new Horizontal(3, boundary, "left"), gameObjType.enemy);
            g.addGameObject(Resize(Consumer.Properties.Resources.key, new Size(40,60)), rand.Next(10, 150),rand.Next(50,300), new Vertical(5, boundary, "up"), gameObjType.Key);
            Collide c = new Collide(gameObjType.player, gameObjType.enemy, new gameOver());
            g.addIntoCollisionList(c);
        }
        public static Image Resize(Image img, Size size)
        {
            return (Image)(new Bitmap(img, size));
        }
        private void addIntoControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }
        
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            StoneCurrentTime++;
            lblScore.Text = "Score: " + score.ToString();
            lblScore.BackColor = Color.White;
            lblScore.ForeColor = Color.Black;
            updateScore();
            this.Controls.Add(lblScore);
            if (StoneCurrentTime == StoneFallTime)
            {
                g.addGameObject(Consumer.Properties.Resources.alien21, rand.Next(0, this.Top - 30), rand.Next(0, this.Width - 100), new RandomEnemy(7, boundary), gameObjType.enemy);
                StoneCurrentTime = 0;
                if (g.Enemy().Pb.Visible == true)
                {
                    g.addPlayerFire(Consumer.Properties.Resources.laserRed07, g.Enemy().Pb.Top + 20, g.Enemy().Pb.Left - 30, gameObjType.enemyFire, new EnemyFire(10, boundary, gameObjType.enemyFire, "left"));
                }
                    g.onAddingGameObject += new EventHandler(addIntoControls);
            }
            
            g.update();
            g.CollisionDetection();
            g.playerFireDetection();
        }
        public void RemovePB(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            this.Controls.Remove(p);
        }
        private void Space_KeyDown(object sender, KeyEventArgs e)
        {
            g.keyPressed(e.KeyCode);
            if (e.KeyCode == Keys.Space)
            {
                g.addPlayerFire(Consumer.Properties.Resources.laserGreen13, PObject.Pb.Top + 30, PObject.Pb.Left - (PObject.Pb.Width / 2) + 90, gameObjType.playerFire, new PlayerFiring(6, boundary, "right", gameObjType.playerFire));
            }
        }
    }
}
