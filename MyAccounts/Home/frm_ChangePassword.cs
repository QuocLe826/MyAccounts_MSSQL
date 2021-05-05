using System;
using System.Diagnostics;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms.Home
{
    public partial class frm_ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        private UsersController _userApi = new UsersController();

        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_CurrentPassword.Text))
                {
                    WinCommons.ShowMessageDialog("Current Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_CurrentPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_NewPassword.Text))
                {
                    WinCommons.ShowMessageDialog("New Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_NewPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_ConfirmPassword.Text))
                {
                    WinCommons.ShowMessageDialog("Confirm Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_ConfirmPassword.Focus();
                    return;
                }

                if (WinCommons.ShowMessageDialog("Are you sure to change password?", MessageTitle.SystemConfirm,
                        Enums.MessageBoxType.Question) == DialogResult.Yes)
                {
                    var result = _userApi.ChangePassword(GlobalData.UserLogin, txt_CurrentPassword.Text.Trim(), txt_NewPassword.Text.Trim(), txt_ConfirmPassword.Text.Trim());
                    if (!string.IsNullOrEmpty(result))
                    {
                        WinCommons.ShowMessageDialog(result, MessageTitle.SystemError, Enums.MessageBoxType.Error);
                        return;
                    }
                    WinCommons.ShowMessageDialog("Password changed successfully", MessageTitle.SystemInformation, Enums.MessageBoxType.Information);
                    this.Close();
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}