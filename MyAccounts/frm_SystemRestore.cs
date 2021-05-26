using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms
{
    public partial class frm_SystemRestore : XtraForm
    {
        private readonly ResourceManager _resource = new ResourceManager(typeof(frm_SystemRestore));
        private readonly CommonsController _commonApi = new CommonsController();

        public frm_SystemRestore()
        {
            GlobalData.DefaultLanguage = "en-US";
            InitializeComponent();
        }

        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_ChooseConfig();
            frm.Show();
        }

        private void btn_Path_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xtraOpenFileDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(xtraOpenFileDialog.FileName))
            {
                btn_Path.Text = xtraOpenFileDialog.FileName;
            }
        }

        private void frm_SystemRestore_Load(object sender, EventArgs e)
        {
            lk_Authentication.Properties.DataSource = CommonConstants.DicAuthentications;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validated controls data

                if (string.IsNullOrEmpty(txt_ServerName.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerNameCannotBeEmptyValue"), Enums.MessageBoxType.Error);
                    txt_ServerName.Focus();
                    return;
                }
                if (lk_Authentication.ItemIndex == -1)
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("PleaseChooseAuthentication"), Enums.MessageBoxType.Error);
                    lk_Authentication.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerUser.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerUsernameCannotBeEmptyValue"), Enums.MessageBoxType.Error);
                    txt_ServerUser.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ServerPassword.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ServerPasswordCannotBeEmptyValue"), Enums.MessageBoxType.Error);
                    txt_ServerPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(btn_Path.Text))
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("SelectDatabaseBackup"), Enums.MessageBoxType.Error);
                    btn_Path.Focus();
                    return;
                }

                WinCommons.OpenCursorProcessing(this);
                var serverConnected = lk_Authentication.ItemIndex == 0
                        ? WinCommons.CheckConnection(txt_ServerName.Text)
                        : WinCommons.CheckConnection(txt_ServerName.Text, txt_ServerUser.Text, txt_ServerPassword.Text);
                if (!serverConnected)
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("ConnectToServerFailed"), Enums.MessageBoxType.Error);
                    WinCommons.CloseCursorProcessing(this);
                    return;
                }

                #endregion

                var writeConfig = WinCommons.WriteConfiguration(txt_ServerName.Text, Functions.ToString(lk_Authentication.EditValue), txt_ServerUser.Text, txt_ServerPassword.Text, @"MYACCOUNTS", GlobalData.DefaultLanguage);
                if (writeConfig)
                {
                    var api = new CommonsController();
                    var result = api.RestoreDatabase(xtraOpenFileDialog.FileName);
                    if (!string.IsNullOrEmpty(result.Item1) && !string.IsNullOrEmpty(result.Item2))
                    {
                        WinCommons.ShowMessageDialog(GlobalData.DefaultLanguage == "en-US" ? result.Item1 : result.Item2, Enums.MessageBoxType.Error);
                        File.Delete(GlobalData.CONFIG_PATH);
                        WinCommons.CloseCursorProcessing(this);
                        return;
                    }
                    WinCommons.ShowMessageDialog(_resource.GetString("RestoreSuccessfully"), Enums.MessageBoxType.Information);
                    this.Hide();
                    var frm = new frm_Login();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(this);
                }
                else
                {
                    WinCommons.ShowMessageDialog(_resource.GetString("WriteConfigFailed"), Enums.MessageBoxType.Error);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }
    }
}