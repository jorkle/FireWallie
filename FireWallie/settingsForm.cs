using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireWallie
{
    public partial class settingsForm : Form
    {
        private Form1 mainForm = null;
        public settingsForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void exeCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeSettingsButton_Click(object sender, EventArgs e)
        {

            if (exeCheckbox.Checked)
            {
                Properties.Settings.Default["exeCheckbox"] = true;
                this.mainForm.exeCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["exeCheckbox"] = false;
                this.mainForm.exeCheckbox = false;
            }

            if (msiCheckbox.Checked)
            {
                Properties.Settings.Default["msiCheckbox"] = true;
                this.mainForm.msiCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["msiCheckbox"] = false;
                this.mainForm.msiCheckbox = false;
            }

            if (batCheckbox.Checked)
            {
                Properties.Settings.Default["batCheckbox"] = true;
                this.mainForm.batCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["batCheckbox"] = false;
                this.mainForm.batCheckbox = false;
            }

            if (comCheckbox.Checked)
            {
                Properties.Settings.Default["comCheckbox"] = true;
                this.mainForm.comCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["comCheckbox"] = false;
                this.mainForm.comCheckbox = false;
            }

            if (vbsCheckbox.Checked)
            {
                Properties.Settings.Default["vbsCheckbox"] = true;
                this.mainForm.vbsCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["vbsCheckbox"] = false;
                this.mainForm.vbsCheckbox = false;
            }

            if (cmdCheckbox.Checked)
            {
                Properties.Settings.Default["cmdCheckbox"] = true;
                this.mainForm.cmdCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["cmdCheckbox"] = false;
                this.mainForm.cmdCheckbox = false;
            }

            if (skipConfirmationCheckbox.Checked)
            {
                Properties.Settings.Default["skipConfirmationCheckbox"] = true;
                this.mainForm.skipConfirmationCheckbox = true;
            }
            else
            {
                Properties.Settings.Default["skipConfirmationCheckbox"] = false;
                this.mainForm.skipConfirmationCheckbox = false;
            }
            Properties.Settings.Default.Save();
            this.mainForm.browseButton.Enabled = true;
            this.Close();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.exeCheckbox)
            {
                exeCheckbox.Checked = true;
            }
            else
            {
                exeCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.msiCheckbox)
            {
                msiCheckbox.Checked = true;
            }
            else
            {
                msiCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.batCheckbox)
            {
                batCheckbox.Checked = true;
            }
            else
            {
                batCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.vbsCheckbox)
            {
                vbsCheckbox.Checked = true;
            }
            else
            {
                vbsCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.comCheckbox)
            {
                comCheckbox.Checked = true;
            }
            else
            {
                comCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.cmdCheckbox)
            {
                cmdCheckbox.Checked = true;
            }
            else
            {
                cmdCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.skipConfirmationCheckbox)
            {
                skipConfirmationCheckbox.Checked = true;
            }
            else
            {
                skipConfirmationCheckbox.Checked = false;
            }
        }
    }
}
