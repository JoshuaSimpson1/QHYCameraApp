using System.Collections.ObjectModel;
using System.Text;

namespace QHYApp
{
    public partial class MainForm : Form
    {
        Collection<Camera> cameras;
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
            if (result != (int)RESULT.QHYCCD_SUCCESS)
            {
                throw new Exception("QHY Resource Init Failed");
            }
        }

        private void scanCameras_Click(object sender, EventArgs e)
        {
            cameras = new Collection<Camera>();
            statusLabel.Text = "Connecting Starting";
            UInt32 numberOfCameras = QHYLib.ScanQHYCCD();
            statusLabel.Text = "Found " + numberOfCameras + " cameras";

            for (int i = 0; i < numberOfCameras; i++)
            {
                StringBuilder cameraId = new StringBuilder();
                QHYLib.GetGHYCCDId(i, cameraId);

                cameras.Add(new Camera(i, cameraId));

            }
        }
    }
}