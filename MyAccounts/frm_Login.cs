using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
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
        private readonly ResourceManager _resources = new ResourceManager(typeof(frm_Login));
        
        public frm_Login()
        {
            InitializeComponent();
            SetLanguage(GlobalData.DefaultLanguage);
        }

        private void SetLanguage(string language)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                this.Text = language == "en-US" ? "Login" : "Đăng nhập";
                foreach (Control control in this.Controls)
                {
                    var resource = new ComponentResourceManager(typeof(frm_Login));
                    resource.ApplyResources(control, control.Name, new CultureInfo(language));
                }
                GlobalData.DefaultLanguage = language;
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
            }
        }

        private void WriteLanguageConfig(string language)
        {
            try
            {
                var fileData = File.ReadAllText(GlobalData.CONFIG_PATH);
                if (!string.IsNullOrEmpty(fileData))
                {
                    var dicData = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileData);
                    if (dicData != null && dicData.Count > 0)
                    {
                        dicData["DefaultLanguage"] = RSASecurity.Encrypt(language);
                        var json = JsonConvert.SerializeObject(dicData);
                        File.Delete(GlobalData.CONFIG_PATH);
                        File.WriteAllText(GlobalData.CONFIG_PATH, json);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Username.Text))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("UsernameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_Username.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("PasswordCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_Password.Focus();
                    return;
                }

                WinCommons.OpenCursorProcessing(this);
                var result = _loginApi.Login(txt_Username.Text.Trim(), txt_Password.Text.Trim());
                if (!string.IsNullOrEmpty(result))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("IncorrectUserNameOrPassword"),  Enums.MessageBoxType.Error);
                    WinCommons.CloseCursorProcessing(this);
                    return;
                }

                var dtInfo = _loginApi.GetUserInfo(txt_Username.Text.Trim());
                if (dtInfo.Rows.Count == 0)
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("LoginFailed"),  Enums.MessageBoxType.Error);
                    WinCommons.CloseCursorProcessing(this);
                    return;
                }
                GlobalData.UserId = Functions.ParseInteger(dtInfo.Rows[0]["UserID"]);
                GlobalData.UserLogin = Functions.ToString(dtInfo.Rows[0]["UserCode"]);
                GlobalData.FirstName = Functions.ToString(dtInfo.Rows[0]["FirstName"]);
                GlobalData.LastName = Functions.ToString(dtInfo.Rows[0]["LastName"]);

                WinCommons.CloseCursorProcessing(this);
                this.Hide();
                var frm = new frm_Main();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);;
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.Focus();
                btn_Login_Click(sender, null);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                var resourcesExists = File.Exists("System//Images//add.svg") && File.Exists("System//Images//edit.svg");
                var dbExists = File.Exists("System//config//initserver");

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(50);
                }

                if (!resourcesExists || !dbExists)
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("SystemFilesCannotBeFound"), Enums.MessageBoxType.Error);
                    this.Dispose();
                    Application.Exit();
                    return;
                }
                if (GlobalData.DefaultLanguage == "en-US")
                {
                    chk_English.Checked = true;
                    chk_Vietnamese.Checked = false;
                }
                else
                {
                    chk_English.Checked = false;
                    chk_Vietnamese.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void chk_English_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chk_English.Checked = true;
            chk_Vietnamese.Checked = false;
            SetLanguage("en-US");
            WriteLanguageConfig("en-US");
        }

        private void chk_Vietnamese_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chk_English.Checked = false;
            chk_Vietnamese.Checked = true;
            SetLanguage("vi-VN");
            WriteLanguageConfig("vi-VN");
        }
    }
}