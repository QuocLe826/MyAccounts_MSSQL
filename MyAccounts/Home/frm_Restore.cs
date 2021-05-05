using System;
using System.Diagnostics;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms.Home
{
    public partial class frm_Restore : DevExpress.XtraEditors.XtraForm
    {
        private CommonsController _commonApi = new CommonsController();

        public frm_Restore()
        {
            InitializeComponent();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btn_RestoreFile.Text))
                {
                    WinCommons.ShowMessageDialog("Please choose restore file!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    btn_RestoreFile.Focus();
                    return;
                }
                var path = xtraOpenFileDialog.FileName;
                var res = _commonApi.RestoreDatabase(path);
                if (string.IsNullOrEmpty(res))
                {
                    WinCommons.ShowMessageDialog("Restore successfully", MessageTitle.SystemInformation, Enums.MessageBoxType.Information);
                    this.Close();
                    Application.Restart();
                }
                else
                {
                    WinCommons.ShowMessageDialog("Restore failed!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
        }

        private void btn_BackupFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xtraOpenFileDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(xtraOpenFileDialog.FileName))
            {
                btn_RestoreFile.Text = xtraOpenFileDialog.FileName;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}