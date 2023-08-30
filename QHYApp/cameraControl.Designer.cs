namespace QHYApp {
    partial class cameraControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            cameraPropertiesButton = new Button();
            liveViewButton = new Button();
            staticCameraIdLabel = new Label();
            cameraIdLabel = new Label();
            SuspendLayout();
            // 
            // cameraPropertiesButton
            // 
            cameraPropertiesButton.Dock = DockStyle.Right;
            cameraPropertiesButton.Location = new Point(270, 0);
            cameraPropertiesButton.Name = "cameraPropertiesButton";
            cameraPropertiesButton.Size = new Size(160, 40);
            cameraPropertiesButton.TabIndex = 0;
            cameraPropertiesButton.Text = "Camera Properties";
            cameraPropertiesButton.UseVisualStyleBackColor = true;
            cameraPropertiesButton.Click += cameraProperties_Click;
            // 
            // liveViewButton
            // 
            liveViewButton.Dock = DockStyle.Right;
            liveViewButton.Location = new Point(110, 0);
            liveViewButton.Name = "liveViewButton";
            liveViewButton.Size = new Size(160, 40);
            liveViewButton.TabIndex = 1;
            liveViewButton.Text = "Live View";
            liveViewButton.UseVisualStyleBackColor = true;
            liveViewButton.Click += liveViewButton_Click;
            // 
            // staticCameraIdLabel
            // 
            staticCameraIdLabel.AutoSize = true;
            staticCameraIdLabel.Dock = DockStyle.Left;
            staticCameraIdLabel.Location = new Point(0, 0);
            staticCameraIdLabel.Name = "staticCameraIdLabel";
            staticCameraIdLabel.Padding = new Padding(0, 10, 0, 10);
            staticCameraIdLabel.Size = new Size(65, 35);
            staticCameraIdLabel.TabIndex = 2;
            staticCameraIdLabel.Text = "Camera ID:";
            // 
            // cameraIdLabel
            // 
            cameraIdLabel.AutoSize = true;
            cameraIdLabel.Dock = DockStyle.Left;
            cameraIdLabel.Location = new Point(65, 0);
            cameraIdLabel.Name = "cameraIdLabel";
            cameraIdLabel.Padding = new Padding(0, 10, 0, 10);
            cameraIdLabel.Size = new Size(29, 35);
            cameraIdLabel.TabIndex = 3;
            cameraIdLabel.Text = "N/A";
            // 
            // cameraControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(cameraIdLabel);
            Controls.Add(staticCameraIdLabel);
            Controls.Add(liveViewButton);
            Controls.Add(cameraPropertiesButton);
            MinimumSize = new Size(430, 40);
            Name = "cameraControl";
            Size = new Size(430, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cameraPropertiesButton;
        private Button liveViewButton;
        private Label staticCameraIdLabel;
        private Label cameraIdLabel;
    }
}
