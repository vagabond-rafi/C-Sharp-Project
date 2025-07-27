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

namespace Project
{
    public partial class CreateContractForm : Form
    {
        string clientEmail;
        public CreateContractForm(string email)
        {
            InitializeComponent();
            clientEmail = email;
            txtClientEmail.Text = email;
            txtStatus.Text = "Pending";
            txtPaymentStatus.Text = "Unpaid";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string budgetText = txtBudget.Text;
            string freelancer = txtFreelancerEmail.Text;
            DateTime deadline = dtpDeadline.Value;
            string status = txtStatus.Text;
            string paymentStatus = txtPaymentStatus.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter the contract title.");
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(budgetText))
            {
                MessageBox.Show("Please enter a budget.");
                txtBudget.Focus();
                return;
            }

            if (!decimal.TryParse(budgetText, out decimal budget))
            {
                MessageBox.Show("Budget must be a valid number.");
                txtBudget.Focus();
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                if (!string.IsNullOrWhiteSpace(freelancer))
                {
                    string checkQuery = $"SELECT COUNT(*) FROM Users WHERE Email = '{freelancer}' AND Role = 'Freelancer'";
                    DataTable checkTable = da.ExecuteQueryTable(checkQuery);

                    if (checkTable.Rows.Count == 0 || Convert.ToInt32(checkTable.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("Freelancer email not found or not registered as a freelancer.");
                        txtFreelancerEmail.Focus();
                        return;
                    }
                }

                
                DialogResult confirm = MessageBox.Show(
                    "Do you really want to create this contract?",
                    "Confirm Contract Creation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                string query = $@"
INSERT INTO Contracts 
(Title, Budget, Deadline, Status, ClientEmail, FreelancerEmail, PaymentStatus)
VALUES 
('{title}', {budget}, '{deadline:yyyy-MM-dd}', '{status}', '{clientEmail}', '{freelancer}', '{paymentStatus}')";

                int rows = da.ExecuteDMLQuery(query);

                if (rows > 0)
                {
                    MessageBox.Show("Contract created successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contract creation failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
