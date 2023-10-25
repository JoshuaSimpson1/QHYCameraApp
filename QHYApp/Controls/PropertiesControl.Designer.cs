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
            splitContainer = new SplitContainer();
            settingLabel = new Label();
            numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(settingLabel);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(numericUpDown);
            splitContainer.Size = new Size(600, 40);
            splitContainer.SplitterDistance = 200;
            splitContainer.TabIndex = 1;
            // 
            // settingLabel
            // 
            settingLabel.AutoSize = true;
            settingLabel.Dock = DockStyle.Left;
            settingLabel.Location = new Point(0, 0);
            settingLabel.Name = "settingLabel";
            settingLabel.Padding = new Padding(0, 12, 0, 12);
            settingLabel.Size = new Size(79, 39);
            settingLabel.TabIndex = 0;
            settingLabel.Text = "Setting Name";
            // 
            // numericUpDown
            // 
            numericUpDown.AutoSize = true;
            numericUpDown.Dock = DockStyle.Fill;
            numericUpDown.Location = new Point(0, 0);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(396, 23);
            numericUpDown.TabIndex = 0;
            // 
            // PropertiesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(splitContainer);
            MinimumSize = new Size(600, 40);
            Name = "PropertiesControl";
            Size = new Size(600, 40);
            Load += PropertiesControl_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label settingLabel;
        private NumericUpDown numericUpDown;
    }
}
