using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using MyAccounts.Libraries.Security;
using Newtonsoft.Json;

namespace MyAccounts.Forms
{
    public partial class frm_SplashScreen : SplashScreen
    {
        private ResourceManager _resources = new ResourceManager(typeof(frm_Login));

        public frm_SplashScreen()
        {
            LoadConfigurations();
            InitializeComponent();
        }

        private void LoadConfigurations()
        {
            try
            {
                var fileData = File.ReadAllText(GlobalData.CONFIG_PATH);
                if (string.IsNullOrEmpty(fileData))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("LoadConfigFailed"),  Enums.MessageBoxType.Error);
                    return;
                }

                var dicData = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileData);
                if (dicData.Count == 0 || dicData.Count != 7)
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("LoadConfigFailed"),  Enums.MessageBoxType.Error);
                    return;
                }

                GlobalData.ServerName = Functions.ToString(RSASecurity.Decrypt(dicData["ServerName"]));
                GlobalData.DatabaseName = Functions.ToString(RSASecurity.Decrypt(dicData["DatabaseName"]));
                GlobalData.DatabaseUserName = Functions.ToString(RSASecurity.Decrypt(dicData["ServerUser"]));
                GlobalData.DatabasePassword = Functions.ToString(RSASecurity.Decrypt(dicData["ServerPassword"]));
                GlobalData.DatabaseProvider = Functions.ToString(RSASecurity.Decrypt(dicData["DatabaseProvider"])) == "MSSQL" ? Enums.DatabaseSystemType.MSSQL : Enums.DatabaseSystemType.NoProvider;
                GlobalData.ServerAuthentication = Functions.ToString(RSASecurity.Decrypt(dicData["Authentication"]));
                GlobalData.DefaultLanguage = Functions.ToString(RSASecurity.Decrypt(dicData["DefaultLanguage"]));
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalData.DefaultLanguage);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}