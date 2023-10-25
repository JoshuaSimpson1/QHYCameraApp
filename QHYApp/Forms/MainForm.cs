using System.Collections.ObjectModel;
using System.Text;

namespace QHYApp
{
    public partial class MainForm : Form
    {
        UInt32 numberCameras;

        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_Close;
            this.numberCameras = 0;
        }

        // When the main form is closed make sure to close the resources to the QHY Resources.
        private void MainForm_Close(object? sender, FormClosingEventArgs e)
        {
            QHYLib.ReleaseQHYCCDResource();
        }

        // Called when the form is loaded
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
            CameraCollection.cameras.Clear();
            numberCameras = QHYLib.ScanQHYCCD();
            this.Text = "QHY Camera App - Found " + numberCameras + " cameras";

            for (int i = 0; i < numberCameras; i++)
            {
                StringBuilder cameraId = new StringBuilder();
                QHYLib.GetGHYCCDId(i, cameraId);

                CameraCollection.cameras.Add(new Camera(i, cameraId));
            }
        }

        // Refreshes the camera list and update the ui
        private void refreshCamerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scanAvailableCameras();
            camerasPanel.Controls.Clear();
            fillPanelWithFoundCameras();
        }

        // Adds all found cameras to the UI
        private void fillPanelWithFoundCameras()
        {
            foreach (Camera camera in CameraCollection.cameras)
            {
                CameraControl cameraControl = new CameraControl(camera.cameraId, camera.cameraIndex);
                camerasPanel.Controls.Add(cameraControl);
            }
        }

        // Closes the program
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}