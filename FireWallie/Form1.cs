namespace FireWallie
{
    public partial class Form1 : Form
    {
        public bool exeCheckbox = false;
        public bool msiCheckbox = false;
        public bool batCheckbox = false;
        public bool cmdCheckbox = false;
        public bool vbsCheckbox = false;
        public bool comCheckbox = false;
        public bool skipConfirmationCheckbox = false;


        public List<string> Files = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    if (exeCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.exe", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.exe").ToArray());
                        }
                    }
                    if (msiCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.msi", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.msi").ToArray());
                        }
                    }
                    if (batCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.bat", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.bat").ToArray());
                        }
                    }
                    if (comCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.com", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.com").ToArray());
                        }
                    }
                    if (vbsCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.vbs", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.vbs").ToArray());
                        }
                    }
                    if (cmdCheckbox)
                    {
                        if (recursiveCheckBox.Checked)
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.cmd", SearchOption.AllDirectories).ToArray());
                        }
                        else
                        {
                            Files.AddRange(Directory.EnumerateFiles(fbd.SelectedPath, "*.cmd").ToArray());
                        }
                    }
                    goButton.Enabled = true;
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        { 
            foreach (string file in Files)
            {
                if (skipConfirmationCheckbox)
                {
                    System.Diagnostics.Process.Start("netsh.exe", "advfirewall firewall add rule name=\"Blocked (FireWallie): " + file.Split('\\').Last() + "\" dir=\"out\" action=\"block\" program=\"" + file + "\"");
                } else {
                    DialogResult result = MessageBox.Show("Block Internet? (Yes/No): ", file, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("netsh.exe", "advfirewall firewall add rule name=\"Blocked (FireWallie): " + file.Split('\\').Last() + "\" dir=\"out\" action=\"block\" program=\"" + file + "\"");
                    }
                    else if (result == DialogResult.No)
                    {
                        continue;

                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm sForm = new settingsForm(this);
            sForm.ShowDialog();
        }
    }
}
