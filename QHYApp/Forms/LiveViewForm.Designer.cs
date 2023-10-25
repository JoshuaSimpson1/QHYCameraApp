namespace QHYApp
{
    partial class LiveViewForm
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
            liveViewButtonPanel = new Panel();
            triggerModeButton = new Button();
            liveViewPanel = new Panel();
            liveViewButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // liveViewButtonPanel
            // 
            liveViewButtonPanel.Controls.Add(triggerModeButton);
            liveViewButtonPanel.Dock = DockStyle.Bottom;
            liveViewButtonPanel.Location = new Point(0, 489);
            liveViewButtonPanel.Name = "liveViewButtonPanel";
            liveViewButtonPanel.Size = new Size(806, 36);
            liveViewButtonPanel.TabIndex = 0;
            // 
            // triggerModeButton
            // 
            triggerModeButton.Location = new Point(0, 0);
            triggerModeButton.Name = "triggerModeButton";
            triggerModeButton.Size = new Size(138, 36);
            triggerModeButton.TabIndex = 0;
            triggerModeButton.Text = "Set To Trigger Mode";
            triggerModeButton.UseVisualStyleBackColor = true;
            triggerModeButton.Click += triggerModeButton_Click;
            // 
            // liveViewPanel
            // 
            liveViewPanel.AutoSize = true;
            liveViewPanel.Dock = DockStyle.Fill;
            liveViewPanel.Location = new Point(0, 0);
            liveViewPanel.Name = "liveViewPanel";
            liveViewPanel.Size = new Size(806, 489);
            liveViewPanel.TabIndex = 1;
            // 
            // LiveViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 525);
            Controls.Add(liveViewPanel);
            Controls.Add(liveViewButtonPanel);
            Name = "LiveViewForm";
            Text = "LiveViewForm";
            FormClosed += LiveViewForm_Close;
            liveViewButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel liveViewButtonPanel;
        private Panel liveViewPanel;
        private Button triggerModeButton;
    }
}