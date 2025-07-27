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

namespace Project

{
    public partial class Client : Form
    {
        private string userid, role, name, password, email, phone;
        public Client()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtpass.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtrole.Text = "";
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string q = "UPDATE Users SET NAME='" + txtname.Text +
                        "', EMAIL='" + txtemail.Text +
                        "', PASSWORD='" + txtpass.Text +
                        "', Role='" + txtrole.Text +
                        "', Phone='" + txtphone.Text +
                        "' WHERE UserID=" + txtid.Text;

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Show();
            Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;Enabled=False;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "DELETE FROM Users WHERE UserID=" + txtid.Text;
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            Show();
            Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            userid = txtid.Text;
            name = txtname.Text;
            password = txtpass.Text;
            email = txtemail.Text;
            phone = txtphone.Text;
            role = txtrole.Text;

            Insert();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=ProjectDB;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Users where UserID LIKE '" + txtid.Text + "%'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void Show()
        {
            //string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=ProjectDB;Integrated Security=True;";
            string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string q = "select * from Users where Role= 'Client'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboard f1 = new AdminDashboard();
            f1.Show();
        }

        private void Insert()
        {
            string connectionString = @"Data Source=MEHEDI\SQLEXPRESS01;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string q = "INSERT INTO Users (userID, Name, Email, Password, Phone,Role) " +
                           "VALUES ( '" + userid + "','" + name + "', '" + email + "', '" + password + "', '" + phone + "', '" + role + "')";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtrole.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
