using System.Text;

namespace QHYApp {
    public partial class CameraPropertiesForm : Form {
        StringBuilder cameraId;
        String defaultFile;
        int cameraIndex;

        public CameraPropertiesForm(StringBuilder cameraId, int cameraIndex) {
            InitializeComponent();
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
            this.defaultFile = "";
        }
        // When the form closes save our camera settings
        private void CameraPropertiesForm_Closed(object sender, FormClosedEventArgs e) {
            CameraCollection.cameras[cameraIndex].hasPropertiesViewOpen = false;

            QHYApp.Properties.Settings.Default[cameraId.ToString()] = defaultFile;
            QHYApp.Properties.Settings.Default.Save();
        }

        // Add all the propteries controls and loads the saved profile for the cameraId
        private void CameraPropertiesForm_Load(object sender, EventArgs e) {
            // Load ui and controls
            cameraIdLabel.Text = this.cameraId.ToString();

            defaultFile = (String)QHYApp.Properties.Settings.Default[cameraId.ToString()];
            loadProfile(defaultFile);

            foreach (var setting in Enum.GetValues<CONTROL_ID>()) {
                if (QHYLib.IsQHYCCDControlAvailable(CameraCollection.cameras[cameraIndex].cameraHandle, setting) == (int)RESULT.QHYCCD_SUCCESS) {
                    PropertiesControl propertiesControl = new PropertiesControl(setting, cameraIndex);
                    settingsPanel.Controls.Add(propertiesControl);
                }
            }

        }

        // Uses the openFileDialog to process settings for a file
        private void loadProfileButton_Click(object sender, EventArgs e) {
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                loadProfile(openFileDialog.FileName);
            }
        }

        // Attempts to load a profile from a file
        private void loadProfile(String fileName) {
            try {
                IntPtr cameraHandle = CameraCollection.cameras[cameraIndex].cameraHandle;
                var streamReader = new StreamReader(fileName);
                foreach (var setting in Enum.GetValues<CONTROL_ID>()) {
                    var data = streamReader.ReadLine();
                    Double.TryParse(data, out var value);
                    if (QHYLib.IsQHYCCDControlAvailable(cameraHandle, setting) == (int)RESULT.QHYCCD_SUCCESS) {
                        QHYLib.SetQHYCCDParam(cameraHandle, setting, value);
                    }
                }
                defaultFile = fileName;
                streamReader.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // Saves settings data from a camera
        private void saveProfileButton_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                IntPtr cameraHandle = CameraCollection.cameras[cameraIndex].cameraHandle;
                saveFileDialog.Filter = "Settings|*.settings";
                saveFileDialog.Title = "Save Camera Settings";
                if(saveFileDialog.FileName != "") {
                    try {
                        var streamWriter = new StreamWriter(saveFileDialog.FileName);
                        foreach(var setting in Enum.GetValues<CONTROL_ID>()) {
                            var data = QHYLib.GetQHYCCDParam(cameraHandle, setting);
                            streamWriter.WriteLine(data);
                        }
                        defaultFile = saveFileDialog.FileName;
                        streamWriter.Close();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
