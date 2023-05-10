using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Citizen_Finder_Application
{
    public partial class registar : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public static string name;
        public static string email;
        public static string phone;
        public static string password;

        public registar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(cs);



            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string query = "insert into reglogin values(@name,@username,@phone,@usertype,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@username", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@usertype", comboBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox4.Text);



            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Registration Successfully ! ");
                regi_info r = new regi_info();
                r.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Registration Data not Inserted ! ");
                MessageBox.Show("Fill The TextBox First");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox4.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox4.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
