using System;

namespace SaveBackup
{
    partial class SaveBackupForm
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
            this.components = new System.ComponentModel.Container();
            this.InputPathLabel = new System.Windows.Forms.Label();
            this.OutpuPathLabel = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.Label();
            this.InputPath = new System.Windows.Forms.Label();
            this.TargetFileNames = new System.Windows.Forms.ListBox();
            this.NewFileNameBox = new System.Windows.Forms.TextBox();
            this.AddInputFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChooseOutputButton = new System.Windows.Forms.Button();
            this.chooseInputButton = new System.Windows.Forms.Button();
            this.inputBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackupInterval = new System.Windows.Forms.NumericUpDown();
            this.MaxBackups = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupFolderName = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPathLabel
            // 
            this.InputPathLabel.AutoSize = true;
            this.InputPathLabel.Location = new System.Drawing.Point(3, 24);
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Size = new System.Drawing.Size(59, 13);
            this.InputPathLabel.TabIndex = 0;
            this.InputPathLabel.Text = "Input Path:";
            // 
            // OutpuPathLabel
            // 
            this.OutpuPathLabel.AutoSize = true;
            this.OutpuPathLabel.Location = new System.Drawing.Point(3, 53);
            this.OutpuPathLabel.Name = "OutpuPathLabel";
            this.OutpuPathLabel.Size = new System.Drawing.Size(67, 13);
            this.OutpuPathLabel.TabIndex = 1;
            this.OutpuPathLabel.Text = "Output Path:";
            // 
            // OutputPath
            // 
            this.OutputPath.AutoSize = true;
            this.OutputPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputPath.Location = new System.Drawing.Point(81, 53);
            this.OutputPath.MaximumSize = new System.Drawing.Size(300, 0);
            this.OutputPath.MinimumSize = new System.Drawing.Size(300, 0);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(300, 13);
            this.OutputPath.TabIndex = 2;
            this.OutputPath.Text = "C:\\";
            // 
            // InputPath
            // 
            this.InputPath.AutoSize = true;
            this.InputPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InputPath.Location = new System.Drawing.Point(81, 24);
            this.InputPath.MaximumSize = new System.Drawing.Size(300, 0);
            this.InputPath.MinimumSize = new System.Drawing.Size(300, 0);
            this.InputPath.Name = "InputPath";
            this.InputPath.Size = new System.Drawing.Size(300, 13);
            this.InputPath.TabIndex = 3;
            this.InputPath.Text = "C:\\";
            // 
            // TargetFileNames
            // 
            this.TargetFileNames.FormattingEnabled = true;
            this.TargetFileNames.Location = new System.Drawing.Point(6, 19);
            this.TargetFileNames.Name = "TargetFileNames";
            this.TargetFileNames.Size = new System.Drawing.Size(206, 95);
            this.TargetFileNames.Sorted = true;
            this.TargetFileNames.TabIndex = 4;
            this.TargetFileNames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TargetFileNames_KeyUp);
            // 
            // NewFileNameBox
            // 
            this.NewFileNameBox.Location = new System.Drawing.Point(6, 122);
            this.NewFileNameBox.Name = "NewFileNameBox";
            this.NewFileNameBox.Size = new System.Drawing.Size(125, 20);
            this.NewFileNameBox.TabIndex = 6;
            // 
            // AddInputFileButton
            // 
            this.AddInputFileButton.Location = new System.Drawing.Point(137, 120);
            this.AddInputFileButton.Name = "AddInputFileButton";
            this.AddInputFileButton.Size = new System.Drawing.Size(75, 23);
            this.AddInputFileButton.TabIndex = 7;
            this.AddInputFileButton.Text = "Add";
            this.AddInputFileButton.UseVisualStyleBackColor = true;
            this.AddInputFileButton.Click += new System.EventHandler(this.AddInputFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TargetFileNames);
            this.groupBox1.Controls.Add(this.AddInputFileButton);
            this.groupBox1.Controls.Add(this.NewFileNameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input File Names ( leave empty to copy all):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChooseOutputButton);
            this.groupBox2.Controls.Add(this.chooseInputButton);
            this.groupBox2.Controls.Add(this.InputPathLabel);
            this.groupBox2.Controls.Add(this.OutpuPathLabel);
            this.groupBox2.Controls.Add(this.InputPath);
            this.groupBox2.Controls.Add(this.OutputPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths:";
            // 
            // ChooseOutputButton
            // 
            this.ChooseOutputButton.Location = new System.Drawing.Point(386, 48);
            this.ChooseOutputButton.Name = "ChooseOutputButton";
            this.ChooseOutputButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseOutputButton.TabIndex = 9;
            this.ChooseOutputButton.Text = "Choose";
            this.ChooseOutputButton.UseVisualStyleBackColor = true;
            this.ChooseOutputButton.Click += new System.EventHandler(this.ChooseOutputButton_Click);
            // 
            // chooseInputButton
            // 
            this.chooseInputButton.Location = new System.Drawing.Point(386, 19);
            this.chooseInputButton.Name = "chooseInputButton";
            this.chooseInputButton.Size = new System.Drawing.Size(75, 23);
            this.chooseInputButton.TabIndex = 8;
            this.chooseInputButton.Text = "Choose";
            this.chooseInputButton.UseVisualStyleBackColor = true;
            this.chooseInputButton.Click += new System.EventHandler(this.chooseInputButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BackupInterval);
            this.groupBox3.Controls.Add(this.MaxBackups);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BackupFolderName);
            this.groupBox3.Location = new System.Drawing.Point(252, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup Settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "(minutes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Backup interval:";
            // 
            // BackupInterval
            // 
            this.BackupInterval.Location = new System.Drawing.Point(90, 71);
            this.BackupInterval.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.BackupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupInterval.Name = "BackupInterval";
            this.BackupInterval.Size = new System.Drawing.Size(51, 20);
            this.BackupInterval.TabIndex = 14;
            this.BackupInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxBackups
            // 
            this.MaxBackups.Location = new System.Drawing.Point(90, 45);
            this.MaxBackups.Name = "MaxBackups";
            this.MaxBackups.Size = new System.Drawing.Size(51, 20);
            this.MaxBackups.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Max Backups:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Backup Name:";
            // 
            // BackupFolderName
            // 
            this.BackupFolderName.Location = new System.Drawing.Point(90, 19);
            this.BackupFolderName.Name = "BackupFolderName";
            this.BackupFolderName.Size = new System.Drawing.Size(131, 20);
            this.BackupFolderName.TabIndex = 8;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 335);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(474, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackupTimer
            // 
            this.BackupTimer.Tick += new System.EventHandler(this.BackupTimer_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusLabel.Location = new System.Drawing.Point(12, 361);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(474, 0);
            this.StatusLabel.MinimumSize = new System.Drawing.Size(474, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(474, 13);
            this.StatusLabel.TabIndex = 10;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(411, 377);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 12;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // SaveBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 412);
            this.Controls.Add(this.About);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaveBackupForm";
            this.Text = "SaveBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveBackupForm_Closing);
            this.Load += new System.EventHandler(this.SaveBackupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBackups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputPathLabel;
        private System.Windows.Forms.Label OutpuPathLabel;
        private System.Windows.Forms.Label OutputPath;
        private System.Windows.Forms.Label InputPath;
        private System.Windows.Forms.ListBox TargetFileNames;
        private System.Windows.Forms.TextBox NewFileNameBox;
        private System.Windows.Forms.Button AddInputFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChooseOutputButton;
        private System.Windows.Forms.Button chooseInputButton;
        private System.Windows.Forms.FolderBrowserDialog inputBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackupFolderName;
        private System.Windows.Forms.NumericUpDown MaxBackups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer BackupTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BackupInterval;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button About;
    }
}

