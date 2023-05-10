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
    public partial class findpolice : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public findpolice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void findpolice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGIN_INFODataSet3.POLICE_PROFILE' table. You can move, or remove it, as needed.

            //this.pOLICE_PROFILETableAdapter2.Fill(this.lOGIN_INFODataSet3.POLICE_PROFILE);

            // TODO: This line of code loads data into the 'lOGIN_INFODataSet2.POLICE_PROFILE' table. You can move, or remove it, as needed.
            //this.pOLICE_PROFILETableAdapter1.Fill(this.lOGIN_INFODataSet2.POLICE_PROFILE);
            // TODO: This line of code loads data into the 'lOGIN_INFODataSet.POLICE_PROFILE' table. You can move, or remove it, as needed.
            //this.pOLICE_PROFILETableAdapter.Fill(this.lOGIN_INFODataSet.POLICE_PROFILE);

            SqlConnection con = new SqlConnection(cs);
            string query = "select * from POLICE_PROFILE";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            signup sup = new signup();
            sup.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            citizen citi = new citizen();
            citi.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from POLICE_PROFILE where name like '"+textBox1.Text+"%' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            
        }
    }
}
