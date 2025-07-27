using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ClientDashboard : Form
    {
        private string clientEmail;
        public ClientDashboard(string email)
        {
         
            InitializeComponent();
           this.clientEmail = email;

            lblWelcome.Text = "Welcome, " + clientEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
           
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateContractForm form = new CreateContractForm(clientEmail);
            form.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewContractsForm vc = new ViewContractsForm(clientEmail);
            vc.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateContractForm form = new UpdateContractForm(clientEmail);
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteContractForm delForm = new DeleteContractForm(clientEmail);
            delForm.Show();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssignFreelancerForm afForm = new AssignFreelancerForm(clientEmail); 
            afForm.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ViewPaymentStatusForm viewPayments = new ViewPaymentStatusForm(clientEmail);
            viewPayments.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ClientProfileForm profileForm = new ClientProfileForm(clientEmail);
            profileForm.ShowDialog(); 
        }

        private void btnProgressUpdatess_Click(object sender, EventArgs e)
        {
            ProgressUpdatesForm progressForm = new ProgressUpdatesForm(clientEmail);
            progressForm.Show();
        }
    }
}
