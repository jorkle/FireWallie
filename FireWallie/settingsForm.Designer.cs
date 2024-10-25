namespace FireWallie
{
    partial class settingsForm
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
            label1 = new Label();
            exeCheckbox = new CheckBox();
            comCheckbox = new CheckBox();
            msiCheckbox = new CheckBox();
            vbsCheckbox = new CheckBox();
            cmdCheckbox = new CheckBox();
            batCheckbox = new CheckBox();
            skipConfirmationCheckbox = new CheckBox();
            closeSettingsButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 0;
            label1.Text = "Executable File Extensions (to process)";
            // 
            // exeCheckbox
            // 
            exeCheckbox.AutoSize = true;
            exeCheckbox.Location = new Point(33, 36);
            exeCheckbox.Name = "exeCheckbox";
            exeCheckbox.Size = new Size(45, 19);
            exeCheckbox.TabIndex = 2;
            exeCheckbox.Text = "EXE";
            exeCheckbox.UseVisualStyleBackColor = true;
            exeCheckbox.CheckedChanged += exeCheckbox_CheckedChanged;
            // 
            // comCheckbox
            // 
            comCheckbox.AutoSize = true;
            comCheckbox.Location = new Point(33, 61);
            comCheckbox.Name = "comCheckbox";
            comCheckbox.Size = new Size(54, 19);
            comCheckbox.TabIndex = 3;
            comCheckbox.Text = "COM";
            comCheckbox.UseVisualStyleBackColor = true;
            // 
            // msiCheckbox
            // 
            msiCheckbox.AutoSize = true;
            msiCheckbox.Location = new Point(147, 61);
            msiCheckbox.Name = "msiCheckbox";
            msiCheckbox.Size = new Size(46, 19);
            msiCheckbox.TabIndex = 4;
            msiCheckbox.Text = "MSI";
            msiCheckbox.UseVisualStyleBackColor = true;
            // 
            // vbsCheckbox
            // 
            vbsCheckbox.AutoSize = true;
            vbsCheckbox.Location = new Point(147, 36);
            vbsCheckbox.Name = "vbsCheckbox";
            vbsCheckbox.Size = new Size(46, 19);
            vbsCheckbox.TabIndex = 6;
            vbsCheckbox.Text = "VBS";
            vbsCheckbox.UseVisualStyleBackColor = true;
            // 
            // cmdCheckbox
            // 
            cmdCheckbox.AutoSize = true;
            cmdCheckbox.Location = new Point(93, 61);
            cmdCheckbox.Name = "cmdCheckbox";
            cmdCheckbox.Size = new Size(53, 19);
            cmdCheckbox.TabIndex = 7;
            cmdCheckbox.Text = "CMD";
            cmdCheckbox.UseVisualStyleBackColor = true;
            // 
            // batCheckbox
            // 
            batCheckbox.AutoSize = true;
            batCheckbox.Location = new Point(94, 36);
            batCheckbox.Name = "batCheckbox";
            batCheckbox.Size = new Size(47, 19);
            batCheckbox.TabIndex = 8;
            batCheckbox.Text = "BAT";
            batCheckbox.UseVisualStyleBackColor = true;
            // 
            // skipConfirmationCheckbox
            // 
            skipConfirmationCheckbox.AutoSize = true;
            skipConfirmationCheckbox.Location = new Point(50, 86);
            skipConfirmationCheckbox.Name = "skipConfirmationCheckbox";
            skipConfirmationCheckbox.Size = new Size(127, 19);
            skipConfirmationCheckbox.TabIndex = 10;
            skipConfirmationCheckbox.Text = "Skip Confirmation?";
            skipConfirmationCheckbox.UseVisualStyleBackColor = true;
            // 
            // closeSettingsButton
            // 
            closeSettingsButton.Location = new Point(12, 111);
            closeSettingsButton.Name = "closeSettingsButton";
            closeSettingsButton.Size = new Size(207, 23);
            closeSettingsButton.TabIndex = 11;
            closeSettingsButton.Text = "Close Settings";
            closeSettingsButton.UseVisualStyleBackColor = true;
            closeSettingsButton.Click += closeSettingsButton_Click;
            // 
            // settingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 143);
            Controls.Add(closeSettingsButton);
            Controls.Add(skipConfirmationCheckbox);
            Controls.Add(batCheckbox);
            Controls.Add(cmdCheckbox);
            Controls.Add(vbsCheckbox);
            Controls.Add(msiCheckbox);
            Controls.Add(comCheckbox);
            Controls.Add(exeCheckbox);
            Controls.Add(label1);
            Name = "settingsForm";
            Text = "settingsForm";
            Load += settingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox exeCheckbox;
        private CheckBox comCheckbox;
        private CheckBox msiCheckbox;
        private CheckBox vbsCheckbox;
        private CheckBox cmdCheckbox;
        private CheckBox batCheckbox;
        private CheckBox skipConfirmationCheckbox;
        private Button closeSettingsButton;
    }
}