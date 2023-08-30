using System.Collections.ObjectModel;
using System.Text;

namespace QHYApp
{
    public partial class MainForm : Form
    {
        public Collection<Camera> cameras;
        public Collection<CameraControl> controls;
        UInt32 numberCameras;

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_Close;
            this.numberCameras = 0;
            cameras = new Collection<Camera>();
        }

        // When the main form is closed make sure to close the resources to the QHY Resources.
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

            scanAvailableCameras();
            fillPanelWithFoundCameras();
        }

        // Looks for all availble cameras and rebuilds our camera collection.
        private void scanAvailableCameras()
        {
            cameras.Clear();
            this.Text = "QHY Camera App - Connecting Starting";
            numberCameras = QHYLib.ScanQHYCCD();
            this.Text = "QHY Camera App - Found " + numberCameras + " cameras";


            for (int i = 0; i < numberCameras; i++)
            {
                StringBuilder cameraId = new StringBuilder();
                QHYLib.GetGHYCCDId(i, cameraId);

                cameras.Add(new Camera(i, cameraId));
            }
        }

        // For menu bar at top.
        private void refreshCamerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scanAvailableCameras();
        }

        private void fillPanelWithFoundCameras()
        {
            foreach( Camera camera in cameras)
            {
                CameraControl cameraControl = new CameraControl(camera.cameraId, camera.cameraIndex);
                camerasPanel.Controls.Add(cameraControl);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}