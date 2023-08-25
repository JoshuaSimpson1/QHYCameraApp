namespace QHYApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connectCameras = new Button();
            staticStatusLabel = new Label();
            statusLabel = new Label();
            camerasPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // connectCameras
            // 
            connectCameras.Location = new Point(12, 27);
            connectCameras.Name = "connectCameras";
            connectCameras.Size = new Size(146, 23);
            connectCameras.TabIndex = 0;
            connectCameras.Text = "Scan For Cameras";
            connectCameras.UseVisualStyleBackColor = true;
            connectCameras.Click += scanCameras_Click;
            // 
            // staticStatusLabel
            // 
            staticStatusLabel.AutoSize = true;
            staticStatusLabel.Location = new Point(12, 9);
            staticStatusLabel.Name = "staticStatusLabel";
            staticStatusLabel.Size = new Size(42, 15);
            staticStatusLabel.TabIndex = 1;
            staticStatusLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(51, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(29, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "N/A";
            // 
            // camerasPanel
            // 
            camerasPanel.Dock = DockStyle.Right;
            camerasPanel.Location = new Point(279, 0);
            camerasPanel.Name = "camerasPanel";
            camerasPanel.Size = new Size(776, 473);
            camerasPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 473);
            Controls.Add(camerasPanel);
            Controls.Add(statusLabel);
            Controls.Add(staticStatusLabel);
            Controls.Add(connectCameras);
            Name = "MainForm";
            Text = "P3 Labs QHY ";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectCameras;
        private Label staticStatusLabel;
        private Label statusLabel;
        private FlowLayoutPanel camerasPanel;
    }
}