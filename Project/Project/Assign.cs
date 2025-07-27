using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class Assign: Form
    {
        private string logemail;
        public Assign(string logemail)
        {
            InitializeComponent();
            this.logemail = logemail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(logemail);
            dash.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            show();
       
    }
        private void show()
        {
            try
            {
                string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                //conn.ConnectionString = "Data Source=Marium;Initial Catalog=profile1;Integrated Security=True;";
                
               
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Contracts WHERE FreelancerEmail='"+logemail+"'";

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                conn.Close();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
