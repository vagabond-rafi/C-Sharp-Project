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
    public partial class ProgressUpdatessForm : Form
    {
        private string clientEmail;
        public ProgressUpdatessForm(string clientEmail)
        {
            InitializeComponent();
            this.clientEmail = clientEmail;
        }
    }
}
