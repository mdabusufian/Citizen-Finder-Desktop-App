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
    public partial class citizen : Form
    {
        string username;
        public citizen()
        {
            InitializeComponent();
        }
        public citizen(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void citizen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            helpline helpl = new helpline();
            helpl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            citiprofile cp = new citiprofile(username);
            cp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findpolice fp = new findpolice();
            fp.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            location lo = new location();
            lo.Show();
            this.Hide();
        }
    }
}
