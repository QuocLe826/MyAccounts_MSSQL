
namespace MyAccounts.Forms.Home
{
    partial class frm_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Restore));
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Restore = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_RestoreName = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btn_RestoreFile = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RestoreFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Restore
            // 
            resources.ApplyResources(this.btn_Restore, "btn_Restore");
            this.btn_Restore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.ImageOptions.Image")));
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // lbl_RestoreName
            // 
            resources.ApplyResources(this.lbl_RestoreName, "lbl_RestoreName");
            this.lbl_RestoreName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbl_RestoreName.Appearance.Font")));
            this.lbl_RestoreName.Appearance.Options.UseFont = true;
            this.lbl_RestoreName.Name = "lbl_RestoreName";
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
            // btn_RestoreFile
            // 
            resources.ApplyResources(this.btn_RestoreFile, "btn_RestoreFile");
            this.btn_RestoreFile.Name = "btn_RestoreFile";
            this.btn_RestoreFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_RestoreFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_BackupFile_ButtonClick);
            // 
            // xtraOpenFileDialog
            // 
            resources.ApplyResources(this.xtraOpenFileDialog, "xtraOpenFileDialog");
            // 
            // frm_Restore
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_RestoreFile);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.lbl_RestoreName);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_Restore.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Restore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RestoreFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Restore;
        private DevExpress.XtraEditors.LabelControl lbl_RestoreName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ButtonEdit btn_RestoreFile;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
    }
}