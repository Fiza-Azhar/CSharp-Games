using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Jack_Run
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f = new Menu();
            f.Show();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            
        }

        private void GameOver_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
           
        }
    }
}
