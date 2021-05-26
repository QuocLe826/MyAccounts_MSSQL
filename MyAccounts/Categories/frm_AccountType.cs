using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MyAccounts.Api.Categories;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using System.Resources;

namespace MyAccounts.Forms.Categories
{
    public partial class frm_AccountType : XtraForm
    {
        private readonly AccountTypeController _accountTypeApi = new AccountTypeController();
        private readonly ResourceManager _resources = new ResourceManager(typeof(frm_AccountType));
        private string _formStatus = string.Empty;

        public frm_AccountType()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                var dt = _accountTypeApi.GetAccountType();
                grd_AccountType.DataSource = dt;
                grd_AccountType.RefreshDataSource();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void EnableDisableControls(string actionType)
        {
            switch (actionType)
            {
                case "A":
                    btn_AddNew.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_Save.Enabled = true;
                    btn_Cancel.Enabled = true;
                    btn_Delete.Enabled = false;
                    btn_Refresh.Enabled = false;
                    btn_Search.Enabled = false;
                    txt_Code.ReadOnly = false;
                    break;
                case "U":
                    btn_AddNew.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_Save.Enabled = true;
                    btn_Cancel.Enabled = true;
                    btn_Delete.Enabled = false;
                    btn_Refresh.Enabled = false;
                    btn_Search.Enabled = false;
                    txt_Code.ReadOnly = true;
                    break;
                default:
                    btn_AddNew.Enabled = true;
                    btn_Edit.Enabled = gv_AccountType.RowCount > 0;
                    btn_Save.Enabled = false;
                    btn_Cancel.Enabled = false;
                    btn_Delete.Enabled = gv_AccountType.RowCount > 0;
                    btn_Refresh.Enabled = true;
                    btn_Search.Enabled = true;
                    txt_Code.ReadOnly = false;
                    break;
            }
        }

        private void ClearTextControls()
        {
            txt_Code.ResetText();
            txt_Name.ResetText();
            txt_Desc.ResetText();
            lk_Status.ItemIndex = 0;
        }

        private void BindingControlsData(int rowHandle)
        {
            txt_Code.Text = Functions.ToString(gv_AccountType.GetRowCellValue(rowHandle, "Code"));
            txt_Name.Text = Functions.ToString(gv_AccountType.GetRowCellValue(rowHandle, "Name"));
            lk_Status.EditValue = Functions.ToString(gv_AccountType.GetRowCellValue(rowHandle, "Status"));
            txt_Desc.Text = Functions.ToString(gv_AccountType.GetRowCellValue(rowHandle, "Descriptions"));
        }

        private void gv_AccountType_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                if (e.FocusedRowHandle < 0)
                {
                    return;
                }
                BindingControlsData(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
        }

        private void btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _formStatus = "A";
            ClearTextControls();
            EnableDisableControls(_formStatus);
            txt_Code.Focus();
        }

        private void frm_AccountType_Load(object sender, EventArgs e)
        {
            try
            {
                WinCommons.OpenCursorProcessing(this);
                _formStatus = string.Empty;
                if (GlobalData.DefaultLanguage == "en-US")
                {
                    lk_Status.Properties.DataSource = CommonConstants.DicStatus_EN;
                    rep_Status.DataSource = CommonConstants.DicStatus_EN;
                }
                else
                {
                    lk_Status.Properties.DataSource = CommonConstants.DicStatus_VN;
                    rep_Status.DataSource = CommonConstants.DicStatus_VN;
                }
                lk_Status.ItemIndex = 0;
                LoadData();
                EnableDisableControls(_formStatus);
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _formStatus = "U";
            txt_Name.Focus();
            EnableDisableControls(_formStatus);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Code.Text))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("CodeCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_Code.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    WinCommons.ShowMessageDialog(_resources.GetString("NameCannotBeEmptyValue"),  Enums.MessageBoxType.Error);
                    txt_Name.Focus();
                    return;
                }

                var message = _formStatus == "A"
                    ? _resources.GetString("DoYouWantToAddNew")
                    : _resources.GetString("DoYouWantToSaveChanges");

                if (WinCommons.ShowMessageDialog(message, Enums.MessageBoxType.Question) == DialogResult.Yes)
                {
                    WinCommons.OpenCursorProcessing(this);
                    var dt = (grd_AccountType.DataSource as DataTable).Clone();
                    var newRow = dt.NewRow();
                    newRow["Code"] = txt_Code.Text.Trim();
                    newRow["Name"] = txt_Name.Text.Trim();
                    newRow["Status"] = Functions.ToString(lk_Status.EditValue);
                    newRow["Descriptions"] = txt_Desc.Text.Trim();
                    dt.Rows.Add(newRow.ItemArray);
                    dt.AcceptChanges();

                    var result = _accountTypeApi.ProcessAccountType(dt, _formStatus);
                    if (!string.IsNullOrEmpty(result.Item1) && !string.IsNullOrEmpty(result.Item2))
                    {
                        WinCommons.ShowMessageDialog(GlobalData.DefaultLanguage == "en-US" ? result.Item1 : result.Item2,  Enums.MessageBoxType.Error);
                        WinCommons.CloseCursorProcessing(this);
                        return;
                    }

                    _formStatus = string.Empty;
                    LoadData();
                    EnableDisableControls(_formStatus);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _formStatus = string.Empty;
            ClearTextControls();
            EnableDisableControls(_formStatus);
            BindingControlsData(gv_AccountType.FocusedRowHandle);
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (WinCommons.ShowMessageDialog(_resources.GetString("AreYouSureToRemoveThisRecord"), Enums.MessageBoxType.Question) == DialogResult.Yes)
                {
                    WinCommons.OpenCursorProcessing(this);
                    var result = _accountTypeApi.DeleteAccountType(txt_Code.Text.Trim());
                    if (!string.IsNullOrEmpty(result.Item1) && !string.IsNullOrEmpty(result.Item2))
                    {
                        WinCommons.ShowMessageDialog(GlobalData.DefaultLanguage == "en-US" ? result.Item1 : result.Item2,  Enums.MessageBoxType.Error);
                        WinCommons.CloseCursorProcessing(this);
                        return;
                    }
                    _formStatus = string.Empty;
                    LoadData();
                    EnableDisableControls(_formStatus);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WinCommons.OpenCursorProcessing(this);
            _formStatus = string.Empty;
            LoadData();
            EnableDisableControls(_formStatus);
            WinCommons.CloseCursorProcessing(this);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                WinCommons.OpenCursorProcessing(this);
                var dt = _accountTypeApi.SearchAccountType(txt_Code.Text.Trim(), txt_Name.Text.Trim(), Functions.ToString(lk_Status.EditValue), txt_Desc.Text.Trim());
                grd_AccountType.DataSource = dt;
                grd_AccountType.RefreshDataSource();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message,  Enums.MessageBoxType.Error);
            }
            WinCommons.CloseCursorProcessing(this);
        }

        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}