
namespace MyAccounts.Forms
{
    partial class frm_ChooseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChooseConfig));
            this.btn_CreateSystem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RestoreSystem = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_CreateSystem
            // 
            this.btn_CreateSystem.AllowFocus = false;
            this.btn_CreateSystem.AutoSize = true;
            this.btn_CreateSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateSystem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_CreateSystem.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.btn_CreateSystem.ImageOptions.SvgImageSize = new System.Drawing.Size(155, 139);
            this.btn_CreateSystem.Location = new System.Drawing.Point(12, 9);
            this.btn_CreateSystem.Name = "btn_CreateSystem";
            this.btn_CreateSystem.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_CreateSystem.Size = new System.Drawing.Size(161, 143);
            this.btn_CreateSystem.TabIndex = 0;
            this.btn_CreateSystem.ToolTip = "Create new system";
            this.btn_CreateSystem.Click += new System.EventHandler(this.btn_CreateSystem_Click);
            // 
            // btn_RestoreSystem
            // 
            this.btn_RestoreSystem.AllowFocus = false;
            this.btn_RestoreSystem.AutoSize = true;
            this.btn_RestoreSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RestoreSystem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btn_RestoreSystem.ImageOptions.SvgImageSize = new System.Drawing.Size(155, 139);
            this.btn_RestoreSystem.Location = new System.Drawing.Point(179, 9);
            this.btn_RestoreSystem.Name = "btn_RestoreSystem";
            this.btn_RestoreSystem.Size = new System.Drawing.Size(161, 143);
            this.btn_RestoreSystem.TabIndex = 0;
            this.btn_RestoreSystem.ToolTip = "Restore system";
            this.btn_RestoreSystem.Click += new System.EventHandler(this.btn_RestoreSystem_Click);
            // 
            // frm_ChooseConfig
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 162);
            this.Controls.Add(this.btn_RestoreSystem);
            this.Controls.Add(this.btn_CreateSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChooseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_CreateSystem;
        private DevExpress.XtraEditors.SimpleButton btn_RestoreSystem;
    }
}