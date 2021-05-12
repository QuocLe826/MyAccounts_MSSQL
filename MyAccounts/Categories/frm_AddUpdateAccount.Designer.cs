
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
            this.components = new System.ComponentModel.Container();
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
            this.svgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mno_Desc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Code
            // 
            resources.ApplyResources(this.lbl_Code, "lbl_Code");
            this.lbl_Code.Name = "lbl_Code";
            // 
            // txt_Code
            // 
            resources.ApplyResources(this.txt_Code, "txt_Code");
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Properties.MaxLength = 20;
            // 
            // lbl_Name
            // 
            resources.ApplyResources(this.lbl_Name, "lbl_Name");
            this.lbl_Name.Name = "lbl_Name";
            // 
            // txt_Name
            // 
            resources.ApplyResources(this.txt_Name, "txt_Name");
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 254;
            // 
            // lbl_Username
            // 
            resources.ApplyResources(this.lbl_Username, "lbl_Username");
            this.lbl_Username.Name = "lbl_Username";
            // 
            // txt_Username
            // 
            resources.ApplyResources(this.txt_Username, "txt_Username");
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Properties.MaxLength = 150;
            // 
            // lbl_Password
            // 
            resources.ApplyResources(this.lbl_Password, "lbl_Password");
            this.lbl_Password.Name = "lbl_Password";
            // 
            // lbl_AccGroup
            // 
            resources.ApplyResources(this.lbl_AccGroup, "lbl_AccGroup");
            this.lbl_AccGroup.Name = "lbl_AccGroup";
            // 
            // lk_AccountGroup
            // 
            resources.ApplyResources(this.lk_AccountGroup, "lk_AccountGroup");
            this.lk_AccountGroup.Name = "lk_AccountGroup";
            this.lk_AccountGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lk_AccountGroup.Properties.Buttons"))))});
            this.lk_AccountGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lk_AccountGroup.Properties.Columns"), resources.GetString("lk_AccountGroup.Properties.Columns1"))});
            this.lk_AccountGroup.Properties.DisplayMember = "Name";
            this.lk_AccountGroup.Properties.KeyMember = "Code";
            this.lk_AccountGroup.Properties.NullText = resources.GetString("lk_AccountGroup.Properties.NullText");
            this.lk_AccountGroup.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lk_AccountGroup.Properties.ShowHeader = false;
            this.lk_AccountGroup.Properties.ValueMember = "Code";
            // 
            // lbl_AccType
            // 
            resources.ApplyResources(this.lbl_AccType, "lbl_AccType");
            this.lbl_AccType.Name = "lbl_AccType";
            // 
            // lk_AccountType
            // 
            resources.ApplyResources(this.lk_AccountType, "lk_AccountType");
            this.lk_AccountType.Name = "lk_AccountType";
            this.lk_AccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lk_AccountType.Properties.Buttons"))))});
            this.lk_AccountType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lk_AccountType.Properties.Columns"), resources.GetString("lk_AccountType.Properties.Columns1"))});
            this.lk_AccountType.Properties.DisplayMember = "Name";
            this.lk_AccountType.Properties.KeyMember = "Code";
            this.lk_AccountType.Properties.NullText = resources.GetString("lk_AccountType.Properties.NullText");
            this.lk_AccountType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lk_AccountType.Properties.ShowHeader = false;
            this.lk_AccountType.Properties.ValueMember = "Code";
            // 
            // lbl_Status
            // 
            resources.ApplyResources(this.lbl_Status, "lbl_Status");
            this.lbl_Status.Name = "lbl_Status";
            // 
            // lk_Status
            // 
            resources.ApplyResources(this.lk_Status, "lk_Status");
            this.lk_Status.Name = "lk_Status";
            this.lk_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lk_Status.Properties.Buttons"))))});
            this.lk_Status.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lk_Status.Properties.Columns"), resources.GetString("lk_Status.Properties.Columns1"))});
            this.lk_Status.Properties.DisplayMember = "Value";
            this.lk_Status.Properties.KeyMember = "Code";
            this.lk_Status.Properties.NullText = resources.GetString("lk_Status.Properties.NullText");
            this.lk_Status.Properties.ShowHeader = false;
            this.lk_Status.Properties.ValueMember = "Key";
            // 
            // lbl_Desc
            // 
            resources.ApplyResources(this.lbl_Desc, "lbl_Desc");
            this.lbl_Desc.Name = "lbl_Desc";
            // 
            // mno_Desc
            // 
            resources.ApplyResources(this.mno_Desc, "mno_Desc");
            this.mno_Desc.Name = "mno_Desc";
            this.mno_Desc.Properties.MaxLength = 2000;
            // 
            // btn_OK
            // 
            this.btn_OK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OK.ImageOptions.Image")));
            resources.ApplyResources(this.btn_OK, "btn_OK");
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.Name = "txt_Password";
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            resources.ApplyResources(editorButtonImageOptions1, "editorButtonImageOptions1");
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            this.txt_Password.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txt_Password.Properties.Buttons"))), resources.GetString("txt_Password.Properties.Buttons1"), ((int)(resources.GetObject("txt_Password.Properties.Buttons2"))), ((bool)(resources.GetObject("txt_Password.Properties.Buttons3"))), ((bool)(resources.GetObject("txt_Password.Properties.Buttons4"))), ((bool)(resources.GetObject("txt_Password.Properties.Buttons5"))), editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, resources.GetString("txt_Password.Properties.Buttons6"), ((object)(resources.GetObject("txt_Password.Properties.Buttons7"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("txt_Password.Properties.Buttons8"))), ((DevExpress.Utils.ToolTipAnchor)(resources.GetObject("txt_Password.Properties.Buttons9"))))});
            this.txt_Password.Properties.UseSystemPasswordChar = true;
            this.txt_Password.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_Password_ButtonClick);
            // 
            // svgImageCollection
            // 
            this.svgImageCollection.Add("add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.add"))));
            this.svgImageCollection.Add("edit", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.edit"))));
            this.svgImageCollection.Add("hide", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.hide"))));
            this.svgImageCollection.Add("show", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.show"))));
            // 
            // frm_AddUpdateAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
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
            this.Load += new System.EventHandler(this.frm_AddNewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mno_Desc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).EndInit();
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
        private DevExpress.Utils.SvgImageCollection svgImageCollection;
    }
}