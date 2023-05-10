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
    public partial class policeprofile : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        //string username;
        public policeprofile()
        {
            InitializeComponent();
        }
       /* public policeprofile(string id)
        {
            InitializeComponent();
            this.username = username;
        }*/

        private void policeprofile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOGIN_INFODataSet5.POLICE_PROFILE' table. You can move, or remove it, as needed.
            this.pOLICE_PROFILETableAdapter2.Fill(this.lOGIN_INFODataSet5.POLICE_PROFILE);
            // TODO: This line of code loads data into the 'lOGIN_INFODataSet4.POLICE_PROFILE' table. You can move, or remove it, as needed.
            this.pOLICE_PROFILETableAdapter1.Fill(this.lOGIN_INFODataSet4.POLICE_PROFILE);
            // TODO: This line of code loads data into the 'lOGIN_INFODataSet1.POLICE_PROFILE' table. You can move, or remove it, as needed.
            this.pOLICE_PROFILETableAdapter.Fill(this.lOGIN_INFODataSet1.POLICE_PROFILE);

            // SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
           
            /*SqlConnection con = new SqlConnection(cs);
            string query = "select * from POLICE_PROFILE where name = '" + username + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            //sda.Fill(data);
            dataGridView1.DataSource = data;*/

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
