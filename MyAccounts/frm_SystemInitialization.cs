using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using MyAccounts.Libraries.Security;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Resources;
using System.Threading;

namespace MyAccounts.Forms
{
    public partial class frm_SystemInitialization : XtraForm
    {
        private string _language = "en-US";
        private readonly ResourceManager _resource = new ResourceManager(typeof(frm_SystemInitialization));

        #region Constructor
        public frm_SystemInitialization()
        {
            InitializeComponent();
            GlobalData.DefaultLanguage = "en-US";
        }

        #endregion

        #region Methods

        private bool WriteConfig(string databaseName)
        {
            try
            {
                if (File.Exists(GlobalData.CONFIG_PATH))
                {
                    File.Delete(GlobalData.CONFIG_PATH);
                }
                var dicData = new Dictionary<string, string>();
                dicData.Add("ServerName", RSASecurity.Encrypt(txt_ServerName.Text.Trim()));
                dicData.Add("Authentication", RSASecurity.Encrypt(Functions.ToString(lk_Authentication.EditValue)));
                dicData.Add("ServerUser", RSASecurity.Encrypt(txt_ServerUser.Text.Trim()));
                dicData.Add("ServerPassword", RSASecurity.Encrypt(txt_ServerPassword.Text.Trim()));
                dicData.Add("DatabaseProvider", RSASecurity.Encrypt("MSSQL"));
                dicData.Add("DatabaseName", RSASecurity.Encrypt(databaseName));
                dicData.Add("DefaultLanguage", RSASecurity.Encrypt(_language));

                var jsonData = JsonConvert.SerializeObject(dicData);
                File.WriteAllText(GlobalData.CONFIG_PATH, jsonData);
                return File.Exists(GlobalData.CONFIG_PATH);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                return false;
            }
        }

        private void SetLanguage(string language)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                this.Text = language == "en-US" ? "System Initialization" : "Khởi tạo hệ thống";
                foreach (Control control in this.Controls)
                {
                    var resource = new ComponentResourceManager(typeof(frm_SystemInitialization));
                    resource.ApplyResources(control, control.Name, new CultureInfo(language));
                }
                _language = language;
                GlobalData.DefaultLanguage = language;
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
            }
        }

        #endregion

        #region Events

        private void frm_SystemInitialization_Load(object sender, EventArgs e)
        {
            try
            {
                var dbExists = File.Exists("System//config//initserver");
                if (!dbExists)
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("SystemFilesCannotBeFound"), Enums.MessageBoxType.Error);
                    this.Close();
                    return;
                }
                lk_Authentication.Properties.DataSource = CommonConstants.DicAuthentications;
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, Enums.MessageBoxType.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ServerName.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerNameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_ServerName.Focus();
                    return;
                }
                if (lk_Authentication.ItemIndex == -1)
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("PleaseChooseAuthentication"),  Enums.MessageBoxType.Error);
                    lk_Authentication.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerUser.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerUsernameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_ServerUser.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerPassword.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerPasswordCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_ServerPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_FirstName.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("FirstNameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_FirstName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_LastName.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("LastNameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_LastName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_UserLogin.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("UserLoginCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_UserLogin.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("PasswordCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_Password.Focus();
                    return;
                }

                WinCommons.OpenCursorProcessing(this);
                var serverConnected = lk_Authentication.ItemIndex == 0
                        ? WinCommons.CheckConnection(txt_ServerName.Text)
                        : WinCommons.CheckConnection(txt_ServerName.Text, txt_ServerUser.Text, txt_ServerPassword.Text);
                if (!serverConnected)
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ConnectToServerFailed"),  Enums.MessageBoxType.Error);
                    WinCommons.CloseCursorProcessing(this);
                    return;
                }

                if (WriteConfig("master"))
                {
                    var path = string.Format(@"{0}//System//config//initserver", Application.StartupPath);
                    var api = new CommonsController();
                    var result = api.RestoreDatabase(path);
                    if (!string.IsNullOrEmpty(result))
                    {
                        WinCommons.ShowMessageDialog(result,  Enums.MessageBoxType.Error);
                        File.Delete(GlobalData.CONFIG_PATH);
                        WinCommons.CloseCursorProcessing(this);
                        return;
                    }

                    if (WriteConfig("MYACCOUNTS"))
                    {
                        api = new CommonsController();
                        var passEncrypt = RSASecurity.Encrypt(txt_Password.Text.Trim());
                        var passEncrypt1 = passEncrypt.Substring(0, passEncrypt.Length - 1);

                        result = api.InsertUserInfo(txt_FirstName.Text.Trim(), txt_LastName.Text.Trim(), txt_UserLogin.Text.Trim(), passEncrypt1);
                        if (!string.IsNullOrEmpty(result))
                        {
                            WinCommons.ShowMessageDialog(result,  Enums.MessageBoxType.Error);
                            File.Delete(GlobalData.CONFIG_PATH);
                            WinCommons.CloseCursorProcessing(this);
                            return;
                        }
                        WinCommons.CloseCursorProcessing(this);
                        this.Hide();
                        var frm = new frm_Login();
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
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

        private void rd_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = rd_Languages.SelectedIndex == 0 ? "en-US" : "vi-VN";
            SetLanguage(language);
        }

        private void frm_SystemInitialization_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        #endregion
    }
}