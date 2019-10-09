using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace AutoFilePermission
{
    public partial class Form1 : Form
    {
        readonly string FILES_MODIFIED = "Files modified";
        readonly string LAST_RECORDED = "Last recorded";

        FileSystemWatcher fsw;
        int filesModified = 0;
        string datetimeFormate = "yyyy-MM-dd HH:mm:ss";
        DateTime lastRecorded;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximumSize = MinimumSize = this.Size;
            MaximizeBox = false;
            fsw = new FileSystemWatcher
            {
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName,
                IncludeSubdirectories = true,
            };
            FileSystemEventHandler fseh = new FileSystemEventHandler(FileSystemWatcherOnChanged);
            fsw.Changed += fseh;
            fsw.Created += fseh;
            fsw.Renamed += new RenamedEventHandler(FileSystemWatcherOnRenamed);
            fsw.Deleted += new FileSystemEventHandler(FileSystemWatcherOnDeleted);

            labMsg.Text = "No service is running";
            labFilesModified.Text = FILES_MODIFIED + " : " + filesModified ;
            labLastRecorded.Text = LAST_RECORDED + " : " + "No record";
            btnStop.Enabled = false;
        }

        private void FileSystemWatcherOnDeleted(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            this.Invoke((MethodInvoker)delegate
            {
                AppendFilesLog(path, e.ChangeType);
            });
        }

        private void FileSystemWatcherOnRenamed(object sender, RenamedEventArgs e)
        {
            string path = e.FullPath;
            try
            {
                if (cbAutoPermission.Checked)
                {
                    GrantAccess(path);
                }
            }
            catch { }
            this.Invoke((MethodInvoker)delegate
            {
                AppendFilesLog(path, e.ChangeType);
            });
        }

        private void FileSystemWatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            try
            {
                if (cbAutoPermission.Checked)
                {
                    GrantAccess(path);
                }
            }
            catch { }
            this.Invoke((MethodInvoker)delegate
            {
                AppendFilesLog(path, e.ChangeType);
            });
        }
        private void AppendFilesLog(string path, WatcherChangeTypes changeTypes)
        {
            lastRecorded = DateTime.Now;
            labFilesModified.Text = FILES_MODIFIED + " : " + filesModified;
            labLastRecorded.Text = LAST_RECORDED + " : " + lastRecorded.ToString(datetimeFormate);

            if (cbShowLog.Checked)
            {
                rtbLog.SelectionColor = Color.Black;
                rtbLog.SelectedText += DateTime.Now.ToString(datetimeFormate) + " ";
                switch (changeTypes)
                {
                    case WatcherChangeTypes.Created:
                        rtbLog.SelectionColor = Color.Green;
                        break;
                    case WatcherChangeTypes.Deleted:
                        rtbLog.SelectionColor = Color.Red;
                        break;
                    case WatcherChangeTypes.Changed:
                        rtbLog.SelectionColor = Color.DarkGray;
                        break;
                    case WatcherChangeTypes.Renamed:
                        rtbLog.SelectionColor = Color.Blue;
                        break;
                    case WatcherChangeTypes.All:
                        break;
                    default:
                        break;
                }
                rtbLog.SelectedText += changeTypes;
                rtbLog.SelectionColor = Color.Black;
                rtbLog.SelectedText += " file://" + path + "\n";
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string path = tbPath.Text;
            if (!String.IsNullOrWhiteSpace(path) && Directory.Exists(path))
            {
                fsw.Path = path;
                fsw.EnableRaisingEvents = true;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                Properties.Settings.Default._path = path;
                Properties.Settings.Default.Save();
                labMsg.Text = "Watching: " + path;
            }
            else
            {
                MessageBox.Show("Directory do not exist!");
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            labMsg.Text = "No service is running";
        }

        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
            filesModified++;
        }

        private void RtbLog_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbLog.SelectionStart = rtbLog.Text.Length;
            // scroll it automatically
            rtbLog.ScrollToCaret();
        }

        private void CbAutoPermission_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.auto_permission = cbAutoPermission.Checked;
            Properties.Settings.Default.Save();
        }

        private void RtbLog_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception) { }
        }

        private void CbShowLog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.show_log = cbShowLog.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
