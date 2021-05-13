using System;

namespace MyAccounts.Forms.Categories
{
    public partial class frm_ShowAccountInfo : DevExpress.XtraEditors.XtraForm
    {
        public frm_ShowAccountInfo(string name, string type, string username, string password, string descriptions)
        {
            InitializeComponent();
            txt_Name.Text = name;
            txt_Type.Text = type;
            txt_Username.Text = username;
            txt_Password.Text = password;
            mno_Desc.Text = descriptions;
        }
    }
}