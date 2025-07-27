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
    public partial class DeleteContractForm : Form
    {
        private string clientEmail;
        public DeleteContractForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idText = txtContractID.Text;

            
            if (idText == "")
            {
                MessageBox.Show("Please enter the Contract ID.");
                txtContractID.Focus();
                return;
            }

            
            if (!int.TryParse(idText, out int contractID))
            {
                MessageBox.Show("Contract ID must be a number.");
                txtContractID.Focus();
                return;
            }

            
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this contract?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
            {
                return; 
            }

            try
            {
                string query = $"DELETE FROM Contracts WHERE ContractID = {contractID} AND ClientEmail = '{clientEmail}'";

                DataAccess da = new DataAccess();
                int rows = da.ExecuteDMLQuery(query);

                if (rows > 0)
                {
                    MessageBox.Show("Contract deleted successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No contract found with this ID.");
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

