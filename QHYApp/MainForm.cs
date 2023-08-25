namespace QHYApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_Close;
        }

        private void MainForm_Close(object? sender, FormClosingEventArgs e)
        {
            QHYLib.ReleaseQHYCCDResource();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UInt32 result = QHYLib.InitQHYCCDResource();
            if (result == (int)RESULT.QHYCCD_SUCCESS)
            {
                resourcesInitLabel.Text = "Resources Init Success";
            }
            else
            {
                resourcesInitLabel.Text = "Resource Init Failure";
            }
        }

        private void scanCameras_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Connecting Starting";
            UInt32 result = QHYLib.ScanQHYCCD();
            statusLabel.Text = "Found " + result + " cameras";
        }
    }
}