using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMC2015.Controller.Personnel
{
    public class ctlPersonnel
    {
        #region Chaeck Instance

        private static ctlPersonnel _instance;

        private ctlPersonnel() { }

        public static ctlPersonnel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctlPersonnel();
                }
                return _instance;
            }
        }

        #endregion

        ILogin _Login;

        public ctlPersonnel(ILogin Login)
        {
            _Login = Login;
            Login.SetController(this);
        }

        public void Getinfomation()
        {
            _Login.MachineName = Environment.UserDomainName + "\\" + Environment.MachineName.ToUpper();
            _Login.Username = Environment.UserName.ToUpper();
        }

        public int GetUserLogin(string Username, string Password)
        {
            int _Session = 0;

            var _UserLogin = (from _Login in Model.SysCore.Instance.DB_Oldmoon.LOGINs
                              where _Login.uname == Username && _Login.password == Password
                              select _Login).AsParallel().FirstOrDefault();  
            if (_UserLogin == null)
            {
                _Session = 0;
            }
            else if (_UserLogin.islock == true)
            {
                _Session = 1;
            }
            else
            {
                _Session = 2;
                Model.SysCore.Instance.UserLogin = Username;
                Model.SysCore.Instance.PermissionID = (int)_UserLogin.permissionid;
                Model.SysCore.Instance.DepartmentID = string.IsNullOrEmpty(_UserLogin.DepartmentID.ToString()) ? 0 : (int)_UserLogin.DepartmentID;
                //GetPermissionName(_UserLogin.permissionid);
            }
            return _Session;
        }



    }

    public interface ILogin
    {
        void SetController(ctlPersonnel Controller);
        void btnLogin_Click(object sender , EventArgs e);

        string MachineName { set; }
        string Username { set; }
    }
}
