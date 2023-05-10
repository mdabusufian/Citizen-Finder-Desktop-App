using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citizen_Finder_Application
{
    public partial class govt : Form
    {
        public govt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpd g = new gpd();
            g.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invalidciti invc = new invalidciti();
            invc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findcitizen fciti = new findcitizen();
            fciti.Show();
            this.Hide();
        }
    }
}
