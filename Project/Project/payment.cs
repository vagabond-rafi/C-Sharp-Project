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

namespace Project
{
    public partial class payment: Form
    {
        private string logemail;
        private int PaymentID;
        public payment()
        {
            InitializeComponent();
        }
        public payment(string logemail)
        {
            InitializeComponent();
            this.logemail = logemail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Close();
        }
        public void show()
        {
            //string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string q = "SELECT * FROM ProgressUpdates WHERE [UpdateText] = '100' AND FreelancerEmail = '" + logemail + "'";

            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show();

        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(logemail);
            dash.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBox2.Text = "Ready for Payment";
            textBox2.ReadOnly = true; 

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string ConnectionString1 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            string connectionString1 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";

            SqlConnection conn1 = new SqlConnection(connectionString1);
            conn1.Open();

            string query = "SELECT TOP 1 PaymentID FROM Payments ORDER BY PaymentID DESC;";
            SqlCommand cmd1 = new SqlCommand(query, conn1);

            object result = cmd1.ExecuteScalar();

            PaymentID = Convert.ToInt32(result);

            PaymentID += 1;
            textBox5.Text = PaymentID.ToString();

            conn1.Close();



            //string ConnectionString2 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            string ConnectionString2 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";

            SqlConnection conn2 = new SqlConnection(ConnectionString2);
            conn2.Open();

            string query2 = "SELECT Budget FROM Contracts WHERE ContractID = '" + textBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conn2);

            object result2 = cmd2.ExecuteScalar();

            if (result2 != null)
            {
                textBox3.Text = result2.ToString();
            }
            else
            {
                MessageBox.Show("No budget found for the given ContractID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Text = "";
            }


            conn2.Close();


           /* string ConnectionString3 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn3 = new SqlConnection(ConnectionString3);
            conn3.Open();

            string query3 = "INSERT INTO Payments (PaymentID, Amount) " +
                           "VALUES ('" + PaymentID + "', '" + textBox3.Text + "')";
            SqlCommand cmd3 = new SqlCommand(query3, conn3);

            object result3 = cmd3.ExecuteScalar();

            textBox3.Text = result3.ToString();

            conn3.Close(); 



            string connectionString4 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn4 = new SqlConnection(connectionString4);
            conn4.Open();
            string q4 = "DELETE FROM ProgressUpdates WHERE ContractID=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(q4, conn4);
            cmd.ExecuteNonQuery();
            conn4.Close();*/



        }

        
        public void delete()
        {
            string connectionString4 = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
            SqlConnection conn4 = new SqlConnection(connectionString4);
            conn4.Open();
            string q4 = "DELETE FROM ProgressUpdates WHERE ContractID=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(q4, conn4);
            cmd.ExecuteNonQuery();
            conn4.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Ready for Payment";
            textBox2.ReadOnly = true;
            try
            {


                //string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                string q = "INSERT INTO Payments (ContractID, Amount, PaidDate,Status) " +
                           "VALUES ('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "')";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                delete();
                clear();
                show();
                MessageBox.Show(" Project marked as ready for payment");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing data: " + ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
