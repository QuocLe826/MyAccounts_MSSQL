using System;
using System.Diagnostics;
using System.Resources;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms.Home
{
    public partial class frm_Restore : DevExpress.XtraEditors.XtraForm
    {
        private readonly CommonsController _commonApi = new CommonsController();
        private readonly ResourceManager _resources = new ResourceManager(typeof(frm_Restore));

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
                    WinCommons.ShowMessageDialog(_resources.GetString("PleaseChooseRestoreFile"),  Enums.MessageBoxType.Error);
                    btn_RestoreFile.Focus();
                    return;
                }

                if (WinCommons.ShowMessageDialog(_resources.GetString("AreYouSureToRestoreSystem"), Enums.MessageBoxType.Question) == DialogResult.Yes)
                {
                    var path = xtraOpenFileDialog.FileName;
                    var res = _commonApi.RestoreDatabase(path);
                    if (string.IsNullOrEmpty(res.Item1))
                    {
                        WinCommons.ShowMessageDialog(_resources.GetString("RestoreSuccessfully"), Enums.MessageBoxType.Information);
                        this.Close();
                        Application.Restart();
                    }
                    else
                    {
                        WinCommons.ShowMessageDialog(_resources.GetString("RestoreFailed"), Enums.MessageBoxType.Error);
                    }
                }
               
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
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