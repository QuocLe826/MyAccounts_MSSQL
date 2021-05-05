
namespace MyAccounts.Forms.Categories
{
    partial class frm_AccountType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AccountType));
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_Status = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gc_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_AccountType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_AccountType = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_AddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lk_Status = new DevExpress.XtraEditors.LookUpEdit();
            this.lbl_Desc = new DevExpress.XtraEditors.LabelControl();
            this.txt_Code = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Status = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Name = new DevExpress.XtraEditors.LabelControl();
            this.txt_Desc = new DevExpress.XtraEditors.TextEdit();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Code = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rep_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Desc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(574, 40);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gc_Desc
            // 
            this.gc_Desc.Caption = "Descriptions";
            this.gc_Desc.FieldName = "Descriptions";
            this.gc_Desc.Name = "gc_Desc";
            this.gc_Desc.Visible = true;
            this.gc_Desc.VisibleIndex = 3;
            // 
            // gc_Status
            // 
            this.gc_Status.Caption = "Status";
            this.gc_Status.ColumnEdit = this.rep_Status;
            this.gc_Status.FieldName = "Status";
            this.gc_Status.Name = "gc_Status";
            this.gc_Status.Visible = true;
            this.gc_Status.VisibleIndex = 2;
            // 
            // rep_Status
            // 
            this.rep_Status.AutoHeight = false;
            this.rep_Status.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rep_Status.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_Status.DisplayMember = "Value";
            this.rep_Status.Name = "rep_Status";
            this.rep_Status.NullText = "";
            this.rep_Status.ShowHeader = false;
            this.rep_Status.ValueMember = "Key";
            // 
            // gc_Name
            // 
            this.gc_Name.Caption = "Name";
            this.gc_Name.FieldName = "Name";
            this.gc_Name.Name = "gc_Name";
            this.gc_Name.Visible = true;
            this.gc_Name.VisibleIndex = 1;
            // 
            // gc_Code
            // 
            this.gc_Code.Caption = "Code";
            this.gc_Code.FieldName = "Code";
            this.gc_Code.Name = "gc_Code";
            this.gc_Code.Visible = true;
            this.gc_Code.VisibleIndex = 0;
            // 
            // gv_AccountType
            // 
            this.gv_AccountType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Code,
            this.gc_Name,
            this.gc_Status,
            this.gc_Desc});
            this.gv_AccountType.GridControl = this.grd_AccountType;
            this.gv_AccountType.IndicatorWidth = 30;
            this.gv_AccountType.Name = "gv_AccountType";
            this.gv_AccountType.OptionsBehavior.Editable = false;
            this.gv_AccountType.OptionsView.ShowGroupPanel = false;
            this.gv_AccountType.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gv_AccountType_FocusedRowObjectChanged);
            // 
            // grd_AccountType
            // 
            this.grd_AccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_AccountType.Location = new System.Drawing.Point(3, 92);
            this.grd_AccountType.MainView = this.gv_AccountType;
            this.grd_AccountType.MenuManager = this.barManager1;
            this.grd_AccountType.Name = "grd_AccountType";
            this.grd_AccountType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_Status});
            this.grd_AccountType.Size = new System.Drawing.Size(808, 374);
            this.grd_AccountType.TabIndex = 6;
            this.grd_AccountType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AccountType});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Save,
            this.btn_Cancel,
            this.btn_Delete,
            this.btn_Refresh});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_AddNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Edit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Save, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Cancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Delete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Refresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
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
            // btn_Save
            // 
            this.btn_Save.Caption = "Save";
            this.btn_Save.Id = 2;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Caption = "Cancel";
            this.btn_Cancel.Id = 3;
            this.btn_Cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Cancel.ImageOptions.SvgImage")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(817, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 470);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(817, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(817, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // lk_Status
            // 
            this.lk_Status.Location = new System.Drawing.Point(51, 66);
            this.lk_Status.MenuManager = this.barManager1;
            this.lk_Status.Name = "lk_Status";
            this.lk_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_Status.Properties.DisplayMember = "Value";
            this.lk_Status.Properties.NullText = "";
            this.lk_Status.Properties.ValueMember = "Key";
            this.lk_Status.Size = new System.Drawing.Size(203, 20);
            this.lk_Status.TabIndex = 3;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.Location = new System.Drawing.Point(296, 69);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(58, 13);
            this.lbl_Desc.TabIndex = 7;
            this.lbl_Desc.Text = "Descriptions";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(51, 40);
            this.txt_Code.MenuManager = this.barManager1;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Properties.MaxLength = 20;
            this.txt_Code.Size = new System.Drawing.Size(203, 20);
            this.txt_Code.TabIndex = 1;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Location = new System.Drawing.Point(11, 69);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(31, 13);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(296, 43);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(27, 13);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(365, 66);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Properties.MaxLength = 2000;
            this.txt_Desc.Size = new System.Drawing.Size(203, 20);
            this.txt_Desc.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(365, 40);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 254;
            this.txt_Name.Size = new System.Drawing.Size(203, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // lbl_Code
            // 
            this.lbl_Code.Location = new System.Drawing.Point(11, 43);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(25, 13);
            this.lbl_Code.TabIndex = 10;
            this.lbl_Code.Text = "Code";
            // 
            // frm_AccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 470);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lk_Status);
            this.Controls.Add(this.grd_AccountType);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_AccountType";
            this.Text = "Account Type";
            this.Load += new System.EventHandler(this.frm_AccountType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rep_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Desc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Status;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Code;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AccountType;
        private DevExpress.XtraGrid.GridControl grd_AccountType;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_AddNew;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LookUpEdit lk_Status;
        private DevExpress.XtraEditors.LabelControl lbl_Desc;
        private DevExpress.XtraEditors.TextEdit txt_Code;
        private DevExpress.XtraEditors.LabelControl lbl_Status;
        private DevExpress.XtraEditors.LabelControl lbl_Name;
        private DevExpress.XtraEditors.TextEdit txt_Desc;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl lbl_Code;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep_Status;
    }
}