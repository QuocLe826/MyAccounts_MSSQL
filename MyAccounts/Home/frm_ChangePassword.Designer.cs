
namespace MyAccounts.Forms.Home
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.btn_Accept = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            resources.ApplyResources(this.pictureEdit1, "pictureEdit1");
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // txt_CurrentPassword
            // 
            resources.ApplyResources(this.txt_CurrentPassword, "txt_CurrentPassword");
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Properties.UseSystemPasswordChar = true;
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Name = "labelControl2";
            // 
            // txt_NewPassword
            // 
            resources.ApplyResources(this.txt_NewPassword, "txt_NewPassword");
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Properties.UseSystemPasswordChar = true;
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Name = "labelControl3";
            // 
            // txt_ConfirmPassword
            // 
            resources.ApplyResources(this.txt_ConfirmPassword, "txt_ConfirmPassword");
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Properties.UseSystemPasswordChar = true;
            // 
            // btn_Accept
            // 
            resources.ApplyResources(this.btn_Accept, "btn_Accept");
            this.btn_Accept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Accept.ImageOptions.Image")));
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_ChangePassword
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_CurrentPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_ChangePassword.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChangePassword";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_CurrentPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_NewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_ConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btn_Accept;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}