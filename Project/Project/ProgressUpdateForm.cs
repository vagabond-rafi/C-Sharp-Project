using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project
{
    public partial class ProgressUpdatesForm : Form
    {
        private string clientEmail; 
        private DataAccess Da { set; get; }

        public ProgressUpdatesForm(string email)
        {
            InitializeComponent();

            this.clientEmail = email;
            this.Da = new DataAccess();
        }

        
            private void btnViewUpdates_Click(object sender, EventArgs e)
        {
            string idText = txtContractID.Text;

            
            if (idText == "")
            {
                MessageBox.Show("Please enter a Contract ID.");
                txtContractID.Focus();
                return;
            }

            int contractID;
            bool isNumber = int.TryParse(idText, out contractID);

            if (!isNumber)
            {
                MessageBox.Show("Contract ID must be a number.");
                txtContractID.Focus();
                return;
            }

            try
            {
                string query = $"SELECT FreelancerEmail, [UpdateText], SubmittedOn FROM ProgressUpdates WHERE ContractID = {contractID}";

                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 0)
                {
                    txtProgress.Text = "No updates found for this contract.";
                    return;
                }

                string progressText = "";

                foreach (DataRow row in dt.Rows)
                {
                    string email = row["FreelancerEmail"].ToString();
                    string updateText = row["UpdateText"].ToString();
                    string submitted = Convert.ToDateTime(row["SubmittedOn"]).ToString("dd MMM yyyy");

                    progressText += $" {submitted} by {email}:\n";
                    progressText += updateText + "\n";
                   
                }

                txtProgress.Text = progressText;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        

    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContractID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
