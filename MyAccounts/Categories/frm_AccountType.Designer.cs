
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
            resources.ApplyResources(this.btn_Search, "btn_Search");
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gc_Desc
            // 
            resources.ApplyResources(this.gc_Desc, "gc_Desc");
            this.gc_Desc.FieldName = "Descriptions";
            this.gc_Desc.Name = "gc_Desc";
            this.gc_Desc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gc_Status
            // 
            resources.ApplyResources(this.gc_Status, "gc_Status");
            this.gc_Status.ColumnEdit = this.rep_Status;
            this.gc_Status.FieldName = "Status";
            this.gc_Status.Name = "gc_Status";
            this.gc_Status.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // rep_Status
            // 
            resources.ApplyResources(this.rep_Status, "rep_Status");
            this.rep_Status.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rep_Status.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("rep_Status.Buttons"))))});
            this.rep_Status.DisplayMember = "Value";
            this.rep_Status.Name = "rep_Status";
            this.rep_Status.ShowHeader = false;
            this.rep_Status.ValueMember = "Key";
            // 
            // gc_Name
            // 
            resources.ApplyResources(this.gc_Name, "gc_Name");
            this.gc_Name.FieldName = "Name";
            this.gc_Name.Name = "gc_Name";
            this.gc_Name.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gc_Code
            // 
            resources.ApplyResources(this.gc_Code, "gc_Code");
            this.gc_Code.FieldName = "Code";
            this.gc_Code.Name = "gc_Code";
            this.gc_Code.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gv_AccountType
            // 
            resources.ApplyResources(this.gv_AccountType, "gv_AccountType");
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
            resources.ApplyResources(this.grd_AccountType, "grd_AccountType");
            this.grd_AccountType.EmbeddedNavigator.AccessibleDescription = resources.GetString("grd_AccountType.EmbeddedNavigator.AccessibleDescription");
            this.grd_AccountType.EmbeddedNavigator.AccessibleName = resources.GetString("grd_AccountType.EmbeddedNavigator.AccessibleName");
            this.grd_AccountType.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("grd_AccountType.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.grd_AccountType.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("grd_AccountType.EmbeddedNavigator.Anchor")));
            this.grd_AccountType.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grd_AccountType.EmbeddedNavigator.BackgroundImage")));
            this.grd_AccountType.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("grd_AccountType.EmbeddedNavigator.BackgroundImageLayout")));
            this.grd_AccountType.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("grd_AccountType.EmbeddedNavigator.ImeMode")));
            this.grd_AccountType.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("grd_AccountType.EmbeddedNavigator.MaximumSize")));
            this.grd_AccountType.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("grd_AccountType.EmbeddedNavigator.TextLocation")));
            this.grd_AccountType.EmbeddedNavigator.ToolTip = resources.GetString("grd_AccountType.EmbeddedNavigator.ToolTip");
            this.grd_AccountType.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("grd_AccountType.EmbeddedNavigator.ToolTipIconType")));
            this.grd_AccountType.EmbeddedNavigator.ToolTipTitle = resources.GetString("grd_AccountType.EmbeddedNavigator.ToolTipTitle");
            this.grd_AccountType.MainView = this.gv_AccountType;
            this.grd_AccountType.MenuManager = this.barManager1;
            this.grd_AccountType.Name = "grd_AccountType";
            this.grd_AccountType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_Status});
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
            resources.ApplyResources(this.bar1, "bar1");
            // 
            // btn_AddNew
            // 
            resources.ApplyResources(this.btn_AddNew, "btn_AddNew");
            this.btn_AddNew.Id = 0;
            this.btn_AddNew.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_AddNew.ImageOptions.ImageIndex")));
            this.btn_AddNew.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_AddNew.ImageOptions.LargeImageIndex")));
            this.btn_AddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddNew.ImageOptions.SvgImage")));
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddNew_ItemClick);
            // 
            // btn_Edit
            // 
            resources.ApplyResources(this.btn_Edit, "btn_Edit");
            this.btn_Edit.Id = 1;
            this.btn_Edit.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Edit.ImageOptions.ImageIndex")));
            this.btn_Edit.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Edit.ImageOptions.LargeImageIndex")));
            this.btn_Edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Edit.ImageOptions.SvgImage")));
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Edit_ItemClick);
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Id = 2;
            this.btn_Save.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Save.ImageOptions.ImageIndex")));
            this.btn_Save.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Save.ImageOptions.LargeImageIndex")));
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.Id = 3;
            this.btn_Cancel.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Cancel.ImageOptions.ImageIndex")));
            this.btn_Cancel.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Cancel.ImageOptions.LargeImageIndex")));
            this.btn_Cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Cancel.ImageOptions.SvgImage")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // btn_Delete
            // 
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.Id = 4;
            this.btn_Delete.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Delete.ImageOptions.ImageIndex")));
            this.btn_Delete.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Delete.ImageOptions.LargeImageIndex")));
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Refresh
            // 
            resources.ApplyResources(this.btn_Refresh, "btn_Refresh");
            this.btn_Refresh.Id = 5;
            this.btn_Refresh.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Refresh.ImageOptions.ImageIndex")));
            this.btn_Refresh.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Refresh.ImageOptions.LargeImageIndex")));
            this.btn_Refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Refresh.ImageOptions.SvgImage")));
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Refresh_ItemClick);
            // 
            // barDockControlTop
            // 
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // lk_Status
            // 
            resources.ApplyResources(this.lk_Status, "lk_Status");
            this.lk_Status.MenuManager = this.barManager1;
            this.lk_Status.Name = "lk_Status";
            this.lk_Status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lk_Status.Properties.Buttons"))))});
            this.lk_Status.Properties.DisplayMember = "Value";
            this.lk_Status.Properties.NullText = resources.GetString("lk_Status.Properties.NullText");
            this.lk_Status.Properties.ValueMember = "Key";
            // 
            // lbl_Desc
            // 
            resources.ApplyResources(this.lbl_Desc, "lbl_Desc");
            this.lbl_Desc.Name = "lbl_Desc";
            // 
            // txt_Code
            // 
            resources.ApplyResources(this.txt_Code, "txt_Code");
            this.txt_Code.MenuManager = this.barManager1;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Properties.MaxLength = 20;
            // 
            // lbl_Status
            // 
            resources.ApplyResources(this.lbl_Status, "lbl_Status");
            this.lbl_Status.Name = "lbl_Status";
            // 
            // lbl_Name
            // 
            resources.ApplyResources(this.lbl_Name, "lbl_Name");
            this.lbl_Name.Name = "lbl_Name";
            // 
            // txt_Desc
            // 
            resources.ApplyResources(this.txt_Desc, "txt_Desc");
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Properties.MaxLength = 2000;
            // 
            // txt_Name
            // 
            resources.ApplyResources(this.txt_Name, "txt_Name");
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 254;
            // 
            // lbl_Code
            // 
            resources.ApplyResources(this.lbl_Code, "lbl_Code");
            this.lbl_Code.Name = "lbl_Code";
            // 
            // frm_AccountType
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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