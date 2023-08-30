using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QHYApp
{
    public partial class CameraControl : UserControl
    {
        StringBuilder cameraId;
        int cameraIndex;
        public CameraControl(StringBuilder cameraId, int cameraIndex)
        {
            InitializeComponent();
            this.cameraId = cameraId;
            this.Dock = DockStyle.Fill;
            this.cameraIndex = cameraIndex;
        }

        private void CameraControl_Load(object sender, EventArgs e)
        {
            this.cameraIdLabel.Text = cameraId.ToString();
        }

        private void cameraProperties_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            if (mainForm != null)
            {
                if (!mainForm.cameras[cameraIndex].hasPropertiesViewOpen)
                {
                    CameraPropertiesForm propertiesViewForm = new CameraPropertiesForm(cameraId, cameraIndex);
                    propertiesViewForm.Show();
                    mainForm.cameras[cameraIndex].hasPropertiesViewOpen = true;
                }
            }
        }

        private void liveViewButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            if (mainForm != null)
            {
                if (!mainForm.cameras[cameraIndex].hasLiveViewOpen)
                {
                    LiveViewForm liveViewForm = new LiveViewForm(cameraId, cameraIndex);
                    liveViewForm.Show();
                    mainForm.cameras[cameraIndex].hasLiveViewOpen = true;
                }
            }
        }

    }
}
