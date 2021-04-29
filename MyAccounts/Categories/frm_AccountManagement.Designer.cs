
namespace MyAccounts.Forms.Categories
{
    partial class frm_AccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AccountManagement));
            this.lbl_Username = new DevExpress.XtraEditors.LabelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btn_AddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ShowAccInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.lbl_AccGroups = new DevExpress.XtraEditors.LabelControl();
            this.lk_AccGroups = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lk_AccType = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.grd_AccManagement = new DevExpress.XtraGrid.GridControl();
            this.gv_AccManagement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_Password = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_Group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_Status = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gc_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccGroups.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AccManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AccManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(12, 45);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(48, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.DrawBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Refresh,
            this.btn_ShowAccInfo});
            this.barManager1.MaxItemId = 7;
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_AddNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Edit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Delete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Refresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_ShowAccInfo, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.DrawBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Tools";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Caption = "Add New";
            this.btn_AddNew.Id = 0;
            this.btn_AddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNew.ImageOptions.SvgImage")));
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNew_ItemClick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Caption = "Edit";
            this.btn_Edit.Id = 1;
            this.btn_Edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Edit.ImageOptions.SvgImage")));
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Edit_ItemClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Delete";
            this.btn_Delete.Id = 4;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Caption = "Refresh";
            this.btn_Refresh.Id = 5;
            this.btn_Refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Refresh.ImageOptions.SvgImage")));
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Refresh_ItemClick);
            // 
            // btn_ShowAccInfo
            // 
            this.btn_ShowAccInfo.Caption = "Show Account Info";
            this.btn_ShowAccInfo.Id = 6;
            this.btn_ShowAccInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowAccInfo.ImageOptions.Image")));
            this.btn_ShowAccInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowAccInfo.ImageOptions.LargeImage")));
            this.btn_ShowAccInfo.Name = "btn_ShowAccInfo";
            this.btn_ShowAccInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ShowAccInfo_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1014, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 578);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1014, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 550);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1014, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 550);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(66, 42);
            this.txt_Username.MenuManager = this.barManager1;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Properties.MaxLength = 150;
            this.txt_Username.Size = new System.Drawing.Size(196, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // lbl_AccGroups
            // 
            this.lbl_AccGroups.Location = new System.Drawing.Point(295, 45);
            this.lbl_AccGroups.Name = "lbl_AccGroups";
            this.lbl_AccGroups.Size = new System.Drawing.Size(71, 13);
            this.lbl_AccGroups.TabIndex = 0;
            this.lbl_AccGroups.Text = "Account Group";
            // 
            // lk_AccGroups
            // 
            this.lk_AccGroups.Location = new System.Drawing.Point(372, 42);
            this.lk_AccGroups.MenuManager = this.barManager1;
            this.lk_AccGroups.Name = "lk_AccGroups";
            this.lk_AccGroups.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.lk_AccGroups.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_AccGroups.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lk_AccGroups.Properties.DisplayMember = "Name";
            this.lk_AccGroups.Properties.NullText = "";
            this.lk_AccGroups.Properties.ShowHeader = false;
            this.lk_AccGroups.Properties.ValueMember = "Code";
            this.lk_AccGroups.Size = new System.Drawing.Size(175, 20);
            this.lk_AccGroups.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(564, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Account Type";
            // 
            // lk_AccType
            // 
            this.lk_AccType.Location = new System.Drawing.Point(641, 42);
            this.lk_AccType.Name = "lk_AccType";
            this.lk_AccType.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.lk_AccType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_AccType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lk_AccType.Properties.DisplayMember = "Name";
            this.lk_AccType.Properties.NullText = "";
            this.lk_AccType.Properties.ShowHeader = false;
            this.lk_AccType.Properties.ValueMember = "Code";
            this.lk_AccType.Size = new System.Drawing.Size(175, 20);
            this.lk_AccType.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(822, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grd_AccManagement
            // 
            this.grd_AccManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_AccManagement.Location = new System.Drawing.Point(3, 68);
            this.grd_AccManagement.MainView = this.gv_AccManagement;
            this.grd_AccManagement.MenuManager = this.barManager1;
            this.grd_AccManagement.Name = "grd_AccManagement";
            this.grd_AccManagement.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_Status,
            this.rep_Password});
            this.grd_AccManagement.Size = new System.Drawing.Size(1008, 506);
            this.grd_AccManagement.TabIndex = 5;
            this.grd_AccManagement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AccManagement});
            this.grd_AccManagement.DoubleClick += new System.EventHandler(this.grd_AccManagement_DoubleClick);
            // 
            // gv_AccManagement
            // 
            this.gv_AccManagement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Code,
            this.gc_Name,
            this.gc_Username,
            this.gc_Password,
            this.gc_Group,
            this.gc_Type,
            this.gc_Status,
            this.gc_Desc});
            this.gv_AccManagement.GridControl = this.grd_AccManagement;
            this.gv_AccManagement.Name = "gv_AccManagement";
            this.gv_AccManagement.OptionsBehavior.Editable = false;
            this.gv_AccManagement.OptionsView.ShowGroupPanel = false;
            // 
            // gc_Code
            // 
            this.gc_Code.Caption = "Code";
            this.gc_Code.FieldName = "Code";
            this.gc_Code.Name = "gc_Code";
            this.gc_Code.Visible = true;
            this.gc_Code.VisibleIndex = 0;
            // 
            // gc_Name
            // 
            this.gc_Name.Caption = "Name";
            this.gc_Name.FieldName = "Name";
            this.gc_Name.Name = "gc_Name";
            this.gc_Name.Visible = true;
            this.gc_Name.VisibleIndex = 1;
            // 
            // gc_Username
            // 
            this.gc_Username.Caption = "Username";
            this.gc_Username.FieldName = "Username";
            this.gc_Username.Name = "gc_Username";
            this.gc_Username.Visible = true;
            this.gc_Username.VisibleIndex = 2;
            // 
            // gc_Password
            // 
            this.gc_Password.Caption = "Password";
            this.gc_Password.ColumnEdit = this.rep_Password;
            this.gc_Password.FieldName = "Password";
            this.gc_Password.Name = "gc_Password";
            this.gc_Password.Visible = true;
            this.gc_Password.VisibleIndex = 3;
            // 
            // rep_Password
            // 
            this.rep_Password.AutoHeight = false;
            this.rep_Password.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rep_Password.Name = "rep_Password";
            this.rep_Password.UseSystemPasswordChar = true;
            // 
            // gc_Group
            // 
            this.gc_Group.Caption = "Group";
            this.gc_Group.FieldName = "AccGroupName";
            this.gc_Group.Name = "gc_Group";
            this.gc_Group.Visible = true;
            this.gc_Group.VisibleIndex = 4;
            // 
            // gc_Type
            // 
            this.gc_Type.Caption = "Type";
            this.gc_Type.FieldName = "AccTypeName";
            this.gc_Type.Name = "gc_Type";
            this.gc_Type.Visible = true;
            this.gc_Type.VisibleIndex = 5;
            // 
            // gc_Status
            // 
            this.gc_Status.Caption = "Status";
            this.gc_Status.ColumnEdit = this.rep_Status;
            this.gc_Status.FieldName = "Status";
            this.gc_Status.Name = "gc_Status";
            this.gc_Status.Visible = true;
            this.gc_Status.VisibleIndex = 6;
            // 
            // rep_Status
            // 
            this.rep_Status.AutoHeight = false;
            this.rep_Status.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_Status.DisplayMember = "Value";
            this.rep_Status.Name = "rep_Status";
            this.rep_Status.NullText = "";
            this.rep_Status.ShowHeader = false;
            this.rep_Status.ValueMember = "Key";
            // 
            // gc_Desc
            // 
            this.gc_Desc.Caption = "Descriptions";
            this.gc_Desc.FieldName = "Descriptions";
            this.gc_Desc.Name = "gc_Desc";
            this.gc_Desc.Visible = true;
            this.gc_Desc.VisibleIndex = 7;
            // 
            // frm_AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 578);
            this.Controls.Add(this.grd_AccManagement);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lk_AccType);
            this.Controls.Add(this.lk_AccGroups);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_AccGroups);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_AccountManagement";
            this.Text = "Account Management";
            this.Load += new System.EventHandler(this.frm_AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccGroups.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_AccType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AccManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AccManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Username;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btn_AddNew;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_AccManagement;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AccManagement;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Code;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Username;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Password;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Group;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Type;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Status;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Desc;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LookUpEdit lk_AccType;
        private DevExpress.XtraEditors.LookUpEdit lk_AccGroups;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.LabelControl lbl_AccGroups;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep_Status;
        private DevExpress.XtraBars.BarButtonItem btn_ShowAccInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rep_Password;
    }
}