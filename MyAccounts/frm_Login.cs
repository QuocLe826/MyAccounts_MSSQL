using DevExpress.XtraEditors;
using MyAccounts.Libraries.Constants;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using MyAccounts.Libraries.Security;
using Newtonsoft.Json;

namespace MyAccounts.Forms
{
    public partial class frm_Login : XtraForm
    {
        private UsersController _loginApi = new UsersController();
        
        public frm_Login()
        {
            InitializeComponent();
        }

        private void LoadConfigurations()
        {
            try
            {
                var fileData = File.ReadAllText(GlobalData.CONFIG_PATH);
                if (string.IsNullOrEmpty(fileData))
                {
                    WinCommons.ShowMessageDialog("Load config failed!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    return;
                }

                var dicData = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileData);
                if (dicData.Count == 0 || dicData.Count != 7)
                {
                    WinCommons.ShowMessageDialog("Load config failed!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    return;
                }

                GlobalData.ServerName = Functions.ToString(RSASecurity.Decrypt(dicData["ServerName"]));
                GlobalData.DatabaseName = Functions.ToString(RSASecurity.Decrypt(dicData["DatabaseName"]));
                GlobalData.DatabaseUserName = Functions.ToString(RSASecurity.Decrypt(dicData["ServerUser"]));
                GlobalData.DatabasePassword = Functions.ToString(RSASecurity.Decrypt(dicData["ServerPassword"]));
                GlobalData.DatabaseProvider = Functions.ToString(RSASecurity.Decrypt(dicData["DatabaseProvider"])) == "MSSQL" ? Enums.DatabaseSystemType.MSSQL : Enums.DatabaseSystemType.NoProvider;
                GlobalData.ServerAuthentication = Functions.ToString(RSASecurity.Decrypt(dicData["Authentication"]));
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Username.Text))
                {
                    WinCommons.ShowMessageDialog("Username cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Username.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    WinCommons.ShowMessageDialog("Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Password.Focus();
                    return;
                }

                WinCommons.OpenProcessing("");
                var result = _loginApi.Login(txt_Username.Text.Trim(), txt_Password.Text.Trim());
                if (!string.IsNullOrEmpty(result))
                {
                    WinCommons.ShowMessageDialog(result, MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    WinCommons.CloseProcessing();
                    return;
                }

                var dtInfo = _loginApi.GetUserInfo(txt_Username.Text.Trim());
                if (dtInfo.Rows.Count == 0)
                {
                    WinCommons.ShowMessageDialog("Login failed!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    WinCommons.CloseProcessing();
                    return;
                }
                GlobalData.UserId = Functions.ParseInteger(dtInfo.Rows[0]["UserID"]);
                GlobalData.UserLogin = Functions.ToString(dtInfo.Rows[0]["UserCode"]);
                GlobalData.FirstName = Functions.ToString(dtInfo.Rows[0]["FirstName"]);
                GlobalData.LastName = Functions.ToString(dtInfo.Rows[0]["LastName"]);

                this.Hide();
                var frm = new frm_Main();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
            WinCommons.CloseProcessing();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, null);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            var resourcesExists = File.Exists("System//Images//add.svg") && File.Exists("System//Images//edit.svg");
            var dbExists = File.Exists("System//config//initserver.bak");

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }
            if (!resourcesExists || !dbExists)
            {
                WinCommons.ShowMessageDialog("System files cannot be found!", "Error", Enums.MessageBoxType.Error);
                this.Dispose();
                Application.Exit();
                return;
            }
            LoadConfigurations();
        }
    }
}