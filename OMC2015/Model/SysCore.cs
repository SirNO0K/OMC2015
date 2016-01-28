using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMC2015.Model
{
    public class SysCore
    {

        #region Chaeck Instance

        private static SysCore _instance;

        private SysCore() { }

        public static SysCore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SysCore();
                }
                return _instance;
            }
        }

        #endregion

        public Model.OLDMOON DB_Oldmoon = new Model.OLDMOON();
        public Model.ERP DB_ERP = new Model.ERP();

        public string UserLogin = string.Empty;

        public int PermissionID = 0;
        public string PernissionName = string.Empty;

        public int DepartmentID = 0;
        public string DepartmentName = string.Empty;

        public string SystemServer = string.Empty;
        public string SystemDatabase = string.Empty;
        public string SystemUsername = string.Empty;
        public string SystemPassword = string.Empty;

        public string AccountServer = string.Empty;
        public string AccountDatabase = string.Empty;
        public string AccountUsername = string.Empty;
        public string AccountPassword = string.Empty;
    }
}
