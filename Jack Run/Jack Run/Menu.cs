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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {
             this.Hide();
            Jack_Run form = new Jack_Run();
            form.Show();
        }

        private void btnInstruct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info form = new Info();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
