using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectTest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Config a = new Config();
            a.Show();
            a.Close();
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
      
                Cadastro cadastro = new Cadastro();
                cadastro.Visible = true;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config a = new Config();
            a.Show();
        }
    }
}
