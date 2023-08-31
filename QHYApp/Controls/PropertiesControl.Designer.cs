namespace QHYApp
{
    partial class PropertiesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            settingLabel = new Label();
            SuspendLayout();
            // 
            // settingLabel
            // 
            settingLabel.AutoSize = true;
            settingLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            settingLabel.Location = new Point(3, 2);
            settingLabel.Name = "settingLabel";
            settingLabel.Size = new Size(43, 17);
            settingLabel.TabIndex = 0;
            settingLabel.Text = "label1";
            // 
            // PropertiesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(settingLabel);
            Name = "PropertiesControl";
            Size = new Size(750, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingLabel;
    }
}
