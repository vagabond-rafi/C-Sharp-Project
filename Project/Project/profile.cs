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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Project
{   
    public partial class profile: Form
    {
        private string logemail;
        public profile(string logemail)
        {
            InitializeComponent();
            this.logemail = logemail;
            txtID.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtRole.ReadOnly = true;
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
             
            string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "UPDATE Users SET NAME='" + txtName.Text +
           "', EMAIL='" + txtEmail.Text +
           "', PASSWORD='" + txtPass.Text +
           "', Phone='" + txtPhone.Text +
           "', Role='" + txtRole.Text +
           "' WHERE UserID='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            show();
           
        
    } 
        private void show()
        {
            string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Users WHERE Email='" +logemail+"'" ;
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRole.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "DELETE FROM Users WHERE UserID=" + txtID.Text;
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            show();


        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
