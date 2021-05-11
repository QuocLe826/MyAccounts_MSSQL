using System;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyAccounts.Forms.Categories;
using MyAccounts.Forms.Home;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Logging;

namespace MyAccounts.Forms
{
    public partial class frm_Main : XtraForm
    {

        private readonly ResourceManager _resources = new ResourceManager(typeof(frm_Main));

        public frm_Main()
        {
            InitializeComponent();
        }

        private void ShowFormDialog(XtraForm form)
        {
            try
            {
                form.TopLevel = true;
                form.ShowInTaskbar = false;
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void ShowMdiForm(XtraForm form)
        {
            try
            {
                var tabForm = xtraTabbedMdiManager.Pages.AsEnumerable().FirstOrDefault(r => r.MdiChild.Text == form.Text);
                if (tabForm != null)
                {
                    xtraTabbedMdiManager.SelectedPage = tabForm;
                    return;
                }
                form.TopLevel = true;
                form.MdiParent = this;
                form.ShowInTaskbar = false;
                form.Show();
            }
            catch (Exception ex)
            { 
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiForm(new frm_AccountGroups());
        }

        private void btn_ChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormDialog(new frm_ChangePassword());
        }

        private void btn_Restore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormDialog(new frm_Restore());
        }

        private void btn_Backup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormDialog(new frm_Backup());
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_Server.Caption = string.Format(@"{0} {1}",_resources.GetString("Server"), GlobalData.ServerName);
                lbl_User.Caption = string.Format(@"{0} {1} {2}", _resources.GetString("User"),  GlobalData.LastName, GlobalData.FirstName);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiForm(new frm_AccountType());
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiForm(new frm_AccountManagement());
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
