
namespace MyAccounts.Forms
{
    partial class frm_SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SplashScreen));
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            resources.ApplyResources(this.progressBarControl, "progressBarControl");
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.LookAndFeel.SkinName = "Office 2013";
            this.progressBarControl.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl.Properties.MarqueeAnimationSpeed = 50;
            this.progressBarControl.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // peImage
            // 
            resources.ApplyResources(this.peImage, "peImage");
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            // 
            // frm_SplashScreen
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBarControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
    }
}
