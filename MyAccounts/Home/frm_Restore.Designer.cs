
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
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(401, 101);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.ImageOptions.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(323, 101);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(75, 23);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.Text = "OK";
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // lbl_RestoreName
            // 
            this.lbl_RestoreName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RestoreName.Appearance.Options.UseFont = true;
            this.lbl_RestoreName.Location = new System.Drawing.Point(195, 56);
            this.lbl_RestoreName.Name = "lbl_RestoreName";
            this.lbl_RestoreName.Size = new System.Drawing.Size(67, 13);
            this.lbl_RestoreName.TabIndex = 0;
            this.lbl_RestoreName.Text = "Restore File";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(186, 171);
            this.pictureEdit1.TabIndex = 0;
            // 
            // btn_RestoreFile
            // 
            this.btn_RestoreFile.Location = new System.Drawing.Point(195, 75);
            this.btn_RestoreFile.Name = "btn_RestoreFile";
            this.btn_RestoreFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_RestoreFile.Size = new System.Drawing.Size(281, 20);
            this.btn_RestoreFile.TabIndex = 1;
            this.btn_RestoreFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_BackupFile_ButtonClick);
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.Filter = "Backup File|*.bak";
            // 
            // frm_Restore
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 179);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restore Data";
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