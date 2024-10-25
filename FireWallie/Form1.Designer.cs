namespace FireWallie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            recursiveCheckBox = new CheckBox();
            folderDialog1 = new FolderBrowserDialog();
            browseButton = new Button();
            goButton = new Button();
            settingsButton = new Button();
            SuspendLayout();
            // 
            // recursiveCheckBox
            // 
            recursiveCheckBox.AutoSize = true;
            recursiveCheckBox.Location = new Point(18, 23);
            recursiveCheckBox.Name = "recursiveCheckBox";
            recursiveCheckBox.Size = new Size(110, 19);
            recursiveCheckBox.TabIndex = 0;
            recursiveCheckBox.Text = "Recursive Mode";
            recursiveCheckBox.UseVisualStyleBackColor = true;
            recursiveCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // folderDialog1
            // 
            folderDialog1.ShowHiddenFiles = true;
            // 
            // browseButton
            // 
            browseButton.Enabled = false;
            browseButton.Location = new Point(157, 19);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // goButton
            // 
            goButton.Enabled = false;
            goButton.Location = new Point(133, 54);
            goButton.Name = "goButton";
            goButton.Size = new Size(99, 23);
            goButton.TabIndex = 3;
            goButton.Text = "Go!";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(12, 54);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(99, 23);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 89);
            Controls.Add(settingsButton);
            Controls.Add(goButton);
            Controls.Add(browseButton);
            Controls.Add(recursiveCheckBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FireWallie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox recursiveCheckBox;
        private FolderBrowserDialog folderDialog1;
        private Button settingsButton;
        public Button goButton;
        public Button browseButton;
    }
}
