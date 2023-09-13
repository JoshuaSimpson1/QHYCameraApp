namespace QHYApp
{
    partial class CameraPropertiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            staticCameraIdLabel = new Label();
            cameraIdLabel = new Label();
            cameraIdPanel = new Panel();
            loadProfileButton = new Button();
            saveProfileButton = new Button();
            settingsPanel = new FlowLayoutPanel();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            cameraIdPanel.SuspendLayout();
            SuspendLayout();
            // 
            // staticCameraIdLabel
            // 
            staticCameraIdLabel.AutoSize = true;
            staticCameraIdLabel.Location = new Point(3, 8);
            staticCameraIdLabel.Name = "staticCameraIdLabel";
            staticCameraIdLabel.Size = new Size(65, 15);
            staticCameraIdLabel.TabIndex = 0;
            staticCameraIdLabel.Text = "Camera ID:";
            // 
            // cameraIdLabel
            // 
            cameraIdLabel.AutoSize = true;
            cameraIdLabel.Location = new Point(74, 8);
            cameraIdLabel.Name = "cameraIdLabel";
            cameraIdLabel.Size = new Size(29, 15);
            cameraIdLabel.TabIndex = 1;
            cameraIdLabel.Text = "N/A";
            // 
            // cameraIdPanel
            // 
            cameraIdPanel.Controls.Add(loadProfileButton);
            cameraIdPanel.Controls.Add(saveProfileButton);
            cameraIdPanel.Controls.Add(staticCameraIdLabel);
            cameraIdPanel.Controls.Add(cameraIdLabel);
            cameraIdPanel.Dock = DockStyle.Top;
            cameraIdPanel.Location = new Point(0, 0);
            cameraIdPanel.Name = "cameraIdPanel";
            cameraIdPanel.Size = new Size(1018, 30);
            cameraIdPanel.TabIndex = 2;
            // 
            // loadProfileButton
            // 
            loadProfileButton.Dock = DockStyle.Right;
            loadProfileButton.Location = new Point(818, 0);
            loadProfileButton.Name = "loadProfileButton";
            loadProfileButton.Size = new Size(100, 30);
            loadProfileButton.TabIndex = 4;
            loadProfileButton.Text = "Load Profile";
            loadProfileButton.UseVisualStyleBackColor = true;
            loadProfileButton.Click += loadProfileButton_Click;
            // 
            // saveProfileButton
            // 
            saveProfileButton.Dock = DockStyle.Right;
            saveProfileButton.Location = new Point(918, 0);
            saveProfileButton.Name = "saveProfileButton";
            saveProfileButton.Size = new Size(100, 30);
            saveProfileButton.TabIndex = 3;
            saveProfileButton.Text = "Save Profile";
            saveProfileButton.UseVisualStyleBackColor = true;
            saveProfileButton.Click += saveProfileButton_Click;
            // 
            // settingsPanel
            // 
            settingsPanel.AutoScroll = true;
            settingsPanel.BackColor = SystemColors.AppWorkspace;
            settingsPanel.Dock = DockStyle.Fill;
            settingsPanel.FlowDirection = FlowDirection.TopDown;
            settingsPanel.Location = new Point(0, 30);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(1018, 531);
            settingsPanel.TabIndex = 3;
            settingsPanel.WrapContents = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // CameraPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 561);
            Controls.Add(settingsPanel);
            Controls.Add(cameraIdPanel);
            Name = "CameraPropertiesForm";
            Text = "CameraPropertiesForm";
            FormClosed += CameraPropertiesForm_Closed;
            Load += CameraPropertiesForm_Load;
            cameraIdPanel.ResumeLayout(false);
            cameraIdPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label staticCameraIdLabel;
        private Label cameraIdLabel;
        private Panel cameraIdPanel;
        private Button saveProfileButton;
        private FlowLayoutPanel settingsPanel;
        private Button loadProfileButton;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}