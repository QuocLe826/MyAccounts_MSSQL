
namespace MyAccounts.Forms
{
    partial class frm_SystemRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SystemRestore));
            this.lk_Authentication = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_ServerPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_ServerUser = new DevExpress.XtraEditors.TextEdit();
            this.txt_ServerName = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ServerPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ServerUser = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Path = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lk_Authentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Path.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lk_Authentication
            // 
            resources.ApplyResources(this.lk_Authentication, "lk_Authentication");
            this.lk_Authentication.Name = "lk_Authentication";
            this.lk_Authentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lk_Authentication.Properties.Buttons"))))});
            this.lk_Authentication.Properties.DisplayMember = "Value";
            this.lk_Authentication.Properties.NullText = resources.GetString("lk_Authentication.Properties.NullText");
            this.lk_Authentication.Properties.ValueMember = "Key";
            // 
            // txt_ServerPassword
            // 
            resources.ApplyResources(this.txt_ServerPassword, "txt_ServerPassword");
            this.txt_ServerPassword.Name = "txt_ServerPassword";
            this.txt_ServerPassword.Properties.UseSystemPasswordChar = true;
            // 
            // txt_ServerUser
            // 
            resources.ApplyResources(this.txt_ServerUser, "txt_ServerUser");
            this.txt_ServerUser.Name = "txt_ServerUser";
            // 
            // txt_ServerName
            // 
            resources.ApplyResources(this.txt_ServerName, "txt_ServerName");
            this.txt_ServerName.Name = "txt_ServerName";
            // 
            // lbl_ServerPassword
            // 
            resources.ApplyResources(this.lbl_ServerPassword, "lbl_ServerPassword");
            this.lbl_ServerPassword.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbl_ServerPassword.Appearance.Font")));
            this.lbl_ServerPassword.Appearance.Options.UseFont = true;
            this.lbl_ServerPassword.Name = "lbl_ServerPassword";
            // 
            // lbl_ServerUser
            // 
            resources.ApplyResources(this.lbl_ServerUser, "lbl_ServerUser");
            this.lbl_ServerUser.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbl_ServerUser.Appearance.Font")));
            this.lbl_ServerUser.Appearance.Options.UseFont = true;
            this.lbl_ServerUser.Name = "lbl_ServerUser";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // pictureEdit1
            // 
            resources.ApplyResources(this.pictureEdit1, "pictureEdit1");
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Name = "labelControl3";
            // 
            // btn_OK
            // 
            resources.ApplyResources(this.btn_OK, "btn_OK");
            this.btn_OK.AllowFocus = false;
            this.btn_OK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OK.ImageOptions.Image")));
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.AllowFocus = false;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_Path
            // 
            resources.ApplyResources(this.btn_Path, "btn_Path");
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_Path.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Path_ButtonPressed);
            // 
            // xtraOpenFileDialog
            // 
            resources.ApplyResources(this.xtraOpenFileDialog, "xtraOpenFileDialog");
            // 
            // frm_SystemRestore
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lk_Authentication);
            this.Controls.Add(this.txt_ServerPassword);
            this.Controls.Add(this.txt_ServerUser);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbl_ServerPassword);
            this.Controls.Add(this.lbl_ServerUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_SystemRestore.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SystemRestore";
            this.Load += new System.EventHandler(this.frm_SystemRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lk_Authentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Path.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lk_Authentication;
        private DevExpress.XtraEditors.TextEdit txt_ServerPassword;
        private DevExpress.XtraEditors.TextEdit txt_ServerUser;
        private DevExpress.XtraEditors.TextEdit txt_ServerName;
        private DevExpress.XtraEditors.LabelControl lbl_ServerPassword;
        private DevExpress.XtraEditors.LabelControl lbl_ServerUser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.ButtonEdit btn_Path;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
    }
}