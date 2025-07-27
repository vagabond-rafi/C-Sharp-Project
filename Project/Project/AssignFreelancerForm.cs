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
    public partial class AssignFreelancerForm : Form
    {
        string clientEmail;
        public AssignFreelancerForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string contractIdText = txtContractID.Text;
            string freelancerEmail = txtFreelancerEmail.Text;

            // 🔹 Validation checks
            if (string.IsNullOrWhiteSpace(contractIdText))
            {
                MessageBox.Show("Please enter Contract ID.");
                txtContractID.Focus();
                return;
            }

            int contractID;
            if (!int.TryParse(contractIdText, out contractID))
            {
                MessageBox.Show("Contract ID must be a valid number.");
                txtContractID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(freelancerEmail))
            {
                MessageBox.Show("Please enter Freelancer Email.");
                txtFreelancerEmail.Focus();
                return;
            }

            if (!freelancerEmail.Contains("@") || !freelancerEmail.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtFreelancerEmail.Focus();
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                // 🔸 Check if same freelancer is already assigned
                string checkQuery = $@"SELECT FreelancerEmail FROM Contracts WHERE ContractID = {contractID} AND ClientEmail = '{clientEmail}'";

                DataTable dt = da.ExecuteQueryTable(checkQuery);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No contract found for the given ID.");
                    return;
                }

                string currentFreelancer = dt.Rows[0]["FreelancerEmail"].ToString();

                if (currentFreelancer == freelancerEmail)
                {
                    MessageBox.Show("This freelancer is already assigned.");
                    return;
                }

                // 🔸 Confirm before assigning
                DialogResult confirm = MessageBox.Show(
                    "Do you really want to assign this freelancer?",
                    "Confirm Assignment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                // 🔸 Update the assignment
                string updateQuery = $@"UPDATE Contracts SET FreelancerEmail = '{freelancerEmail}' WHERE ContractID = {contractID} AND ClientEmail = '{clientEmail}'";

                int rows = da.ExecuteDMLQuery(updateQuery);

                if (rows > 0)
                {
                    MessageBox.Show("Freelancer assigned successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Assignment failed. Make sure the contract exists and belongs to you.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFreelancerEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtContractID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContractID_Click(object sender, EventArgs e)
        {

        }
    }
}
