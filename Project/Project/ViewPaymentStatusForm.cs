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
    
    public partial class ViewPaymentStatusForm : Form
    {
        string clientEmail;
        public ViewPaymentStatusForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
            LoadPayments();
        }

        private void ViewPaymentStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadPayments()
        {
            try
            {
                string query = $@"
SELECT 
    c.ContractID, 
    c.Title, 
    p.Amount, 
    p.PaidDate, 
    p.Status 
FROM Contracts AS c
INNER JOIN Payments AS p ON c.ContractID = p.ContractID
WHERE c.ClientEmail = '{clientEmail}'";

                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(query);

                dataGridPayments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }


    }
}
