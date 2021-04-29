using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using MyAccounts.Libraries.Security;
using Newtonsoft.Json;

namespace MyAccounts.Forms
{
    public partial class frm_SystemInitialization : XtraForm
    {
        #region Constructor
        public frm_SystemInitialization()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void frm_SystemInitialization_Load(object sender, EventArgs e)
        {
            lk_Authentication.Properties.DataSource = new Dictionary<string,string>()
            {
                {"WinAuth", "Windows Authentication" },
                {"ServerAuth", "Server Authentication" }
            };
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ServerName.Text))
                {
                    WinCommons.ShowMessageDialog("Server Name cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_ServerName.Focus();
                    return;
                }
                if (lk_Authentication.ItemIndex == -1)
                {
                    WinCommons.ShowMessageDialog("Please choose Authentication!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    lk_Authentication.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerUser.Text))
                {
                    WinCommons.ShowMessageDialog("Server Username cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_ServerUser.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerPassword.Text))
                {
                    WinCommons.ShowMessageDialog("Server Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_ServerPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_FirstName.Text))
                {
                    WinCommons.ShowMessageDialog("First Name cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_FirstName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_LastName.Text))
                {
                    WinCommons.ShowMessageDialog("Last Name cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_LastName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_UserLogin.Text))
                {
                    WinCommons.ShowMessageDialog("User login cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_UserLogin.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    WinCommons.ShowMessageDialog("Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Password.Focus();
                    return;
                }


                var serverConnected = lk_Authentication.ItemIndex == 0
                        ? WinCommons.CheckConnection(txt_ServerName.Text, "master")
                        : WinCommons.CheckConnection(txt_ServerName.Text, txt_ServerUser.Text, txt_ServerPassword.Text, "master");
                if (!serverConnected)
                {
                    WinCommons.ShowMessageDialog("Connect to Server failed!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    return;
                }

                WinCommons.OpenProcessing("Initialize System...");
                var dicData = new Dictionary<string, string>();
                dicData.Add("ServerName", RSASecurity.Encrypt(txt_ServerName.Text.Trim()));
                dicData.Add("Authentication", RSASecurity.Encrypt(Functions.ToString(lk_Authentication.EditValue)));
                dicData.Add("ServerUser", RSASecurity.Encrypt(txt_ServerUser.Text.Trim()));
                dicData.Add("ServerPassword", RSASecurity.Encrypt(txt_ServerPassword.Text.Trim()));
                dicData.Add("DatabaseProvider", RSASecurity.Encrypt("MSSQL"));
                dicData.Add("DatabaseName", RSASecurity.Encrypt("MYACCOUNTS"));
                dicData.Add("LastUserSign", RSASecurity.Encrypt("empty"));

                var jsonData = JsonConvert.SerializeObject(dicData);
                File.WriteAllText(GlobalData.CONFIG_FILE, jsonData);
                if (File.Exists(GlobalData.CONFIG_FILE))
                {
                    var api = new CommonsController();
                    var result = api.InsertUserInfo(txt_FirstName.Text.Trim(), txt_LastName.Text.Trim(), txt_UserLogin.Text.Trim(), RSASecurity.Encrypt(txt_Password.Text.Trim()));
                    if (!string.IsNullOrEmpty(result))
                    {
                        WinCommons.ShowMessageDialog(result, MessageTitle.SystemError, Enums.MessageBoxType.Error);
                        return;
                    }
                    this.Hide();
                    var frm = new frm_Login();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
            WinCommons.CloseProcessing();
        }

        private void txt_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lk_Authentication_EditValueChanged(object sender, EventArgs e)
        {
            if (lk_Authentication.ItemIndex == 0)
            {
                txt_ServerUser.Enabled = false;
                txt_ServerPassword.Enabled = false;
                lbl_ServerUser.Enabled = false;
                lbl_ServerPassword.Enabled = false;
            }
            else
            {
                txt_ServerUser.Enabled = true;
                txt_ServerPassword.Enabled = true;
                lbl_ServerUser.Enabled = true;
                lbl_ServerPassword.Enabled = true;
            }
        }

        #endregion
    }
}