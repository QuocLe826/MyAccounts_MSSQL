
namespace MyAccounts.Forms.Home
{
    partial class frm_Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Backup));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_BackupName = new DevExpress.XtraEditors.LabelControl();
            this.txt_BackupName = new DevExpress.XtraEditors.TextEdit();
            this.btn_Backup = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.xtraSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BackupName.Properties)).BeginInit();
            this.SuspendLayout();
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
            // lbl_BackupName
            // 
            resources.ApplyResources(this.lbl_BackupName, "lbl_BackupName");
            this.lbl_BackupName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbl_BackupName.Appearance.Font")));
            this.lbl_BackupName.Appearance.Options.UseFont = true;
            this.lbl_BackupName.Name = "lbl_BackupName";
            // 
            // txt_BackupName
            // 
            resources.ApplyResources(this.txt_BackupName, "txt_BackupName");
            this.txt_BackupName.Name = "txt_BackupName";
            // 
            // btn_Backup
            // 
            resources.ApplyResources(this.btn_Backup, "btn_Backup");
            this.btn_Backup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backup.ImageOptions.Image")));
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // xtraSaveFileDialog
            // 
            resources.ApplyResources(this.xtraSaveFileDialog, "xtraSaveFileDialog");
            // 
            // frm_Backup
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.txt_BackupName);
            this.Controls.Add(this.lbl_BackupName);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_Backup.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Backup";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BackupName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lbl_BackupName;
        private DevExpress.XtraEditors.TextEdit txt_BackupName;
        private DevExpress.XtraEditors.SimpleButton btn_Backup;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog;
    }
}