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

namespace MyAccounts.Forms
{
    public partial class frm_ChooseConfig : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChooseConfig()
        {
            InitializeComponent();
        }

        private void btn_CreateSystem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_CreateNewSystem();
            frm.Show();
        }

        private void btn_RestoreSystem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_SystemRestore();
            frm.Show();
        }
    }
}