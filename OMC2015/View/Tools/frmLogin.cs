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
    public partial class frmLogin : Form ,Controller.Personnel.ILogin
    {
        #region Property

        Controller.Personnel.ctlPersonnel _Controller;
        public string MachineName { set { this.txtMachineName.Text = value; } }
        public string Username { set { this.txtUsername.Text = value; } }
        Controller.Tools.Loading ctlLoading = new Controller.Tools.Loading();

        #endregion

        public frmLogin()
        {
            InitializeComponent();
            _Controller = new Controller.Personnel.ctlPersonnel(this);            
        }        

        public void SetController(Controller.Personnel.ctlPersonnel Controller)
        {
            _Controller = Controller;            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _Controller.Getinfomation();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(string.IsNullOrEmpty(Model.SysCore.Instance.UserLogin))
            {
                Application.Exit();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            this.txtUsername.SelectAll();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.CharacterCasing = CharacterCasing.Upper;
            btnLogin.Enabled = txtUsername.Text == "ARIN" || txtUsername.Text == "SAWANGPONG" ? true : false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (txtUsername.Text == "ARIN" || txtUsername.Text == "SAWANGPONG" || txtPassword.Text.Count() >= 4 ? true : false);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == "ARIN" || txtUsername.Text == "SAWANGPONG")
                {
                    btnLogin.PerformClick();
                }
                else
                {
                    txtPassword.Focus();
                }
            } 
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            ctlLoading.Start();
            try
            {
                int UserLogin = Controller.Personnel.ctlPersonnel.Instance.GetUserLogin(this.txtUsername.Text, this.txtPassword.Text);
                if (UserLogin == 0)
                {
                    ctlLoading.Abort();
                    MessageBox.Show("ชื่อผู้ใช้งาน หรือ รหัสผ่าน ไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                }
                else if (UserLogin == 1)
                {
                    ctlLoading.Abort();
                    MessageBox.Show("คุณไม่ได้รับอณุญาติเข้าใช้งาน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                }
                else if (UserLogin == 2)
                {
                    ctlLoading.Abort();
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                using (View.Tools.frmErrorMessage ShowError = new Tools.frmErrorMessage())
                {
                    ctlLoading.Abort();
                    ShowError.Text = "Login Failed...";
                    ShowError.TextError = Ex.ToString();
                    ShowError.ShowDialog(this);
                    Application.Exit();
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            View.Tools.frmConfig Config = new frmConfig();
            Config.ShowDialog(this);
        }

    }
}
