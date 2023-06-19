﻿using Ionic.Zip;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace BlasModInstaller
{
    public class ModRow
    {
        private const int ROW_HEIGHT = 82;

        private readonly ModData mod;

        public ModRow(ModData mod) => this.mod = mod;

        // Main methods

        public void InstallMod(string zipPath)
        {
            if (MainForm.BlasRootFolder == null) return;

            string installPath = MainForm.BlasRootFolder;
            if (mod.Name != "Modding API")
                installPath += "\\Modding";

            using (ZipFile zipFile = ZipFile.Read(zipPath))
            {
                foreach (ZipEntry file in zipFile)
                    file.Extract(installPath, ExtractExistingFileAction.OverwriteSilently);
            }
            File.Delete(zipPath);

            UpdateUI();
        }

        public void UninstallMod()
        {
            if (MainForm.BlasRootFolder == null) return;

            if (File.Exists(mod.PathToEnabledPlugin))
                File.Delete(mod.PathToEnabledPlugin);
            if (File.Exists(mod.PathToDisabledPlugin))
                File.Delete(mod.PathToDisabledPlugin);
            if (File.Exists(mod.PathToConfigFile))
                File.Delete(mod.PathToConfigFile);
            if (File.Exists(mod.PathToKeybindingsFile))
                File.Delete(mod.PathToKeybindingsFile);
            if (File.Exists(mod.PathToLocalizationFile))
                File.Delete(mod.PathToLocalizationFile);
            if (File.Exists(mod.PathToLogFile))
                File.Delete(mod.PathToLogFile);
            if (Directory.Exists(mod.PathToDataFolder))
                Directory.Delete(mod.PathToDataFolder, true);
            if (Directory.Exists(mod.PathToLevelsFolder))
                Directory.Delete(mod.PathToLevelsFolder, true);
            RemoveDlls();

            UpdateUI();

            void RemoveDlls()
            {
                if (mod.RequiredDlls == null || mod.RequiredDlls.Length == 0)
                    return;

                foreach (string dll in mod.RequiredDlls)
                {
                    if (MainForm.Instance.BlasModPage.InstalledModsThatRequireDll(dll) == 0)
                    {
                        string dllPath = MainForm.BlasRootFolder + "\\Modding\\data\\" + dll;
                        if (File.Exists(dllPath))
                            File.Delete(dllPath);
                    }
                }
            }
        }

        public void EnableMod()
        {
            if (MainForm.BlasRootFolder == null) return;

            string enabled = mod.PathToEnabledPlugin;
            string disabled = mod.PathToDisabledPlugin;
            if (File.Exists(disabled))
            {
                if (!File.Exists(enabled))
                    File.Move(disabled, enabled);
                else
                    File.Delete(disabled);
            }
        }

        public void DisableMod()
        {
            if (MainForm.BlasRootFolder == null) return;

            string enabled = mod.PathToEnabledPlugin;
            string disabled = mod.PathToDisabledPlugin;
            if (File.Exists(enabled))
            {
                if (!File.Exists(disabled))
                    File.Move(enabled, disabled);
                else
                    File.Delete(enabled);
            }
        }

        public void OpenGithubLink()
        {
            try
            {
                Process.Start(mod.GithubLink);
            }
            catch (Exception)
            {
                MessageBox.Show("Link does not exist!", "Invalid Link");
            }
        }

        // Download methods

        private WebClient client;
        private bool Downloading;

        public void StartDownload()
        {
            client = new WebClient();
            Downloading = true;
            DisplayDownloadBar();
            MainForm.Instance.DownloadMod(mod, client);
        }

        public void FinishDownload()
        {
            Downloading = false;
            client.Dispose();
            client = null;
        }

        public void CancelDownload()
        {
            if (client != null)
            {
                client.CancelAsync();
                FinishDownload();
            }
            UpdateUI();
        }

        // Click methods

        private void ClickedInstall(object sender, EventArgs e)
        {
            if (mod.Installed)
            {
                if (MessageBox.Show("Are you sure you want to uninstall this mod?", nameText.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                    UninstallMod();
            }
            else if (Downloading)
            {
                CancelDownload();
            }
            else
            {
                StartDownload();
            }
        }

        private void ClickedEnable(object sender, EventArgs e)
        {
            if (mod.Enabled)
                DisableMod();
            else
                EnableMod();

            UpdateUI();
        }

        private void ClickedInfo(object sender, EventArgs e)
        {
            OpenGithubLink();
        }

        private void ClickedUpdate(object sender, EventArgs e)
        {
            UninstallMod();
            StartDownload();
        }

        // Temp

        public void DisplayDownloadBar()
        {
            updateText.Visible = true;
            updateText.Text = "Downloading...";
            updateButton.Visible = false;

            installButton.Text = "Cancel";
            installButton.BackColor = Color.FromArgb(255, 178, 102);
            progressBar.Visible = true;
            progressBar.Value = 0;
        }

        public void UpdateDownloadBar(int percentage)
        {
            progressBar.Value = percentage;
        }

        // UI methods

        private Panel outerPanel;
        private Panel innerPanel;
        private Label nameText;
        private Label descriptionText;

        private Button infoButton;
        private Button installButton;
        private Button enableButton;

        private Label updateText;
        private Button updateButton;
        private ProgressBar progressBar;

        public void UpdateUI()
        {
            // Text
            nameText.Text = $"{mod.Name} v{(mod.Installed ? mod.LocalVersion.ToString(3) : mod.LatestVersion)}";
            //authorText.Text = "Author: " + mod.Author;
            descriptionText.Text = mod.Description;

            // Install button
            bool modInstalled = mod.Installed;
            installButton.Text = modInstalled ? "Uninstall" : "Install";
            installButton.BackColor = modInstalled ? Color.FromArgb(255, 102, 102) : Color.FromArgb(102, 255, 102);

            // Enable button
            bool modEnabled = mod.Enabled;
            enableButton.Visible = modInstalled;
            enableButton.Text = modEnabled ? "Enabled" : "Disabled";
            enableButton.ForeColor = modEnabled ? Color.Yellow : Color.White;
            enableButton.FlatAppearance.BorderColor = modEnabled ? Color.Yellow : Color.White;

            // Update text/button
            bool canUpdate = mod.UpdateAvailable;
            updateText.Visible = canUpdate;
            updateText.Text = canUpdate ? "An update is available!" : string.Empty;
            updateButton.Visible = canUpdate;
            progressBar.Visible = false;
        }

        public void CreateUI(Panel modHolder, int modIdx)
        {
            modHolder.AutoScroll = false;
            Color backgroundColor = modIdx % 2 == 0 ? Colors.DARK_GRAY : Colors.LIGHT_GRAY;

            // Panels

            outerPanel = new Panel
            {
                Name = mod.Name,
                Parent = modHolder,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Location = new Point(0, ROW_HEIGHT * modIdx),
                Size = new Size(modHolder.Width, ROW_HEIGHT + (modIdx == 0 ? 3 : 2)),
                BackColor = Color.Black,
            };

            innerPanel = new Panel
            {
                Name = mod.Name,
                Parent = outerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Location = new Point(0, modIdx == 0 ? 2 : 1),
                Size = new Size(modHolder.Width, ROW_HEIGHT - 1),
                BackColor = backgroundColor,
            };

            // Left side

            nameText = new Label
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(10, 10),
                Size = new Size(400, 28),
                ForeColor = Color.LightGray,
                Font = Fonts.LARGE,
            };

            descriptionText = new Label
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(12, 41),
                Size = new Size(450, 30),
                ForeColor = Color.LightGray,
                Font = Fonts.SMALL,
            };

            // Right side

            infoButton = new Button
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 212, 26),
                Size = new Size(42, 25),
                BackColor = Color.FromArgb(51, 153, 255),
                Font = Fonts.INSTALL,
                Text = "INFO",
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TabStop = false,
            };
            infoButton.FlatAppearance.BorderColor = Color.White;
            infoButton.Click += ClickedInfo;
            infoButton.MouseUp += MainForm.Instance.RemoveButtonFocus;
            infoButton.MouseLeave += MainForm.Instance.RemoveButtonFocus;

            installButton = new Button
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 158, 23),
                Size = new Size(70, 30),
                Font = Fonts.INSTALL,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TabStop = false
            };
            installButton.FlatAppearance.BorderColor = Color.White;
            installButton.Click += ClickedInstall;
            installButton.MouseUp += MainForm.Instance.RemoveButtonFocus;
            installButton.MouseLeave += MainForm.Instance.RemoveButtonFocus;

            enableButton = new Button
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 75, 27),
                Size = new Size(64, 22),
                BackColor = backgroundColor,
                Font = Fonts.INSTALL,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TabStop = false
            };
            enableButton.Click += ClickedEnable;
            enableButton.MouseUp += MainForm.Instance.RemoveButtonFocus;
            enableButton.MouseLeave += MainForm.Instance.RemoveButtonFocus;

            // Middle side

            updateText = new Label
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 400, 17),
                Size = new Size(200, 15),
                ForeColor = Color.LightGray,
                Font = Fonts.INSTALL,
                TextAlign = ContentAlignment.TopCenter,
                Text = string.Empty,
            };

            updateButton = new Button
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 334, 40),
                Size = new Size(72, 25),
                BackColor = Color.White,
                Font = Fonts.INSTALL,
                Text = "Download",
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            updateButton.Click += ClickedUpdate;
            updateButton.MouseUp += MainForm.Instance.RemoveButtonFocus;
            updateButton.MouseLeave += MainForm.Instance.RemoveButtonFocus;
            updateButton.TabStop = false;

            progressBar = new ProgressBar
            {
                Name = mod.Name,
                Parent = innerPanel,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(modHolder.Width - 366, 36),
                Size = new Size(130, 22),
            };

            modHolder.AutoScroll = true;
            MainForm.Instance.AdjustHolderWidth();
            UpdateUI();
        }
    }
}
