
namespace MyAccounts.Forms
{
    partial class frm_SystemInitialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SystemInitialization));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ServerUser = new DevExpress.XtraEditors.LabelControl();
            this.txt_ServerUser = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ServerPassword = new DevExpress.XtraEditors.LabelControl();
            this.txt_ServerPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_UserLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.lk_Authentication = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Authentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 67);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(281, 232);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(292, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server Name";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ServerName.Location = new System.Drawing.Point(292, 31);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(308, 20);
            this.txt_ServerName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(292, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Authentication";
            // 
            // lbl_ServerUser
            // 
            this.lbl_ServerUser.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerUser.Appearance.Options.UseFont = true;
            this.lbl_ServerUser.Location = new System.Drawing.Point(292, 102);
            this.lbl_ServerUser.Name = "lbl_ServerUser";
            this.lbl_ServerUser.Size = new System.Drawing.Size(67, 13);
            this.lbl_ServerUser.TabIndex = 0;
            this.lbl_ServerUser.Text = "Server User";
            // 
            // txt_ServerUser
            // 
            this.txt_ServerUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ServerUser.Location = new System.Drawing.Point(292, 121);
            this.txt_ServerUser.Name = "txt_ServerUser";
            this.txt_ServerUser.Size = new System.Drawing.Size(308, 20);
            this.txt_ServerUser.TabIndex = 3;
            // 
            // lbl_ServerPassword
            // 
            this.lbl_ServerPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerPassword.Appearance.Options.UseFont = true;
            this.lbl_ServerPassword.Location = new System.Drawing.Point(292, 147);
            this.lbl_ServerPassword.Name = "lbl_ServerPassword";
            this.lbl_ServerPassword.Size = new System.Drawing.Size(95, 13);
            this.lbl_ServerPassword.TabIndex = 0;
            this.lbl_ServerPassword.Text = "Server Password";
            // 
            // txt_ServerPassword
            // 
            this.txt_ServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ServerPassword.Location = new System.Drawing.Point(292, 166);
            this.txt_ServerPassword.Name = "txt_ServerPassword";
            this.txt_ServerPassword.Properties.UseSystemPasswordChar = true;
            this.txt_ServerPassword.Size = new System.Drawing.Size(308, 20);
            this.txt_ServerPassword.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(292, 281);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "User Login";
            // 
            // txt_UserLogin
            // 
            this.txt_UserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserLogin.Location = new System.Drawing.Point(292, 300);
            this.txt_UserLogin.Name = "txt_UserLogin";
            this.txt_UserLogin.Size = new System.Drawing.Size(308, 20);
            this.txt_UserLogin.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(292, 326);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Location = new System.Drawing.Point(292, 345);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.UseSystemPasswordChar = true;
            this.txt_Password.Size = new System.Drawing.Size(308, 20);
            this.txt_Password.TabIndex = 8;
            // 
            // btn_OK
            // 
            this.btn_OK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OK.ImageOptions.Image")));
            this.btn_OK.Location = new System.Drawing.Point(447, 371);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(525, 371);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lk_Authentication
            // 
            this.lk_Authentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lk_Authentication.Location = new System.Drawing.Point(292, 76);
            this.lk_Authentication.Name = "lk_Authentication";
            this.lk_Authentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_Authentication.Properties.DisplayMember = "Value";
            this.lk_Authentication.Properties.NullText = "Select Authentication";
            this.lk_Authentication.Properties.ValueMember = "Key";
            this.lk_Authentication.Size = new System.Drawing.Size(308, 20);
            this.lk_Authentication.TabIndex = 2;
            this.lk_Authentication.EditValueChanged += new System.EventHandler(this.lk_Authentication_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(292, 192);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "First Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(292, 237);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FirstName.Location = new System.Drawing.Point(292, 211);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(308, 20);
            this.txt_FirstName.TabIndex = 5;
            this.txt_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FirstName_KeyPress);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LastName.Location = new System.Drawing.Point(292, 256);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(308, 20);
            this.txt_LastName.TabIndex = 6;
            this.txt_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LastName_KeyPress);
            // 
            // frm_SystemInitialization
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.lk_Authentication);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.txt_UserLogin);
            this.Controls.Add(this.txt_ServerPassword);
            this.Controls.Add(this.txt_ServerUser);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lbl_ServerPassword);
            this.Controls.Add(this.lbl_ServerUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_SystemInitialization.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frm_SystemInitialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Initialization";
            this.Load += new System.EventHandler(this.frm_SystemInitialization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Authentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_ServerName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_ServerUser;
        private DevExpress.XtraEditors.TextEdit txt_ServerUser;
        private DevExpress.XtraEditors.LabelControl lbl_ServerPassword;
        private DevExpress.XtraEditors.TextEdit txt_ServerPassword;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_UserLogin;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.LookUpEdit lk_Authentication;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
    }
}