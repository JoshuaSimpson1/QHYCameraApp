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
        IntPtr cameraHandle;

        public CameraPropertiesForm(StringBuilder cameraId, int cameraIndex)
        {
            InitializeComponent();
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
        }

        private void CameraPropertiesForm_Closed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.cameras[cameraIndex].hasPropertiesViewOpen = false;
        }

        private void CameraPropertiesForm_Load(object sender, EventArgs e)
        {
            cameraIdLabel.Text = this.cameraId.ToString();
        }

    }
}
