using System;
using System.Diagnostics;
using System.Resources;
using System.Windows.Forms;
using MyAccounts.Api.Categories;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MyAccounts.Forms.Categories
{
    public partial class frm_AccountManagement : XtraForm
    {
        private readonly AccountManagementController _accManagementApi = new AccountManagementController();
        private readonly ResourceManager _resources = new ResourceManager(typeof(frm_AccountManagement));
        private string _actionType = string.Empty;

        public frm_AccountManagement()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                var dt = _accManagementApi.GetAccountManagement();
                grd_AccManagement.DataSource = dt;
                grd_AccManagement.RefreshDataSource();
                gv_AccManagement.BestFitColumns();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void EnableDisableControls()
        {
            btn_Edit.Enabled = gv_AccManagement.RowCount > 0;
            btn_Delete.Enabled = gv_AccManagement.RowCount > 0;
            btn_ShowAccInfo.Enabled = gv_AccManagement.RowCount > 0;
        }

        private void frm_AccountManagement_Load(object sender, EventArgs e)
        {
            try
            {
                WinCommons.OpenCursorProcessing(this);
                lk_AccGroups.Properties.DataSource = _accManagementApi.GetAccountGroups();
                lk_AccType.Properties.DataSource = _accManagementApi.GetAccountType();
                if (GlobalData.DefaultLanguage == "en-US")
                {
                    rep_Status.DataSource = CommonConstants.DicStatus_EN;
                }
                else
                {
                    rep_Status.DataSource = CommonConstants.DicStatus_VN;
                }
                LoadData();
                EnableDisableControls();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _actionType = "A";
            EnableDisableControls();
            var frm = new frm_AddUpdateAccount(_actionType);
            frm.ShowDialog(this);
            if (frm.IsSuccess)
            {
                _actionType = string.Empty;
                LoadData();
                EnableDisableControls();
            }
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _actionType = "U";
            var frm = new frm_AddUpdateAccount(Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Code")), _actionType);
            frm.ShowDialog(this);
            if (frm.IsSuccess)
            {
                _actionType = string.Empty;
                LoadData();
                EnableDisableControls();
            }
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WinCommons.OpenCursorProcessing(this);
            _actionType = string.Empty;
            LoadData();
            EnableDisableControls();
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_ShowAccInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gv_AccManagement.IsGroupRow(gv_AccManagement.FocusedRowHandle))
                {
                    return;
                }
                var frm = new frm_ShowAccountInfo(
                    Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Name")),
                    Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "AccTypeName")),
                    Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Username")),
                    Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Password")),
                    Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Descriptions")));
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, Enums.MessageBoxType.Error);
            }
        }

        private void grd_AccManagement_DoubleClick(object sender, EventArgs e)
        {
            if (gv_AccManagement.IsRowSelected(gv_AccManagement.FocusedRowHandle) && !gv_AccManagement.IsGroupRow(gv_AccManagement.FocusedRowHandle))
            {
                btn_ShowAccInfo_ItemClick(sender, null);
            }
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (WinCommons.ShowMessageDialog(_resources.GetString("AreYouSureToDeleteThisRecord"),
                        Enums.MessageBoxType.Question) == DialogResult.Yes)
                {
                    WinCommons.OpenCursorProcessing(this);
                    var result = _accManagementApi.DeleteAccount(Functions.ToString(gv_AccManagement.GetRowCellValue(gv_AccManagement.FocusedRowHandle, "Code")));
                    if (!string.IsNullOrEmpty(result))
                    {
                        WinCommons.ShowMessageDialog(result,  Enums.MessageBoxType.Error);
                        WinCommons.CloseCursorProcessing(this);
                        return;
                    }
                    LoadData();
                    EnableDisableControls();
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                WinCommons.OpenCursorProcessing(this);
                var dt = _accManagementApi.SearchData(txt_Username.Text.Trim(), Functions.ToString(lk_AccGroups.EditValue), Functions.ToString(lk_AccType.EditValue));
                grd_AccManagement.DataSource = dt;
                grd_AccManagement.RefreshDataSource();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void gv_AccManagement_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            try
            {
                var gv = sender as GridView;
                var info = e.Info as GridGroupRowInfo;
                if (info == null)
                    return;
                info.GroupText = string.Format("{1} ({2})", info.Column.Caption, info.GroupValueText, gv.GetChildRowCount(e.RowHandle));
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, Enums.MessageBoxType.Error);
            }
        }
    }
}