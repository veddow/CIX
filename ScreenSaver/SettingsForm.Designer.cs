namespace ScreenSaver
{
    partial class SettingsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.serverUrl = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(51, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(157, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(57, 22);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(167, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter the text you\'d like to display:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 49);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(265, 20);
            this.textBox.TabIndex = 3;
            // 
            // colorDlg
            // 
            this.colorDlg.AnyColor = true;
            // 
            // serverUrl
            // 
            this.serverUrl.AutoSize = true;
            this.serverUrl.Location = new System.Drawing.Point(57, 100);
            this.serverUrl.Name = "serverUrl";
            this.serverUrl.Size = new System.Drawing.Size(168, 13);
            this.serverUrl.TabIndex = 4;
            this.serverUrl.Text = "Enter the URL of your web server:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 128);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(265, 20);
            this.urlTextBox.TabIndex = 5;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(28, 180);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(101, 13);
            this.intervalLabel.TabIndex = 6;
            this.intervalLabel.Text = "Select ticker speed:";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.Items.AddRange(new object[] {
            "1 second",
            "2 seconds",
            "3 seconds",
            "4 seconds",
            "5 seconds"});
            this.intervalComboBox.Location = new System.Drawing.Point(141, 177);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(121, 21);
            this.intervalComboBox.TabIndex = 7;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.intervalComboBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.serverUrl);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "SettingsForm";
            this.Text = "Screen Saver Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.Label serverUrl;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.ComboBox intervalComboBox;
    }
}