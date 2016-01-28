using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Configuration;
using System.Reflection;
using System.Data.Common;
using System.Data.Sql;
using System.Threading;
using System.Windows.Forms;


namespace OMC2015.View.Tools
{
    public partial class frmMain : Form
    {
        int i = 0;
        Thread T;

        private void CheckDataBase()
        {
            T = new Thread(new ThreadStart(SplashStart));
            T.Start();

            Test_Oldmoon();
            Test_ERP();
            GetConnectionString();

            T.Abort();

        }

        public frmMain()
        {
            CheckDataBase();
            InitializeComponent();
            using (View.Tools.frmLogin Login = new frmLogin())
            {
                Login.ShowDialog(this);
            }
        }

        public void SplashStart()
        {
            Application.Run(new View.Tools.frmLoading());
        }

        private void Test_Oldmoon()
        {
            var DB = new Model.OLDMOON();
            DbConnection Conn = DB.Database.Connection;
            try
            {
                try
                {
                    Conn.Open();
                    var F = (from _F in Model.SysCore.Instance.DB_Oldmoon.LOGINs select _F).AsParallel().ToList();
                }
                catch
                {
                    T.Abort();
                    MessageBox.Show("ไม่สามารถเชื่อมต่อ ฐานข้อมูล OLDMOON ได้ กรุณาตรวจสอบ");
                }
            }
            catch
            {
                MessageBox.Show("Error Oldmoon");
            }
        }

        private void Test_ERP()
        {
            var DB = new Model.ERP();
            DbConnection Conn = DB.Database.Connection;
            try
            {
                Conn.Open();
                try
                {
                    var F = (from _F in Model.SysCore.Instance.DB_ERP.ADDRBOOKs select _F).AsParallel().ToList();
                }
                catch
                {
                    T.Abort();
                    MessageBox.Show("ไม่สามารถเชื่อมต่อ ฐานข้อมูล ERP ได้ กรุณาตรวจสอบ");
                }
            }
            catch
            {
                MessageBox.Show("Error ERP");
            }
        }

        public void GetConnectionString()
        {
            try
            {
                #region Oldmoon

                string _ConnectionOldmoon = ConfigurationManager.ConnectionStrings["OLDMOON"].ConnectionString;
                Configuration _ConfigOldmoon = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                EntityConnectionStringBuilder _OldmoonEF = new EntityConnectionStringBuilder(_ConnectionOldmoon);
                SqlConnectionStringBuilder _OldmoonSQL = new SqlConnectionStringBuilder(_OldmoonEF.ProviderConnectionString);

                Model.SysCore.Instance.SystemServer = _OldmoonSQL.DataSource;
                Model.SysCore.Instance.SystemDatabase = _OldmoonSQL.InitialCatalog;
                Model.SysCore.Instance.SystemUsername = _OldmoonSQL.UserID;
                Model.SysCore.Instance.SystemPassword = _OldmoonSQL.Password;

                #endregion

                #region ERP

                string _ConnectionERP = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
                Configuration _ConfigERP = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                EntityConnectionStringBuilder _ErpEF = new EntityConnectionStringBuilder(_ConnectionERP);
                SqlConnectionStringBuilder _ErpSQL = new SqlConnectionStringBuilder(_ErpEF.ProviderConnectionString);

                Model.SysCore.Instance.AccountServer = _ErpSQL.DataSource;
                Model.SysCore.Instance.AccountDatabase = _ErpSQL.InitialCatalog;
                Model.SysCore.Instance.AccountUsername = _ErpSQL.UserID;
                Model.SysCore.Instance.AccountPassword = _ErpSQL.Password;

                #endregion
            }
            catch (Exception Ex)
            {

                using (View.Tools.frmErrorMessage Message = new frmErrorMessage())
                {
                    Message.Header = "GetConnection Error...";
                    Message.TextError = Ex.ToString();
                    Message.TopMost = true;
                    Message.ShowDialog();
                }
            }
        }
    }
}
