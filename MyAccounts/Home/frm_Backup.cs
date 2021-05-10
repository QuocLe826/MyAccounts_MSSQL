using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Resources;
using System.Windows.Forms;
using MyAccounts.Api.Commons;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms.Home
{
    public partial class frm_Backup : XtraForm
    {

        private CommonsController _commonApi = new CommonsController();
        private ResourceManager _resources = new ResourceManager(typeof(frm_Backup));

        public frm_Backup()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_BackupName.Text))
                {
                    txt_BackupName.Focus();
                    return;
                }
                xtraSaveFileDialog.FileName = txt_BackupName.Text;
                if (xtraSaveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var path = xtraSaveFileDialog.FileName;
                    var res = _commonApi.BackupDatabase(path);
                    if (string.IsNullOrEmpty(res))
                    {
                        WinCommons.ShowMessageDialog(_resources.GetString("BackupSuccessfully"), Enums.MessageBoxType.Information);
                        this.Close();
                    }
                    else
                    {
                        WinCommons.ShowMessageDialog(_resources.GetString("BackupFailed"),  Enums.MessageBoxType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}