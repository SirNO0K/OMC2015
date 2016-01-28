using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC2015.View.Tools
{
    public partial class frmErrorMessage : Form
    {
        public frmErrorMessage()
        {
            InitializeComponent();
        }

        public string Header { set { lbHead.Text = value; } }
        public string TextError { set { this.txtError.Text = value; } }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
