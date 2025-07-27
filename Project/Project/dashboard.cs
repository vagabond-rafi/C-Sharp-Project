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
    public partial class dashboard: Form
    {
        private string logemail;
        public dashboard()
        {
            InitializeComponent();
            
        }
        public dashboard(string logemail)
        {
            InitializeComponent();
            this.logemail = logemail;
        }

        private void btnvprofile_Click(object sender, EventArgs e)
        {
            profile pro = new profile(logemail);
            pro.Show();
            this.Close();
        }

        private void btnvpassign_Click(object sender, EventArgs e)
        {
            Assign ass = new Assign(logemail);
            ass.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnprogress_Click(object sender, EventArgs e)
        {
            UpdateProgress upprogress = new UpdateProgress(logemail);
            upprogress.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment pay = new payment(logemail);
            pay.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close(); 
        }
    }
}
