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
    public partial class LevelUp : Form
    {
        public LevelUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f = new Menu();
            f.Show();
        }
           
        private void btnNext_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                Level2 f = new Level2();
                f.Show();
            
        }
    }
}
