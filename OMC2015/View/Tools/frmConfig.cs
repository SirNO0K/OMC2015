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
    public partial class frmConfig : Form ,Controller.Tools.IConfig
    {
        Controller.Tools.ctlSystemConfig _Controller;
        Controller.Tools.Loading ctlLoading = new Controller.Tools.Loading();

        public frmConfig()
        {
            InitializeComponent();
            _Controller = new Controller.Tools.ctlSystemConfig(this);
        }

        public void SetController(Controller.Tools.ctlSystemConfig Controller)
        {
            _Controller = Controller;
        }

        #region Property

        public string SystemServer
        {
            get { return txtSystemServer.Text; }
            set { this.txtSystemServer.Text = value; }
        }
        public string SystemDatabase
        {
            get { return this.txtSystemDatabase.Text; }
            set { this.txtSystemDatabase.Text = value; }
        }
        public string SystemUsername
        {
            get { return this.txtSystemUsername.Text; }
            set { this.txtSystemUsername.Text = value; }
        }
        public string SystemPassword
        {
            get { return this.txtSystemPassword.Text; }
            set { this.txtSystemPassword.Text = value; }
        }

        public string AccuontServer
        {
            get { return txtAccuontServer.Text; }
            set { this.txtAccuontServer.Text = value; }
        }
        public string AccuontDatabase
        {
            get { return this.txtAccuontDatabase.Text; }
            set { this.txtAccuontDatabase.Text = value; }
        }
        public string AccuontUsername
        {
            get { return this.txtAccuontUsername.Text; }
            set { this.txtAccuontUsername.Text = value; }
        }
        public string AccuontPassword
        {
            get { return this.txtAccuontPassword.Text; }
            set { this.txtAccuontPassword.Text = value; }
        }

        public string Company
        {
            get { return this.txtCompanyName.Text; }
            set { this.txtCompanyName.Text = value; }
        }
        public string PicturePath
        {
            get { return this.txtPicturePath.Text; }
            set { this.txtPicturePath.Text = value; }
        }

        #endregion

        public void SelectItem(object sender, EventArgs e)
        {
            _Controller.Select(((Button)sender).Tag.ToString());
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            _Controller.GetInfomation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctlLoading.Start();
            try
            {
                _Controller.UpdateConfig();
                ctlLoading.Abort();
                MessageBox.Show("Update Configuration Success");
                Application.Restart();
            }
            catch (Exception Ex)
            {
                using (Tools.frmErrorMessage Message = new frmErrorMessage())
                {
                    ctlLoading.Abort();
                    Message.Text = "Update Configuration Fail...";
                    Message.TextError = Ex.ToString();
                    Message.ShowDialog();
                }
            }

        }

    }
}
