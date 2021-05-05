
namespace MyAccounts.Forms.Categories
{
    partial class frm_AddUpdateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddUpdateAccount));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lbl_Code = new DevExpress.XtraEditors.LabelControl();
            this.txt_Code = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Name = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Username = new DevExpress.XtraEditors.LabelControl();
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Password = new DevExpress.XtraEditors.LabelControl();
            this.lbl_AccGroup = new DevExpress.XtraEditors.LabelControl();
            this.lk_AccountGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_AccType = new DevExpress.XtraEditors.LabelControl();
            this.lk_AccountType = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_Status = new DevExpress.XtraEditors.LabelControl();
            this.lk_Status = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_Desc = new DevExpress.XtraEditors.LabelControl();
            this.mno_Desc = new DevExpress.XtraEditors.MemoEdit();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Password = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mno_Desc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Code
            // 
            this.lbl_Code.Location = new System.Drawing.Point(12, 12);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(25, 13);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = "Code";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(89, 9);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Properties.MaxLength = 20;
            this.txt_Code.Size = new System.Drawing.Size(269, 20);
            this.txt_Code.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(12, 38);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(27, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(89, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 254;
            this.txt_Name.Size = new System.Drawing.Size(269, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(12, 64);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(48, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(89, 61);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Properties.MaxLength = 150;
            this.txt_Username.Size = new System.Drawing.Size(269, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(12, 90);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(46, 13);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_AccGroup
            // 
            this.lbl_AccGroup.Location = new System.Drawing.Point(12, 116);
            this.lbl_AccGroup.Name = "lbl_AccGroup";
            this.lbl_AccGroup.Size = new System.Drawing.Size(71, 13);
            this.lbl_AccGroup.TabIndex = 0;
            this.lbl_AccGroup.Text = "Account Group";
            // 
            // lk_AccountGroup
            // 
            this.lk_AccountGroup.Location = new System.Drawing.Point(89, 113);
            this.lk_AccountGroup.Name = "lk_AccountGroup";
            this.lk_AccountGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_AccountGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lk_AccountGroup.Properties.DisplayMember = "Name";
            this.lk_AccountGroup.Properties.KeyMember = "Code";
            this.lk_AccountGroup.Properties.NullText = "";
            this.lk_AccountGroup.Properties.ShowHeader = false;
            this.lk_AccountGroup.Properties.ValueMember = "Code";
            this.lk_AccountGroup.Size = new System.Drawing.Size(269, 20);
            this.lk_AccountGroup.TabIndex = 5;
            // 
            // lbl_AccType
            // 
            this.lbl_AccType.Location = new System.Drawing.Point(12, 142);
            this.lbl_AccType.Name = "lbl_AccType";
            this.lbl_AccType.Size = new System.Drawing.Size(66, 13);
            this.lbl_AccType.TabIndex = 0;
            this.lbl_AccType.Text = "Account Type";
            // 
            // lk_AccountType
            // 
            this.lk_AccountType.Location = new System.Drawing.Point(89, 139);
            this.lk_AccountType.Name = "lk_AccountType";
            this.lk_AccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_AccountType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lk_AccountType.Properties.DisplayMember = "Name";
            this.lk_AccountType.Properties.KeyMember = "Code";
            this.lk_AccountType.Properties.NullText = "";
            this.lk_AccountType.Properties.ShowHeader = false;
            this.lk_AccountType.Properties.ValueMember = "Code";
            this.lk_AccountType.Size = new System.Drawing.Size(269, 20);
            this.lk_AccountType.TabIndex = 6;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Location = new System.Drawing.Point(12, 168);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(31, 13);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // lk_Status
            // 
            this.lk_Status.Location = new System.Drawing.Point(89, 165);
            this.lk_Status.Name = "lk_Status";
            this.lk_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_Status.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Name")});
            this.lk_Status.Properties.DisplayMember = "Value";
            this.lk_Status.Properties.KeyMember = "Code";
            this.lk_Status.Properties.NullText = "";
            this.lk_Status.Properties.ShowHeader = false;
            this.lk_Status.Properties.ValueMember = "Key";
            this.lk_Status.Size = new System.Drawing.Size(269, 20);
            this.lk_Status.TabIndex = 7;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.Location = new System.Drawing.Point(12, 196);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(58, 13);
            this.lbl_Desc.TabIndex = 0;
            this.lbl_Desc.Text = "Descriptions";
            // 
            // mno_Desc
            // 
            this.mno_Desc.Location = new System.Drawing.Point(89, 191);
            this.mno_Desc.Name = "mno_Desc";
            this.mno_Desc.Properties.MaxLength = 2000;
            this.mno_Desc.Size = new System.Drawing.Size(269, 134);
            this.mno_Desc.TabIndex = 8;
            // 
            // btn_OK
            // 
            this.btn_OK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OK.ImageOptions.Image")));
            this.btn_OK.Location = new System.Drawing.Point(205, 331);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(283, 331);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(89, 87);
            this.txt_Password.Name = "txt_Password";
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            this.txt_Password.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Show Password", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txt_Password.Properties.UseSystemPasswordChar = true;
            this.txt_Password.Size = new System.Drawing.Size(268, 20);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_Password_ButtonClick);
            // 
            // frm_AddUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(369, 363);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.mno_Desc);
            this.Controls.Add(this.lk_Status);
            this.Controls.Add(this.lk_AccountType);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lk_AccountGroup);
            this.Controls.Add(this.lbl_AccType);
            this.Controls.Add(this.lbl_AccGroup);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.lbl_Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_AddUpdateAccount.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddUpdateAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Account";
            this.Load += new System.EventHandler(this.frm_AddNewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mno_Desc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Code;
        private DevExpress.XtraEditors.TextEdit txt_Code;
        private DevExpress.XtraEditors.LabelControl lbl_Name;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl lbl_Username;
        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.LabelControl lbl_Password;
        private DevExpress.XtraEditors.LabelControl lbl_AccGroup;
        private DevExpress.XtraEditors.LookUpEdit lk_AccountGroup;
        private DevExpress.XtraEditors.LabelControl lbl_AccType;
        private DevExpress.XtraEditors.LookUpEdit lk_AccountType;
        private DevExpress.XtraEditors.LabelControl lbl_Status;
        private DevExpress.XtraEditors.LookUpEdit lk_Status;
        private DevExpress.XtraEditors.LabelControl lbl_Desc;
        private DevExpress.XtraEditors.MemoEdit mno_Desc;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.ButtonEdit txt_Password;
    }
}