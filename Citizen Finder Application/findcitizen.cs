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
    public partial class findcitizen : Form
    {
        //string usertype;
        public findcitizen()
        {
            InitializeComponent();
        }

        /*public findcitizen(string username)
        {
            InitializeComponent();
            this.usertype = usertype;
        }*/

        private void findcitizen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet2.reglogin' table. You can move, or remove it, as needed.
            /*this.regloginTableAdapter.Fill(this.cmbloginDataSet2.reglogin);*/


            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string query = "select name, username, phone, usertype from reglogin where usertype = 'CITIZEN'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            police pol = new police();
            pol.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            /* SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string query = "select * from  regloin where name like '" + textBox1.Text + "%' ";
            ///////string query = "select name, username, phone, usertype from reglogin where usertype like = 'CITIZEN' '" + textBox1.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            //sda.Fill(data);
            dataGridView1.DataSource = data; */
        }
    }
}
