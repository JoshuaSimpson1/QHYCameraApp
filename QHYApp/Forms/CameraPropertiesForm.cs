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
    public partial class CameraPropertiesForm : Form
    {
        StringBuilder cameraId;
        int cameraIndex;

        public CameraPropertiesForm(StringBuilder cameraId, int cameraIndex)
        {
            InitializeComponent();
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
        }

        private void CameraPropertiesForm_Closed(object sender, FormClosedEventArgs e)
        {
            CameraCollection.cameras[cameraIndex].hasPropertiesViewOpen = false;
        }

        // I will close the camera handles when the main form closes i think then.
        // Possible memory leak. Probably going to refactor the camera list to just be
        // a static list of cameras in a class.
        private void CameraPropertiesForm_Load(object sender, EventArgs e)
        {
            // Load ui and controls
            cameraIdLabel.Text = this.cameraId.ToString();

            foreach (var setting in Enum.GetValues<CONTROL_ID>())
            {
                if (QHYLib.IsQHYCCDControlAvailable(CameraCollection.cameras[cameraIndex].cameraHandle, setting) == (int)RESULT.QHYCCD_SUCCESS)
                {
                    PropertiesControl propertiesControl = new PropertiesControl(setting);
                    settingsPanel.Controls.Add(propertiesControl);
                }
            }

        }

    }
}
