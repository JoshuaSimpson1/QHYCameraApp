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
    public partial class LiveViewForm : Form
    {
        StringBuilder cameraId;
        int cameraIndex;

        public LiveViewForm(StringBuilder cameraId, int cameraIndex)
        {
            InitializeComponent();
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
        }

        private void LiveViewForm_Close(object sender, FormClosedEventArgs e)
        {
            CameraCollection.cameras[cameraIndex].hasLiveViewOpen = false;
        }

        private void triggerModeButton_Click(object sender, EventArgs e)
        {
            if (QHYLib.IsQHYCCDControlAvailable(CameraCollection.cameras[cameraIndex].cameraHandle, CONTROL_ID.CAM_TRIGER_INTERFACE) == (int)RESULT.QHYCCD_SUCCESS)
            {
                CameraCollection.cameras[cameraIndex].setTriggerMode(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
