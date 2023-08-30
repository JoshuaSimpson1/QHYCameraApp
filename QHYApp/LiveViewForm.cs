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
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.cameras[cameraIndex].hasLiveViewOpen = false;
        }
    }
}
