using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace configimporter
{
    public partial class MainForm : Form
    {
        private ETQWData data;
        private string currentUsername;

        public MainForm()
        {
            InitializeComponent();
            InitTooltips();
            Init();
        }

        private void InitTooltips()
        {
            ttUserPath.SetToolTip(lblUserPath, "Select your ETQW User Path. Where the configs are saved.");
            ttProfiles.SetToolTip(lblProfiles, "Select the ETQW Profile you'd like to work with.");
            ttMods.SetToolTip(lblMods, "Select which mod(s) you'd like to import BaseETQW configs to.");
            ttReset.SetToolTip(btnReset, "Reset the User Path to default and re-detect all settings.");
            ttImport.SetToolTip(btnImport, "Import BaseETQW settings into the selected mod(s).");
        }

        private void Init()
        {
            toolStripStatusLabel1.Text = "Ready";
            data = new ETQWData();
            txtUserPath.Text = data.UserPath;

            SearchUsers();
            //SearchMods();
        }

        private void SearchUsers()
        {
            lbUsers.Items.Clear();
            chkLBModDirs.Items.Clear();

            List<PathContents> results = data.getPathData(ETQWPath.USERPATH, "sdnet", null);

            foreach (PathContents result in results)
            {
                lbUsers.Items.Add(result);
            }
            if (results.Count == 1)
            {
                lbUsers.SelectedIndex = 0;
                toolStripStatusLabel1.Text = "Ready";
            }
            else
            {
                lbUsers.SelectedIndex = -1;
                toolStripStatusLabel1.Text = "Unable to find valid ETQW Profile(s). Current User Path may be invalid";
            }
        }

        private void SearchMods()
        {
            if (currentUsername == null || currentUsername.Equals(""))
            {
                toolStripStatusLabel1.Text = "No ETQW Profile selected";
                return;
            }

            chkLBModDirs.Items.Clear();

            List<PathContents> results = data.getPathData(ETQWPath.USERPATH, "sdnet" + System.IO.Path.DirectorySeparatorChar + currentUsername, null);

            foreach (PathContents result in results)
            {
                if (!result.Filename.Equals("base"))
                {
                    chkLBModDirs.Items.Add(result);
                }
            }
            if (results.Count > 0)
            {
                toolStripStatusLabel1.Text = "Ready";
            }
            else
            {
                toolStripStatusLabel1.Text = "No mods found";
            }
        }

        private bool Import()
        {
            bool bAnyErrors = false;

            if ( chkLBModDirs.CheckedItems.Count == 0)
            {
                toolStripStatusLabel1.Text = "No mods selected";
                bAnyErrors = true;
                return bAnyErrors;
            }

            List<PathContents> baseFiles = data.getPathData(ETQWPath.USERPATH, "sdnet" + System.IO.Path.DirectorySeparatorChar + currentUsername + System.IO.Path.DirectorySeparatorChar + "base", "*.cfg");

            foreach (PathContents item in chkLBModDirs.CheckedItems)
            {
                StringBuilder modPath = new StringBuilder(item.FullPath);
                foreach(PathContents file in baseFiles)
                {
                    StringBuilder destFile = new StringBuilder(modPath.ToString());
                    destFile.Append(System.IO.Path.DirectorySeparatorChar);
                    destFile.Append(file.Filename);

                    bool retry = false;
                    do
                    {
                        retry = false;

                        try
                        {
                            System.IO.File.Copy(file.FullPath, destFile.ToString(), true);
                        }
                        catch (Exception ex)
                        {
                           switch (MessageBox.Show("Error during copy:" +
                                Environment.NewLine + file.FullPath +
                                Environment.NewLine + destFile.ToString() +
                                Environment.NewLine + ex.Message, "Error!",
                                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                            {
                                case DialogResult.Abort:
                                    toolStripStatusLabel1.Text = "Aborted copying due to error(s)";
                                    bAnyErrors = true;
                                    return bAnyErrors;
                                case DialogResult.Retry:
                                    retry = true;
                                    break;
                                case DialogResult.Ignore:
                                    toolStripStatusLabel1.Text = "Ignored error(s) during copy";
                                    bAnyErrors = true;
                                    break;
                                default:
                                    toolStripStatusLabel1.Text = "Unknown error during copy";
                                    bAnyErrors = true;
                                    break;
                            }
                        }
                    } while (retry);
                }
            }

            return bAnyErrors;
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex == -1)
            {
                currentUsername = "";
            }
            else
            {
                currentUsername = lbUsers.SelectedItem.ToString();
            }
            SearchMods();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(lbUsers.SelectedItem == null)
            {
                toolStripStatusLabel1.Text = "No ETQW Profile selected";
                return;
            }
            if (chkLBModDirs.Items.Count == 0)
            {
                toolStripStatusLabel1.Text = "No mods found";
                return;
            }
            if (chkLBModDirs.CheckedItems.Count == 0)
            {
                toolStripStatusLabel1.Text = "No mods selected";
                return;
            }

            if (!Import())
            {
                toolStripStatusLabel1.Text = "Configs imported successfully.";
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void txtUserPath_TextChanged(object sender, EventArgs e)
        {
            if (!data.UserPath.Equals(txtUserPath.Text))
            {
                data.UserPath = txtUserPath.Text;
                
            }
            SearchUsers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            data.DetectPaths();
            txtUserPath.Text = data.UserPath;
            toolStripStatusLabel1.Text = "Ready";
            SearchUsers();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ETQW Config Importer v0.1\nBy Azuvector\n\nTry Quake Wars: Tactical Assault!\nhttp://qwta.moddb.com", "About ETQW Config Importer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
