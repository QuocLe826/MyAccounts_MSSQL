
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
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(186, 171);
            this.pictureEdit1.TabIndex = 0;
            // 
            // lbl_BackupName
            // 
            this.lbl_BackupName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BackupName.Appearance.Options.UseFont = true;
            this.lbl_BackupName.Location = new System.Drawing.Point(194, 66);
            this.lbl_BackupName.Name = "lbl_BackupName";
            this.lbl_BackupName.Size = new System.Drawing.Size(76, 13);
            this.lbl_BackupName.TabIndex = 0;
            this.lbl_BackupName.Text = "Backup Name";
            // 
            // txt_BackupName
            // 
            this.txt_BackupName.Location = new System.Drawing.Point(194, 85);
            this.txt_BackupName.Name = "txt_BackupName";
            this.txt_BackupName.Size = new System.Drawing.Size(281, 20);
            this.txt_BackupName.TabIndex = 1;
            // 
            // btn_Backup
            // 
            this.btn_Backup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Backup.ImageOptions.Image")));
            this.btn_Backup.Location = new System.Drawing.Point(322, 111);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(75, 23);
            this.btn_Backup.TabIndex = 2;
            this.btn_Backup.Text = "OK";
            this.btn_Backup.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(400, 111);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // xtraSaveFileDialog
            // 
            this.xtraSaveFileDialog.Filter = "Backup File|*.bak";
            // 
            // frm_Backup
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 176);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup Data";
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