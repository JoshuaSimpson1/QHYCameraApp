using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QHYApp {
    public partial class PropertiesControl : UserControl {
        CONTROL_ID setting;

        public PropertiesControl(CONTROL_ID setting) {
            InitializeComponent();
            this.setting = setting;
            this.Dock = DockStyle.Fill;
        }



        // Called when the trackbar is changed
        private void SettingTrackBar_Changed(object sender, EventArgs e) {

        }

        private void PropertiesControl_Load(object sender, EventArgs e) {
            this.settingLabel.Text = Enum.GetName<CONTROL_ID>(setting);
        }
    }
}
