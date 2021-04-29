using DevExpress.XtraWaitForm;

namespace MyAccounts.Forms.Commons
{
    public partial class Processing : WaitForm
    {
        public static string Descriptions = string.Empty;

        public Processing()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            this.SetDescriptions(Descriptions);
        }

        public void SetDescriptions(string description)
        {
            this.progressPanel1.Description = description;
        }
    }
}