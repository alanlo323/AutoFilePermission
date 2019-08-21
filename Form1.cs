using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace AutoFilePermission
{
    public partial class Form1 : Form
    {
        FileSystemWatcher fsw;
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
            fsw.Created += fseh;
            fsw.Changed += fseh;
            fsw.Renamed += new RenamedEventHandler(FileSystemWatcherOnRenamed);
            fsw.Deleted += new FileSystemEventHandler(FileSystemWatcherOnDeleted);

            labMsg.Text = "No service is running";
            btnStop.Enabled = false;
        }

        private void FileSystemWatcherOnDeleted(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            this.Invoke((MethodInvoker)delegate
            {
                rtbLog.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + e.ChangeType + " " + path + "\n";
            });
        }

        private void FileSystemWatcherOnRenamed(object sender, RenamedEventArgs e)
        {
            string path = e.FullPath;
            try
            {
                //GrantAccess(path);
            }
            catch { }
            this.Invoke((MethodInvoker)delegate
            {
                rtbLog.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + e.ChangeType + " " + path + "\n";
            });
        }

        private void FileSystemWatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;
            try
            {
                //GrantAccess(path);
            }
            catch { }
            this.Invoke((MethodInvoker)delegate
            {
                rtbLog.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + e.ChangeType + " " + path + "\n";
            });
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
        }

        private void RtbLog_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbLog.SelectionStart = rtbLog.Text.Length;
            // scroll it automatically
            rtbLog.ScrollToCaret();
        }
    }
}
