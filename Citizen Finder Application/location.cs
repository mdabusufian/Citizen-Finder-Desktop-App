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
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            citizen citi = new citizen();
            citi.Show();
            this.Hide();
        }

        private void location_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
