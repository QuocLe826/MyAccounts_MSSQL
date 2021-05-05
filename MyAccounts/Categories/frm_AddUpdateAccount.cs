using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using DevExpress.Utils.Svg;
using MyAccounts.Api.Categories;
using MyAccounts.Libraries.Constants;
using MyAccounts.Libraries.Enums;
using MyAccounts.Libraries.Helpers;
using MyAccounts.Libraries.Logging;
using MyAccounts.Libraries.Security;

namespace MyAccounts.Forms.Categories
{
    public partial class frm_AddUpdateAccount : XtraForm
    {
        private AccountManagementController _accManagementApi = new AccountManagementController();
        private string _actionType = string.Empty;
        private string _accCode = string.Empty;
        public bool IsSuccess = false;

        public frm_AddUpdateAccount(string actionType)
        {
            InitializeComponent();
            this.Text = @"Add New Account";
            this.IconOptions.SvgImage = SvgImage.FromFile("System//images//add.svg");
            txt_Code.ReadOnly = false;
            _actionType = actionType;
        }

        public frm_AddUpdateAccount(string code, string actionType)
        {
            InitializeComponent();

            this.Text = @"Edit Account";
            this.IconOptions.SvgImage = SvgImage.FromFile("System//images//edit.svg");
            txt_Code.ReadOnly = true;
            _actionType = actionType;
            _accCode = code;
        }

        private void frm_AddNewAccount_Load(object sender, EventArgs e)
        {
            try
            {
                lk_AccountGroup.Properties.DataSource = _accManagementApi.GetAccountGroups();
                lk_AccountType.Properties.DataSource = _accManagementApi.GetAccountType();
                lk_Status.Properties.DataSource = CommonConstants.DicStatus;
                lk_Status.ItemIndex = 0;
                txt_Code.Focus();

                if (!string.IsNullOrEmpty(_accCode) && _actionType == "U")
                {
                    var dt = _accManagementApi.GetAccountManagementByCode(_accCode);
                    if (dt.Rows.Count == 0)
                    {
                        WinCommons.ShowMessageDialog("Get data error!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                        this.Close();
                        return;
                    }

                    txt_Code.Text = Functions.ToString(dt.Rows[0]["Code"]);
                    txt_Name.Text = Functions.ToString(dt.Rows[0]["Name"]);
                    txt_Username.Text = Functions.ToString(dt.Rows[0]["Username"]);
                    txt_Password.Text = Functions.ToString(dt.Rows[0]["Password"]);
                    lk_AccountGroup.EditValue = Functions.ToString(dt.Rows[0]["AccGroupCode"]);
                    lk_AccountType.EditValue = Functions.ToString(dt.Rows[0]["AccTypeCode"]);
                    lk_Status.EditValue = Functions.ToString(dt.Rows[0]["Status"]);
                    mno_Desc.Text = Functions.ToString(dt.Rows[0]["Descriptions"]);
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Code.Text))
                {
                    WinCommons.ShowMessageDialog("Code cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Code.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    WinCommons.ShowMessageDialog("Name cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Name.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Username.Text))
                {
                    WinCommons.ShowMessageDialog("Username cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Username.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    WinCommons.ShowMessageDialog("Password cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    txt_Code.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Functions.ToString(lk_AccountGroup.EditValue)))
                {
                    WinCommons.ShowMessageDialog("Account Group cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    lk_AccountGroup.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(Functions.ToString(lk_AccountType.EditValue)))
                {
                    WinCommons.ShowMessageDialog("Account Type cannot be empty value!", MessageTitle.SystemError, Enums.MessageBoxType.Error);
                    lk_AccountType.Focus();
                    return;
                }

                var dicData = new Dictionary<string,string>();
                dicData.Add("Code", txt_Code.Text.Trim());
                dicData.Add("Name", txt_Name.Text.Trim());
                dicData.Add("Username", txt_Username.Text.Trim());
                dicData.Add("Password", RSASecurity.Encrypt(txt_Password.Text.Trim()));
                dicData.Add("AccGroup", Functions.ToString(lk_AccountGroup.EditValue));
                dicData.Add("AccType", Functions.ToString(lk_AccountType.EditValue));
                dicData.Add("Status", Functions.ToString(lk_Status.EditValue));
                dicData.Add("Descriptions", mno_Desc.Text.Trim());

                var result = _accManagementApi.ProcessData(dicData, _actionType);
                if (string.IsNullOrEmpty(result))
                {
                    IsSuccess = true;
                    this.Close();
                    return;
                }
                IsSuccess = false;
                WinCommons.ShowMessageDialog(result, MessageTitle.SystemError, Enums.MessageBoxType.Error);
                txt_Code.Focus();
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

        private void txt_Password_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Index == 0)
                {
                    if (txt_Password.Properties.UseSystemPasswordChar)
                    {
                        txt_Password.Properties.UseSystemPasswordChar = false;
                        e.Button.ImageOptions.SvgImage = SvgImage.FromFile("System//images//hide.svg");
                        e.Button.ToolTip = "Hide Password";
                    }
                    else
                    {
                        txt_Password.Properties.UseSystemPasswordChar = true;
                        e.Button.ImageOptions.SvgImage = SvgImage.FromFile("System//images//show.svg");
                        e.Button.ToolTip = "Show Password";
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Write(Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                WinCommons.ShowMessageDialog(ex.Message, MessageTitle.SystemError, Enums.MessageBoxType.Error);
            }
        }
    }
}