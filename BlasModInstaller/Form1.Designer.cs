﻿
namespace BlasModInstaller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.blas1modScroll = new System.Windows.Forms.VScrollBar();
            this.blas1modSection = new System.Windows.Forms.Panel();
            this.blasLocButton = new System.Windows.Forms.Button();
            this.blas1locationSection = new System.Windows.Forms.Panel();
            this.blasLocFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.blasLocDialog = new System.Windows.Forms.OpenFileDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainSection = new System.Windows.Forms.Panel();
            this.titleSectionOuter = new System.Windows.Forms.Panel();
            this.titleSectionInner = new System.Windows.Forms.Panel();
            this.blas1skinSection = new System.Windows.Forms.Panel();
            this.blas1skinScroll = new System.Windows.Forms.VScrollBar();
            this.blas2modSection = new System.Windows.Forms.Panel();
            this.blas2modText = new System.Windows.Forms.Label();
            this.blas2modScroll = new System.Windows.Forms.VScrollBar();
            this.sideSectionInner = new System.Windows.Forms.Panel();
            this.warningSectionOuter = new System.Windows.Forms.Panel();
            this.warningSectionInner = new System.Windows.Forms.Panel();
            this.warningImage = new System.Windows.Forms.PictureBox();
            this.warningText = new System.Windows.Forms.Label();
            this.debugLog = new System.Windows.Forms.TextBox();
            this.blas2modsBtn = new System.Windows.Forms.Button();
            this.blas1skinsBtn = new System.Windows.Forms.Button();
            this.blas1modsBtn = new System.Windows.Forms.Button();
            this.sideSectionOuter = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.blas1modSection.SuspendLayout();
            this.blas1locationSection.SuspendLayout();
            this.mainSection.SuspendLayout();
            this.titleSectionOuter.SuspendLayout();
            this.titleSectionInner.SuspendLayout();
            this.blas1skinSection.SuspendLayout();
            this.blas2modSection.SuspendLayout();
            this.sideSectionInner.SuspendLayout();
            this.warningSectionOuter.SuspendLayout();
            this.warningSectionInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningImage)).BeginInit();
            this.sideSectionOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // blas1modScroll
            // 
            this.blas1modScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas1modScroll.Location = new System.Drawing.Point(2134, 15);
            this.blas1modScroll.Name = "blas1modScroll";
            this.blas1modScroll.Size = new System.Drawing.Size(20, 723);
            this.blas1modScroll.TabIndex = 2;
            this.blas1modScroll.Visible = false;
            // 
            // blas1modSection
            // 
            this.blas1modSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas1modSection.AutoScroll = true;
            this.blas1modSection.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.blas1modSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.blas1modSection.Controls.Add(this.blas1modScroll);
            this.blas1modSection.Location = new System.Drawing.Point(0, 60);
            this.blas1modSection.Name = "blas1modSection";
            this.blas1modSection.Size = new System.Drawing.Size(1150, 801);
            this.blas1modSection.TabIndex = 3;
            // 
            // blasLocButton
            // 
            this.blasLocButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blasLocButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blasLocButton.Location = new System.Drawing.Point(475, 375);
            this.blasLocButton.Name = "blasLocButton";
            this.blasLocButton.Size = new System.Drawing.Size(200, 50);
            this.blasLocButton.TabIndex = 7;
            this.blasLocButton.Text = "Locate Blasphemous.exe";
            this.blasLocButton.UseVisualStyleBackColor = true;
            this.blasLocButton.Click += new System.EventHandler(this.ChooseBlasLocation);
            // 
            // blas1locationSection
            // 
            this.blas1locationSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas1locationSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.blas1locationSection.Controls.Add(this.blasLocButton);
            this.blas1locationSection.Location = new System.Drawing.Point(0, 60);
            this.blas1locationSection.Name = "blas1locationSection";
            this.blas1locationSection.Size = new System.Drawing.Size(1150, 801);
            this.blas1locationSection.TabIndex = 4;
            // 
            // blasLocDialog
            // 
            this.blasLocDialog.FileName = "Blasphemous.exe";
            this.blasLocDialog.Filter = "Exe files (*.exe)|*.exe";
            this.blasLocDialog.Title = "Choose Blasphemous.exe location";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1150, 58);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Blasphemous Mods";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainSection
            // 
            this.mainSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSection.BackColor = System.Drawing.Color.White;
            this.mainSection.Controls.Add(this.titleSectionOuter);
            this.mainSection.Controls.Add(this.blas1modSection);
            this.mainSection.Controls.Add(this.blas1skinSection);
            this.mainSection.Controls.Add(this.blas1locationSection);
            this.mainSection.Controls.Add(this.blas2modSection);
            this.mainSection.Location = new System.Drawing.Point(250, 0);
            this.mainSection.Name = "mainSection";
            this.mainSection.Size = new System.Drawing.Size(1150, 900);
            this.mainSection.TabIndex = 7;
            // 
            // titleSectionOuter
            // 
            this.titleSectionOuter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleSectionOuter.BackColor = System.Drawing.Color.Black;
            this.titleSectionOuter.Controls.Add(this.titleSectionInner);
            this.titleSectionOuter.Location = new System.Drawing.Point(0, 0);
            this.titleSectionOuter.Name = "titleSectionOuter";
            this.titleSectionOuter.Size = new System.Drawing.Size(1150, 60);
            this.titleSectionOuter.TabIndex = 9;
            // 
            // titleSectionInner
            // 
            this.titleSectionInner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleSectionInner.BackColor = System.Drawing.Color.Maroon;
            this.titleSectionInner.Controls.Add(this.titleLabel);
            this.titleSectionInner.Location = new System.Drawing.Point(0, 0);
            this.titleSectionInner.Name = "titleSectionInner";
            this.titleSectionInner.Size = new System.Drawing.Size(1150, 58);
            this.titleSectionInner.TabIndex = 1;
            // 
            // blas1skinSection
            // 
            this.blas1skinSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas1skinSection.AutoScroll = true;
            this.blas1skinSection.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.blas1skinSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.blas1skinSection.Controls.Add(this.blas1skinScroll);
            this.blas1skinSection.Location = new System.Drawing.Point(0, 60);
            this.blas1skinSection.Name = "blas1skinSection";
            this.blas1skinSection.Size = new System.Drawing.Size(1150, 801);
            this.blas1skinSection.TabIndex = 5;
            // 
            // blas1skinScroll
            // 
            this.blas1skinScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas1skinScroll.Location = new System.Drawing.Point(1114, 15);
            this.blas1skinScroll.Name = "blas1skinScroll";
            this.blas1skinScroll.Size = new System.Drawing.Size(20, 740);
            this.blas1skinScroll.TabIndex = 2;
            this.blas1skinScroll.Visible = false;
            // 
            // blas2modSection
            // 
            this.blas2modSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas2modSection.AutoScroll = true;
            this.blas2modSection.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.blas2modSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.blas2modSection.Controls.Add(this.blas2modText);
            this.blas2modSection.Controls.Add(this.blas2modScroll);
            this.blas2modSection.Location = new System.Drawing.Point(0, 60);
            this.blas2modSection.Name = "blas2modSection";
            this.blas2modSection.Size = new System.Drawing.Size(1150, 801);
            this.blas2modSection.TabIndex = 4;
            // 
            // blas2modText
            // 
            this.blas2modText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blas2modText.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blas2modText.Location = new System.Drawing.Point(0, 0);
            this.blas2modText.Name = "blas2modText";
            this.blas2modText.Size = new System.Drawing.Size(1150, 801);
            this.blas2modText.TabIndex = 3;
            this.blas2modText.Text = "There is nothing here yet...";
            this.blas2modText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blas2modScroll
            // 
            this.blas2modScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blas2modScroll.Location = new System.Drawing.Point(1114, 15);
            this.blas2modScroll.Name = "blas2modScroll";
            this.blas2modScroll.Size = new System.Drawing.Size(20, 740);
            this.blas2modScroll.TabIndex = 2;
            this.blas2modScroll.Visible = false;
            // 
            // sideSectionInner
            // 
            this.sideSectionInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sideSectionInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sideSectionInner.Controls.Add(this.settingsBtn);
            this.sideSectionInner.Controls.Add(this.warningSectionOuter);
            this.sideSectionInner.Controls.Add(this.debugLog);
            this.sideSectionInner.Controls.Add(this.blas2modsBtn);
            this.sideSectionInner.Controls.Add(this.blas1skinsBtn);
            this.sideSectionInner.Controls.Add(this.blas1modsBtn);
            this.sideSectionInner.Location = new System.Drawing.Point(0, 0);
            this.sideSectionInner.Name = "sideSectionInner";
            this.sideSectionInner.Size = new System.Drawing.Size(248, 900);
            this.sideSectionInner.TabIndex = 8;
            // 
            // warningSectionOuter
            // 
            this.warningSectionOuter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningSectionOuter.BackColor = System.Drawing.Color.White;
            this.warningSectionOuter.Controls.Add(this.warningSectionInner);
            this.warningSectionOuter.Location = new System.Drawing.Point(15, 750);
            this.warningSectionOuter.Name = "warningSectionOuter";
            this.warningSectionOuter.Size = new System.Drawing.Size(220, 100);
            this.warningSectionOuter.TabIndex = 6;
            this.warningSectionOuter.Visible = false;
            // 
            // warningSectionInner
            // 
            this.warningSectionInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningSectionInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.warningSectionInner.Controls.Add(this.warningImage);
            this.warningSectionInner.Controls.Add(this.warningText);
            this.warningSectionInner.Location = new System.Drawing.Point(2, 2);
            this.warningSectionInner.Name = "warningSectionInner";
            this.warningSectionInner.Size = new System.Drawing.Size(216, 96);
            this.warningSectionInner.TabIndex = 0;
            // 
            // warningImage
            // 
            this.warningImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.warningImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.warningImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warningImage.Image = global::BlasModInstaller.Properties.Resources.warning;
            this.warningImage.Location = new System.Drawing.Point(10, 30);
            this.warningImage.Name = "warningImage";
            this.warningImage.Size = new System.Drawing.Size(36, 36);
            this.warningImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warningImage.TabIndex = 4;
            this.warningImage.TabStop = false;
            // 
            // warningText
            // 
            this.warningText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warningText.Location = new System.Drawing.Point(52, 20);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(160, 56);
            this.warningText.TabIndex = 5;
            this.warningText.Text = "A new update is available for the mod installer.  Please download it now.";
            // 
            // debugLog
            // 
            this.debugLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.debugLog.ForeColor = System.Drawing.SystemColors.Menu;
            this.debugLog.Location = new System.Drawing.Point(15, 314);
            this.debugLog.Multiline = true;
            this.debugLog.Name = "debugLog";
            this.debugLog.ReadOnly = true;
            this.debugLog.Size = new System.Drawing.Size(220, 300);
            this.debugLog.TabIndex = 0;
            // 
            // blas2modsBtn
            // 
            this.blas2modsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas2modsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas2modsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas2modsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas2modsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blas2modsBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blas2modsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blas2modsBtn.Location = new System.Drawing.Point(15, 165);
            this.blas2modsBtn.Name = "blas2modsBtn";
            this.blas2modsBtn.Size = new System.Drawing.Size(220, 35);
            this.blas2modsBtn.TabIndex = 2;
            this.blas2modsBtn.Text = "Blasphemous II Mods";
            this.blas2modsBtn.UseVisualStyleBackColor = false;
            this.blas2modsBtn.Click += new System.EventHandler(this.blas2modsBtn_Click);
            this.blas2modsBtn.MouseEnter += new System.EventHandler(this.ShowSideButtonBorder);
            this.blas2modsBtn.MouseLeave += new System.EventHandler(this.HideSideButtonBorder);
            this.blas2modsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonFocus);
            // 
            // blas1skinsBtn
            // 
            this.blas1skinsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1skinsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1skinsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1skinsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1skinsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blas1skinsBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blas1skinsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blas1skinsBtn.Location = new System.Drawing.Point(15, 120);
            this.blas1skinsBtn.Name = "blas1skinsBtn";
            this.blas1skinsBtn.Size = new System.Drawing.Size(220, 35);
            this.blas1skinsBtn.TabIndex = 1;
            this.blas1skinsBtn.Text = "Blasphemous Skins";
            this.blas1skinsBtn.UseVisualStyleBackColor = false;
            this.blas1skinsBtn.Click += new System.EventHandler(this.blas1skinsBtn_Click);
            this.blas1skinsBtn.MouseEnter += new System.EventHandler(this.ShowSideButtonBorder);
            this.blas1skinsBtn.MouseLeave += new System.EventHandler(this.HideSideButtonBorder);
            this.blas1skinsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonFocus);
            // 
            // blas1modsBtn
            // 
            this.blas1modsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1modsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1modsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1modsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.blas1modsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blas1modsBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blas1modsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blas1modsBtn.Location = new System.Drawing.Point(15, 75);
            this.blas1modsBtn.Name = "blas1modsBtn";
            this.blas1modsBtn.Size = new System.Drawing.Size(220, 35);
            this.blas1modsBtn.TabIndex = 3;
            this.blas1modsBtn.Text = "Blasphemous Mods";
            this.blas1modsBtn.UseVisualStyleBackColor = false;
            this.blas1modsBtn.Click += new System.EventHandler(this.blas1modsBtn_Click);
            this.blas1modsBtn.MouseEnter += new System.EventHandler(this.ShowSideButtonBorder);
            this.blas1modsBtn.MouseLeave += new System.EventHandler(this.HideSideButtonBorder);
            this.blas1modsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonFocus);
            // 
            // sideSectionOuter
            // 
            this.sideSectionOuter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideSectionOuter.BackColor = System.Drawing.Color.Black;
            this.sideSectionOuter.Controls.Add(this.sideSectionInner);
            this.sideSectionOuter.Location = new System.Drawing.Point(0, 0);
            this.sideSectionOuter.Name = "sideSectionOuter";
            this.sideSectionOuter.Size = new System.Drawing.Size(250, 900);
            this.sideSectionOuter.TabIndex = 9;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsBtn.Location = new System.Drawing.Point(15, 210);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(220, 35);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.MouseEnter += new System.EventHandler(this.ShowSideButtonBorder);
            this.settingsBtn.MouseLeave += new System.EventHandler(this.HideSideButtonBorder);
            this.settingsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonFocus);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.mainSection);
            this.Controls.Add(this.sideSectionOuter);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainForm";
            this.Text = "Blasphemous Mod Installer";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.blas1modSection.ResumeLayout(false);
            this.blas1locationSection.ResumeLayout(false);
            this.mainSection.ResumeLayout(false);
            this.titleSectionOuter.ResumeLayout(false);
            this.titleSectionInner.ResumeLayout(false);
            this.blas1skinSection.ResumeLayout(false);
            this.blas2modSection.ResumeLayout(false);
            this.sideSectionInner.ResumeLayout(false);
            this.sideSectionInner.PerformLayout();
            this.warningSectionOuter.ResumeLayout(false);
            this.warningSectionInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warningImage)).EndInit();
            this.sideSectionOuter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar blas1modScroll;
        private System.Windows.Forms.Panel blas1modSection;
        private System.Windows.Forms.Button blasLocButton;
        private System.Windows.Forms.FolderBrowserDialog blasLocFolderDialog;
        private System.Windows.Forms.OpenFileDialog blasLocDialog;
        private System.Windows.Forms.Panel blas1locationSection;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainSection;
        private System.Windows.Forms.Panel sideSectionInner;
        private System.Windows.Forms.Panel titleSectionOuter;
        private System.Windows.Forms.Button blas1modsBtn;
        private System.Windows.Forms.Button blas1skinsBtn;
        private System.Windows.Forms.Button blas2modsBtn;
        private System.Windows.Forms.TextBox debugLog;
        private System.Windows.Forms.Panel blas2modSection;
        private System.Windows.Forms.VScrollBar blas2modScroll;
        private System.Windows.Forms.Label blas2modText;
        private System.Windows.Forms.PictureBox warningImage;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Panel warningSectionOuter;
        private System.Windows.Forms.Panel warningSectionInner;
        private System.Windows.Forms.Panel blas1skinSection;
        private System.Windows.Forms.VScrollBar blas1skinScroll;
        private System.Windows.Forms.Panel titleSectionInner;
        private System.Windows.Forms.Panel sideSectionOuter;
        private System.Windows.Forms.Button settingsBtn;
    }
}

