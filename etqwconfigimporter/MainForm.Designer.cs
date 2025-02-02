namespace configimporter
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
            this.components = new System.ComponentModel.Container();
            this.txtUserPath = new System.Windows.Forms.TextBox();
            this.chkLBModDirs = new System.Windows.Forms.CheckedListBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.lblUserPath = new System.Windows.Forms.Label();
            this.lblProfiles = new System.Windows.Forms.Label();
            this.lblMods = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ttUserPath = new System.Windows.Forms.ToolTip(this.components);
            this.ttProfiles = new System.Windows.Forms.ToolTip(this.components);
            this.ttMods = new System.Windows.Forms.ToolTip(this.components);
            this.ttReset = new System.Windows.Forms.ToolTip(this.components);
            this.ttImport = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserPath
            // 
            this.txtUserPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPath.Location = new System.Drawing.Point(75, 36);
            this.txtUserPath.Name = "txtUserPath";
            this.txtUserPath.Size = new System.Drawing.Size(427, 20);
            this.txtUserPath.TabIndex = 1;
            this.txtUserPath.TextChanged += new System.EventHandler(this.txtUserPath_TextChanged);
            // 
            // chkLBModDirs
            // 
            this.chkLBModDirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLBModDirs.CheckOnClick = true;
            this.chkLBModDirs.FormattingEnabled = true;
            this.chkLBModDirs.IntegralHeight = false;
            this.chkLBModDirs.Location = new System.Drawing.Point(221, 75);
            this.chkLBModDirs.Name = "chkLBModDirs";
            this.chkLBModDirs.Size = new System.Drawing.Size(200, 134);
            this.chkLBModDirs.Sorted = true;
            this.chkLBModDirs.TabIndex = 5;
            // 
            // lbUsers
            // 
            this.lbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.IntegralHeight = false;
            this.lbUsers.Location = new System.Drawing.Point(15, 75);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(200, 134);
            this.lbUsers.Sorted = true;
            this.lbUsers.TabIndex = 3;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // lblUserPath
            // 
            this.lblUserPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserPath.AutoSize = true;
            this.lblUserPath.Location = new System.Drawing.Point(12, 39);
            this.lblUserPath.Name = "lblUserPath";
            this.lblUserPath.Size = new System.Drawing.Size(57, 13);
            this.lblUserPath.TabIndex = 0;
            this.lblUserPath.Text = "&User Path:";
            // 
            // lblProfiles
            // 
            this.lblProfiles.AutoSize = true;
            this.lblProfiles.Location = new System.Drawing.Point(12, 59);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(80, 13);
            this.lblProfiles.TabIndex = 2;
            this.lblProfiles.Text = "ETQW &Profiles:";
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Location = new System.Drawing.Point(218, 59);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(78, 13);
            this.lblMods.TabIndex = 4;
            this.lblMods.Text = "Installed &Mods:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(427, 104);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(428, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 234);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblMods);
            this.Controls.Add(this.lblProfiles);
            this.Controls.Add(this.lblUserPath);
            this.Controls.Add(this.txtUserPath);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.chkLBModDirs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ETQW Config Importer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserPath;
        private System.Windows.Forms.CheckedListBox chkLBModDirs;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label lblUserPath;
        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip ttUserPath;
        private System.Windows.Forms.ToolTip ttProfiles;
        private System.Windows.Forms.ToolTip ttMods;
        private System.Windows.Forms.ToolTip ttReset;
        private System.Windows.Forms.ToolTip ttImport;
    }
}

