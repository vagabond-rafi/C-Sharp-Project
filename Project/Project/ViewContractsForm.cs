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
    public partial class ViewContractsForm : Form
    {
        private string clientEmail;
        public ViewContractsForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
        }

        private void ViewContractsForm_Load(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void LoadContracts()
        {
            try
            {
                string query = "SELECT ContractID, Title, Budget, Deadline, Status, FreelancerEmail, PaymentStatus " +
                               "FROM Contracts WHERE ClientEmail = '" + clientEmail + "'";

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(query); 

                dgvContracts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contracts: " + ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
