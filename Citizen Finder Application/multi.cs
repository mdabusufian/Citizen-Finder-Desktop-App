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


namespace Citizen_Finder_Application
{
    public partial class multi : Form
    {
        public multi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SUFIAN-TANZID\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue) //you can use 2 instead of usertype in that index because usertype column is in 2 index
                    {

                        MessageBox.Show("you are login as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            citizen citi = new citizen();
                            citi.Show();
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
                MessageBox.Show("error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
