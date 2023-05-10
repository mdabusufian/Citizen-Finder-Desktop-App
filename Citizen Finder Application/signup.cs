using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Citizen_Finder_Application
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registar r = new registar();
            r.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from reglogin where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {



                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {



                        MessageBox.Show("Login Successful", "You are login as " + dt.Rows[i][3], MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            citizen citi = new citizen(textBox1.Text);
                            citi.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            govt gov = new govt();
                            gov.Show();
                            this.Hide();
                        }
                        else
                        {
                            police pol = new police();
                            pol.Show();
                            this.Hide();
                        }
                    }



                }



            }
            else
            {
                MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
