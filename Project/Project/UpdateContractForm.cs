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
    public partial class UpdateContractForm : Form
    {
        private string clientEmail;
        public DataAccess Da {  get; set; }
        public UpdateContractForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
            Da= new DataAccess();
        }

        private void UpdateContractForm_Load(object sender, EventArgs e)
        { 
        }
          
            private void btnLoad_Click(object sender, EventArgs e)
        {

            
            string idText = txtContractID.Text;

            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Please enter the Contract ID.");
                txtContractID.Focus();
                return;
            }

            int contractID;
            if (!int.TryParse(idText, out contractID))
            {
                MessageBox.Show("Contract ID must be a number.");
                txtContractID.Focus();
                return;
            }

            try
            {
                
                string query = $@"
        SELECT * FROM Contracts 
        WHERE ContractID = {contractID} AND ClientEmail = '{clientEmail}'";

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtTitle.Text = row["Title"].ToString();
                    txtBudget.Text = row["Budget"].ToString();
                    dtpDeadline.Value = Convert.ToDateTime(row["Deadline"]);
                    txtStatus.Text = row["Status"].ToString();
                    txtFreelancerEmail.Text = row["FreelancerEmail"].ToString();
                    txtPaymentStatus.Text = row["PaymentStatus"].ToString();
                }
                else
                {
                    MessageBox.Show("No contract found for this ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idText = txtContractID.Text;
            string title = txtTitle.Text;
            string budgetText = txtBudget.Text;
            DateTime deadline = dtpDeadline.Value;
            string status = txtStatus.Text;
            string freelancer = txtFreelancerEmail.Text;
            string paymentStatus = txtPaymentStatus.Text;
            string clientEmail = this.clientEmail; 

            
            if (idText == "")
            {
                MessageBox.Show("Please enter the Contract ID.");
                txtContractID.Focus();
                return;
            }

            int contractID;
            if (!int.TryParse(idText, out contractID))
            {
                MessageBox.Show("Contract ID must be a number.");
                txtContractID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title.");
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(budgetText) || !decimal.TryParse(budgetText, out decimal budget))
            {
                MessageBox.Show("Enter a valid budget.");
                txtBudget.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(freelancer) && (!freelancer.Contains("@") || !freelancer.Contains(".")))
            {
                MessageBox.Show("Freelancer email is invalid.");
                txtFreelancerEmail.Focus();
                return;
            }

            
            DialogResult confirm = MessageBox.Show(
                "Do you really want to update this contract?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string query = $@"
UPDATE Contracts 
SET 
    Title = '{title}', 
    Budget = {budget}, 
    Deadline = '{deadline:yyyy-MM-dd}', 
    Status = '{status}', 
    FreelancerEmail = '{freelancer}', 
    PaymentStatus = '{paymentStatus}' 
WHERE 
    ContractID = {contractID} AND ClientEmail = '{clientEmail}'";

                int rows = this.Da.ExecuteDMLQuery(query);

                if (rows > 0)
                {
                    MessageBox.Show("Contract updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed. Make sure the Contract ID is correct.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


