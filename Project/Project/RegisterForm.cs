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
using System.Xml.Linq;
using Project;

namespace Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string name = txtFullName.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter your name.");
                txtFullName.Focus();
                return;
            }
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.");
                txtFullName.Focus();
                return;
            }

            
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
                MessageBox.Show("Password must be at least 6 characters long.");
                txtPassword.Focus();
                return;
            }

            
            string confirmPassword = txtConfirmPassword.Text;
            if (confirmPassword == "")
            {
                MessageBox.Show("Please confirm your password.");
                txtConfirmPassword.Focus();
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                txtConfirmPassword.Focus();
                return;
            }

            //
            string phone = txtPhone.Text;
            if (phone == "")
            {
                MessageBox.Show("Please enter your phone number.");
                txtPhone.Focus();
                return;
            }
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 11 digits and numbers only.");
                txtPhone.Focus();
                return;
            }

            
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                cmbRole.Focus();
                return;
            }
            string role = cmbRole.SelectedItem.ToString();

            
            DialogResult confirm = MessageBox.Show("Do you really want to register?", "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            
            try
            {
                string query = $@"INSERT INTO Users (Name, Email, Password, Phone, Role)
                          VALUES ('{name}', '{email}', '{password}', '{phone}', '{role}')";

                DataAccess da = new DataAccess();
                int result = da.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Registration successful!");

                    
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This email is already registered.");
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

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
    }
}
