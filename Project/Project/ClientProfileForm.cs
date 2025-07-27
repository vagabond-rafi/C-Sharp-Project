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
using Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project
{
    public partial class ClientProfileForm : Form
    {
        string clientEmail;
        public ClientProfileForm(string email)
        {
            InitializeComponent();
            clientEmail = email;
            LoadClientData();

        }
        private void LoadClientData()
        {
            try
            {
                string query = $"SELECT * FROM Users WHERE Email = '{clientEmail}'";

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtName.Text = row["Name"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtPhone.Text = row["Phone"].ToString();
                    txtRole.Text = row["Role"].ToString();
                    txtPassword.Text = row["Password"].ToString(); 
                }

               
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtRole.ReadOnly = true;

                btnEdit.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtPassword.ReadOnly = false;

            
            txtEmail.ReadOnly = true;
            txtRole.ReadOnly = true;

            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            txtName.Focus(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name == "")
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.");
                txtName.Focus();
                return;
            }

            string phone = txtPhone.Text;
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be 11 digits.");
                txtPhone.Focus();
                return;
            }

            string password = txtPassword.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter a password.");
                txtPassword.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                txtPassword.Focus();
                return;
            }

            
            DialogResult confirm = MessageBox.Show("Do you really want to save changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return; 
            }

            try
            {
                string query = $"UPDATE Users SET Name = '{name}', Phone = '{phone}', Password = '{password}' WHERE Email = '{clientEmail}'";

                DataAccess da = new DataAccess();
                int rows = da.ExecuteDMLQuery(query);

                if (rows > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }

                
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtRole.ReadOnly = true;

                btnEdit.Visible = true;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}