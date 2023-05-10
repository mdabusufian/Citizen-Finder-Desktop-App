using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Citizen_Finder_Application
{
    public partial class invalidciti : Form
    {
        public invalidciti()
        {
            InitializeComponent();
        }

        private void invalidciti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet1.reglogin' table. You can move, or remove it, as needed.
            //this.regloginTableAdapter.Fill(this.cmbloginDataSet1.reglogin);

            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string query = "select name, username, phone, usertype from reglogin where usertype = 'INVALID CITIZEN'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            govt gov = new govt();
            gov.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");

            string query = "update reglogin set name=@name,username=@username,phone=@phone,usertype=@usertype where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@username", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@usertype", textBox4.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully ! ");
            }
            else
            {
                MessageBox.Show("Data not Updated ! ");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}