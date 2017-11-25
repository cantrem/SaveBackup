using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SaveBackup
{
    public partial class SaveBackupForm : Form
    {
        public SaveBackupForm()
        {
            saveBackuper = new SaveBackuper();
            InitializeComponent();
        }

        private void chooseInputButton_Click(object sender, EventArgs e)
        {
            if(inputBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                InputPath.Text = inputBrowserDialog.SelectedPath;
            }
        }

        private void ChooseOutputButton_Click(object sender, EventArgs e)
        {
            if (outputBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                OutputPath.Text = outputBrowserDialog.SelectedPath;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!this.BackupTimer.Enabled) 
            {
                saveBackuper.InputPath = this.InputPath.Text;
                saveBackuper.OutputPath = this.OutputPath.Text;
                saveBackuper.TargetFileNames = new HashSet<string>(this.TargetFileNames.Items.Cast<String>().ToList());
                saveBackuper.BackupDirPostfix = this.BackupFolderName.Text;
                saveBackuper.MaxBackupCount = (int)this.MaxBackups.Value;

                this.StartButton.Text = "Stop";
                this.StartButton.BackColor = Color.LightGreen;
                this.BackupTimer.Interval = (int)this.BackupInterval.Value * 60 * 1000;
                this.BackupTimer.Start();
            }
            else
            {
                this.StartButton.Text = "Start";
                this.StartButton.BackColor = default(Color);
                this.BackupTimer.Stop();
            }
        }

        private SaveBackuper saveBackuper;

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            if(saveBackuper.Backup())
            {
                this.StatusLabel.Text = String.Format("Backup successful @ {0}", DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"));
                this.StatusLabel.BackColor = Color.LightGreen;
            }
            else
            {
                this.StatusLabel.Text = String.Format("Backup failed @ {0}", DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"));
                this.StatusLabel.BackColor = Color.LightYellow;
            }
        }

        private void DeleteBackups_Click(object sender, EventArgs e)
        {
            if(saveBackuper.DeleteBackups())
            {
                this.StatusLabel.Text = String.Format("Backups deleted @ {0}", DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"));
                this.StatusLabel.BackColor = Color.LightGreen;
            }
            else
            {
                this.StatusLabel.Text = String.Format("Backups failed to be deleted @ {0}", DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"));
                this.StatusLabel.BackColor = Color.LightYellow;
            }
        }

        private void SaveBackupForm_Load(object sender, EventArgs e)
        {
            try
            {
                Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

                if (confCollection["InputPath"] != null)
                {
                    this.InputPath.Text = confCollection["InputPath"].Value.ToString();
                    saveBackuper.InputPath = this.InputPath.Text;
                }
                if (confCollection["OutputPath"] != null)
                {
                    this.OutputPath.Text = confCollection["OutputPath"].Value.ToString();
                    saveBackuper.OutputPath = this.OutputPath.Text;
                }
                if (confCollection["BackupName"] != null)
                {
                    this.BackupFolderName.Text = confCollection["BackupName"].Value.ToString();
                    saveBackuper.BackupDirPostfix = this.BackupFolderName.Text;
                }

                if (confCollection["MaxBackups"] != null)
                {
                    int maxBackupVal;
                    Int32.TryParse(confCollection["MaxBackups"].Value.ToString(), out maxBackupVal);
                    this.MaxBackups.Value = maxBackupVal;
                }
                if (confCollection["BackupInterval"] != null)
                {
                    int backupIntervalVal;
                    Int32.TryParse(confCollection["BackupInterval"].Value.ToString(), out backupIntervalVal);
                    this.BackupInterval.Value = backupIntervalVal;
                }

                if (confCollection["FileNames"] != null)
                {
                    this.TargetFileNames.Items.Clear();
                    this.TargetFileNames.Items.AddRange(((string)confCollection["FileNames"].Value).Split(','));
                }
            }
            catch { }
        }

        private void SaveBackupForm_Closing(object sender, EventArgs e)
        {
            try
            {
                Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

                confCollection.Remove("InputPath");
                confCollection.Remove("OutputPath");
                confCollection.Remove("BackupName");
                confCollection.Remove("MaxBackups");
                confCollection.Remove("BackupInterval");
                confCollection.Remove("FileNames");

                confCollection.Add("InputPath",         this.InputPath.Text);
                confCollection.Add("OutputPath",        this.OutputPath.Text);
                confCollection.Add("BackupName",        this.BackupFolderName.Text);
                confCollection.Add("MaxBackups",        this.MaxBackups.Value.ToString());
                confCollection.Add("BackupInterval",    this.BackupInterval.Value.ToString());

                

                List <string> fileNames = this.TargetFileNames.Items.Cast<String>().ToList();
                confCollection.Add("FileNames", string.Join(",",fileNames));

                configManager.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configManager.AppSettings.SectionInformation.Name);
            }
            catch { }
        }

        private void AddInputFileButton_Click(object sender, EventArgs e)
        {
            if (this.NewFileNameBox.Text.Length == 0)
                return;

            this.TargetFileNames.Items.Add(this.NewFileNameBox.Text);
            this.NewFileNameBox.Text = "";
        }

        private void TargetFileNames_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && this.TargetFileNames.SelectedIndex >= 0)
            {
                this.TargetFileNames.Items.RemoveAt(this.TargetFileNames.SelectedIndex);
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
