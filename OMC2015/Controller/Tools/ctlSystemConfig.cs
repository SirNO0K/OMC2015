using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace OMC2015.Controller.Tools
{
    public class ctlSystemConfig
    {
        IConfig _Config;

        #region Chaeck Instance

        private static ctlSystemConfig _instance;

        private ctlSystemConfig() { }

        public static ctlSystemConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctlSystemConfig();
                }
                return _instance;
            }
        }

        #endregion

        public ctlSystemConfig(IConfig Config)
        {
            _Config = Config;
            Config.SetController(this);
        }

        public void Select(string Tag)
        {
            switch (Tag)
            {
                case "PicturePath":
                    FolderBrowserDialog Browser = new FolderBrowserDialog();
                    if (Browser.ShowDialog() == DialogResult.OK)
                    {
                        _Config.PicturePath = Browser.SelectedPath;
                    }
                    break;
            
            }
        }

        public void GetInfomation()
        {
            _Config.SystemServer = Model.SysCore.Instance.SystemServer;
            _Config.SystemDatabase = Model.SysCore.Instance.SystemDatabase;
            _Config.SystemUsername = Model.SysCore.Instance.SystemUsername;
            _Config.SystemPassword = Model.SysCore.Instance.SystemPassword;

            _Config.AccuontServer = Model.SysCore.Instance.AccountServer;
            _Config.AccuontDatabase = Model.SysCore.Instance.AccountDatabase;
            _Config.AccuontUsername = Model.SysCore.Instance.AccountUsername;
            _Config.AccuontPassword = Model.SysCore.Instance.AccountPassword;

            _Config.Company = ConfigurationManager.AppSettings["CompanyName"].ToString();
            _Config.PicturePath = ConfigurationManager.AppSettings["Picture"].ToString();
        }

        public void UpdateConfig()
        {
            #region CompanyName

            Configuration ConfigCompanyName = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigCompanyName.AppSettings.Settings["CompanyName"].Value = _Config.Company;
            ConfigCompanyName.Save(ConfigurationSaveMode.Modified);

            #endregion

            #region PicturePath

            Configuration ConfigPicturePath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigCompanyName.AppSettings.Settings["Picture"].Value = _Config.PicturePath;
            ConfigCompanyName.Save(ConfigurationSaveMode.Modified);

            #endregion

            #region OLDMOON
            string _ConnectionOldmoonCenter = ConfigurationManager.ConnectionStrings["OLDMOON"].ConnectionString;
            Configuration _ConfigOldmoonCenter = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            EntityConnectionStringBuilder _OldmoonCenterEF = new EntityConnectionStringBuilder(_ConnectionOldmoonCenter);
            SqlConnectionStringBuilder _OldmoonCenterSQL = new SqlConnectionStringBuilder(_OldmoonCenterEF.ProviderConnectionString);

            _OldmoonCenterSQL.DataSource = _Config.SystemServer;
            _OldmoonCenterSQL.InitialCatalog = _Config.SystemDatabase;
            _OldmoonCenterSQL.UserID = _Config.SystemUsername;
            _OldmoonCenterSQL.Password = _Config.SystemPassword;

            _OldmoonCenterEF.ProviderConnectionString = _OldmoonCenterSQL.ConnectionString;
            _ConfigOldmoonCenter.ConnectionStrings.ConnectionStrings["OLDMOON"].ConnectionString = _OldmoonCenterEF.ConnectionString;

            _ConfigOldmoonCenter.Save(ConfigurationSaveMode.Modified);

            #endregion

            #region ERP
            string _ConnectionERP = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
            Configuration _ConfigERP = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            EntityConnectionStringBuilder _ErpEF = new EntityConnectionStringBuilder(_ConnectionERP);
            SqlConnectionStringBuilder _ErpSQL = new SqlConnectionStringBuilder(_ErpEF.ProviderConnectionString);

            _ErpSQL.DataSource = _Config.AccuontServer;
            _ErpSQL.InitialCatalog = _Config.AccuontDatabase;
            _ErpSQL.UserID = _Config.AccuontUsername;
            _ErpSQL.Password = _Config.AccuontPassword;

            _ErpEF.ProviderConnectionString = _ErpSQL.ConnectionString;
            _ConfigERP.ConnectionStrings.ConnectionStrings["ERP"].ConnectionString = _ErpEF.ConnectionString;

            _ConfigERP.Save(ConfigurationSaveMode.Modified);
            #endregion
        }

    }

    public interface IConfig
    {
        void SetController(ctlSystemConfig Controller);
        void SelectItem(object sender, EventArgs e);

        string SystemServer { get; set; }
        string SystemDatabase { get; set; }
        string SystemUsername { get; set; }
        string SystemPassword { get; set; }

        string AccuontServer { get; set; }
        string AccuontDatabase { get; set; }
        string AccuontUsername { get; set; }
        string AccuontPassword { get; set; }

        string Company { get; set; }
        string PicturePath { get; set; }
    }


}
