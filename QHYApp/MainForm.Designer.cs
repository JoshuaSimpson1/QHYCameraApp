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
            staticQHYInit = new Label();
            resourcesInitLabel = new Label();
            SuspendLayout();
            // 
            // connectCameras
            // 
            connectCameras.Location = new Point(12, 29);
            connectCameras.Name = "connectCameras";
            connectCameras.Size = new Size(164, 23);
            connectCameras.TabIndex = 0;
            connectCameras.Text = "Scan For Cameras";
            connectCameras.UseVisualStyleBackColor = true;
            connectCameras.Click += scanCameras_Click;
            // 
            // staticStatusLabel
            // 
            staticStatusLabel.AutoSize = true;
            staticStatusLabel.Location = new Point(182, 33);
            staticStatusLabel.Name = "staticStatusLabel";
            staticStatusLabel.Size = new Size(42, 15);
            staticStatusLabel.TabIndex = 1;
            staticStatusLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(230, 33);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(29, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "N/A";
            // 
            // staticQHYInit
            // 
            staticQHYInit.AutoSize = true;
            staticQHYInit.Location = new Point(12, 11);
            staticQHYInit.Name = "staticQHYInit";
            staticQHYInit.Size = new Size(111, 15);
            staticQHYInit.TabIndex = 3;
            staticQHYInit.Text = "QHY Resources Init:";
            // 
            // resourcesInitLabel
            // 
            resourcesInitLabel.AutoSize = true;
            resourcesInitLabel.Location = new Point(129, 11);
            resourcesInitLabel.Name = "resourcesInitLabel";
            resourcesInitLabel.Size = new Size(29, 15);
            resourcesInitLabel.TabIndex = 4;
            resourcesInitLabel.Text = "N/A";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resourcesInitLabel);
            Controls.Add(staticQHYInit);
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
        private Label staticQHYInit;
        private Label resourcesInitLabel;
    }
}