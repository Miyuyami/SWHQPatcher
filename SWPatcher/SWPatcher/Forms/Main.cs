﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using SWPatcher.General;
using SWPatcher.Helpers;
using SWPatcher.Helpers.GlobalVar;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization.Formatters.Binary;

namespace SWPatcher.Forms
{
    public partial class Main : Form
    {
        public enum States
        {
            Idle = 0,
            CheckingVersion,
            Downloading,
            Patching
        }

        private readonly List<SWFile> SWFiles;
        private readonly BackgroundWorker Worker;
        private States _state;

        public States State
        {
            get
            {
                return _state;
            }
            private set
            {
                if (_state != value)
                {
                    switch (value)
                    {
                        case States.Idle:
                            comboBoxLanguages.Enabled = true;
                            buttonLastest.Enabled = true;
                            buttonLastest.Text = Strings.FormText.Download;
                            buttonPatch.Enabled = true;
                            buttonPatch.Text = Strings.FormText.Patch;
                            toolStripStatusLabel.Text = Strings.FormText.Status.Idle;
                            toolStripProgressBar.Value = toolStripProgressBar.Minimum;
                            break;
                        case States.CheckingVersion:
                            comboBoxLanguages.Enabled = false;
                            buttonLastest.Enabled = false;
                            buttonLastest.Text = Strings.FormText.Download;
                            buttonPatch.Enabled = false;
                            buttonPatch.Text = Strings.FormText.Patch;
                            toolStripStatusLabel.Text = Strings.FormText.Status.Check;
                            toolStripProgressBar.Value = toolStripProgressBar.Minimum;
                            break;
                        case States.Downloading:
                            comboBoxLanguages.Enabled = false;
                            buttonLastest.Enabled = true;
                            buttonLastest.Text = Strings.FormText.Cancel;
                            buttonPatch.Enabled = false;
                            buttonPatch.Text = Strings.FormText.Patch;
                            toolStripStatusLabel.Text = Strings.FormText.Status.Download;
                            toolStripProgressBar.Value = toolStripProgressBar.Minimum;
                            break;
                        case States.Patching:
                            comboBoxLanguages.Enabled = false;
                            buttonLastest.Enabled = false;
                            buttonLastest.Text = Strings.FormText.Download;
                            buttonPatch.Enabled = true;
                            buttonPatch.Text = Strings.FormText.Cancel;
                            toolStripStatusLabel.Text = Strings.FormText.Status.Patch;
                            toolStripProgressBar.Value = toolStripProgressBar.Minimum;
                            break;
                    }
                    _state = value;
                }
            }
        }

        public Main()
        {
            SWFiles = new List<SWFile>();
            InitializeComponent();
            Text = AssemblyAccessor.Title + " " + AssemblyAccessor.Version;
            buttonLastest.Text = Strings.FormText.Download;
            buttonPatch.Text = Strings.FormText.Patch;
            toolStripStatusLabel.Text = Strings.FormText.Status.Idle;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RestoreBackup();
            if (CheckForProgramUpdate() || CheckForProgramFolderMalfunction(Path.GetDirectoryName(Paths.PatcherRoot)) || CheckForSWPath() || CheckForGameClientUpdate() || (comboBoxLanguages.DataSource = GetAllAvailableLanguages()) == null)
                return;
        }

        private void buttonLastest_Click(object sender, EventArgs e)
        {
            //Updater.run()
            if (IsNewerTranslationVersion(this.comboBoxLanguages.SelectedItem.ToString()))
            {
                
            }
        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
