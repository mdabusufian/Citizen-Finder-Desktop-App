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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
            
            
            /*login l = new login();
            l.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            home h = new home();
            h.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
