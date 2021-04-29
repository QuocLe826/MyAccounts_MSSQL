using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccounts.Forms.Categories
{
    public partial class frm_ShowAccountInfo : DevExpress.XtraEditors.XtraForm
    {
        private string _name = string.Empty;
        private string _type = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _descriptions = string.Empty;

        public frm_ShowAccountInfo(string name, string type, string username, string password, string descriptions)
        {
            InitializeComponent();
            _name = name;
            _type = type;
            _username = username;
            _password = password;
            _descriptions = descriptions;
        }

        private void frm_ShowAccountInfo_Load(object sender, EventArgs e)
        {
            txt_Name.Text = _name;
            txt_Username.Text = _username;
            txt_Password.Text = _password;
            txt_Type.Text = _type;
            mno_Desc.Text = _descriptions;
        }
    }
}