using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project
{
    public partial class LoginForm : Form
    {

        public DataAccess Da { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            string email = txtEmail.Text;
            if (email == "")
            {
                MessageBox.Show("Please enter your email.");
                txtEmail.Focus();
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            
            string password = txtPassword.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                txtPassword.Focus();
                return;
            }

            
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                cmbRole.Focus();
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            
            try
            {
                string query = $"SELECT * FROM Users WHERE Email = '{email}' AND Password = '{password}' AND Role = '{role}'";

                
                DataTable dt =this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string userEmail = dt.Rows[0]["Email"].ToString();

                    
                    if (role == "Client")
                    {
                        ClientDashboard cd = new ClientDashboard(userEmail);
                        cd.Show();
                        this.Hide();
                    }
                    else if (role == "Freelancer")
                    {
                         dashboard fd = new dashboard(userEmail);
                         fd.Show();
                         this.Hide();
                    }
                    else if (role == "Admin")
                    {
                         AdminDashboard ad = new AdminDashboard();
                         ad.Show();
                         this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect email, password, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

       
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; 
            timerPassword.Start();                    
            btnShowPassword.Enabled = false;
            txtPassword.Focus();

        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            timerPassword.Stop();
            btnShowPassword.Enabled = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
