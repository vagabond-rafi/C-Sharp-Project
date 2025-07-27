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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project
{
    public partial class UpdateProgress : Form
    {
        private string logemail;
        int value;
        private string updateid, cntractid, freeemail, update, date1;
        string date2;
        public UpdateProgress()
        {
            InitializeComponent();

        }
        public UpdateProgress(string logemail)
        {
            InitializeComponent();
            this.logemail = logemail;


        }

        private void UpdateProgress_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard(logemail);
            dash.Show();
            this.Close();
        }
        private void clear()
        {
            textBox3.Text = "";
            textBox6.Text = "";


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != logemail)
            {
                MessageBox.Show("Contract ID and Freelancer email Mismatch");
            }
            else
            {
                if (textBox6.Text != "")
                {
                    if (Int32.Parse(textBox6.Text) < 0 && progressBar1.Value == 0)
                    {
                        try
                        {
                            progressBar1.Value += Int32.Parse(textBox6.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Project not started yet");
                        }

                    }
                    else
                    {
                        try
                        {
                            progressBar1.Value += Int32.Parse(textBox6.Text);
                            string x = progressBar1.Value.ToString();
                            string y = x + "%";
                            label7.Text = y;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Project completed");
                        }
                    }

                    string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string q = "UPDATE ProgressUpdates SET [UpdateText]='" + progressBar1.Value +
               "', SubmittedOn='" + dateTimePicker1.Value.ToShortDateString() +
               "' WHERE ContractID='" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                }


                else
                    MessageBox.Show("Progressbar empty");




            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (textBox3.Text == "")
                {
                    if (e.RowIndex >= 0)
                    {

                        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string x = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        if (textBox3.Text != logemail)
                        {
                            MessageBox.Show("contract doesn't belong to the current user");
                            textBox2.Text = "";
                            textBox3.Text = "";
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            value = Convert.ToInt32(x);
                            if (value == progressBar1.Value)
                            {
                                MessageBox.Show("Value Already Selcted");
                            }
                            else
                            {
                                progressBar1.Value += value;
                                string a = progressBar1.Value.ToString();
                                string b = a + "%";
                                label7.Text = b;
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Value already selected ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
           

            
                int x;
                string connectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string q = "SELECT * FROM ProgressUpdates WHERE ContractID = @contractID";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@contractID", textBox2.Text);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);

                    DataTable dt = ds.Tables[0];


                    if (dt.Rows.Count == 0)
                    {

                        MessageBox.Show("no entry of current current Contract , Create Contract");

                    }
                    else
                    {

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                    }


                }

                clear();


            }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text != logemail)
            {
                MessageBox.Show("Contract ID and Freelancer email Mismatch");
            }
            else
            {
                try
                {
                    cntractid = textBox2.Text;
                    freeemail = textBox3.Text;
                    update = textBox6.Text;
                    date1 = dateTimePicker1.Value.ToShortDateString();

                    string ConnectionString = @"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();

                    string q = "INSERT INTO ProgressUpdates (ContractID, FreelancerEmail, [UpdateText], SubmittedOn) " +
                               "VALUES ('" + cntractid + "', '" + freeemail + "', '" + update + "', '" + date1 + "')";

                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    progressBar1.Value += Int32.Parse(update);
                    MessageBox.Show("Inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error showing data: " + ex.Message);
                }
            }


        }
    }
}
