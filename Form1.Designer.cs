namespace AutoFilePermission
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labMsg = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.labFilesModified = new System.Windows.Forms.Label();
            this.cbShowLog = new System.Windows.Forms.CheckBox();
            this.cbAutoPermission = new System.Windows.Forms.CheckBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.labLastRecorded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 265);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(277, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(295, 265);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(277, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // labMsg
            // 
            this.labMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMsg.Location = new System.Drawing.Point(12, 291);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(560, 21);
            this.labMsg.TabIndex = 3;
            this.labMsg.Text = "XXX";
            this.labMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 40);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(560, 185);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RtbLog_LinkClicked);
            this.rtbLog.TextChanged += new System.EventHandler(this.RtbLog_TextChanged);
            // 
            // labFilesModified
            // 
            this.labFilesModified.Font = new System.Drawing.Font("Calibri", 12F);
            this.labFilesModified.Location = new System.Drawing.Point(90, 233);
            this.labFilesModified.Name = "labFilesModified";
            this.labFilesModified.Size = new System.Drawing.Size(199, 23);
            this.labFilesModified.TabIndex = 7;
            this.labFilesModified.Text = "XXX";
            this.labFilesModified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbShowLog
            // 
            this.cbShowLog.AutoSize = true;
            this.cbShowLog.Checked = global::AutoFilePermission.Properties.Settings.Default.show_log;
            this.cbShowLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowLog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoFilePermission.Properties.Settings.Default, "show_log", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowLog.Location = new System.Drawing.Point(12, 237);
            this.cbShowLog.Name = "cbShowLog";
            this.cbShowLog.Size = new System.Drawing.Size(72, 16);
            this.cbShowLog.TabIndex = 6;
            this.cbShowLog.Text = "Show Log";
            this.cbShowLog.UseVisualStyleBackColor = true;
            this.cbShowLog.CheckedChanged += new System.EventHandler(this.CbShowLog_CheckedChanged);
            // 
            // cbAutoPermission
            // 
            this.cbAutoPermission.Checked = global::AutoFilePermission.Properties.Settings.Default.auto_permission;
            this.cbAutoPermission.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoFilePermission.Properties.Settings.Default, "auto_permission", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAutoPermission.Location = new System.Drawing.Point(441, 12);
            this.cbAutoPermission.Name = "cbAutoPermission";
            this.cbAutoPermission.Size = new System.Drawing.Size(131, 22);
            this.cbAutoPermission.TabIndex = 5;
            this.cbAutoPermission.Text = "Auto Give Full Access";
            this.cbAutoPermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAutoPermission.UseVisualStyleBackColor = true;
            this.cbAutoPermission.CheckedChanged += new System.EventHandler(this.CbAutoPermission_CheckedChanged);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(423, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.Text = global::AutoFilePermission.Properties.Settings.Default._path;
            // 
            // labLastRecorded
            // 
            this.labLastRecorded.AutoEllipsis = true;
            this.labLastRecorded.Font = new System.Drawing.Font("Calibri", 12F);
            this.labLastRecorded.Location = new System.Drawing.Point(295, 233);
            this.labLastRecorded.Name = "labLastRecorded";
            this.labLastRecorded.Size = new System.Drawing.Size(277, 23);
            this.labLastRecorded.TabIndex = 8;
            this.labLastRecorded.Text = "XXX";
            this.labLastRecorded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.labLastRecorded);
            this.Controls.Add(this.labFilesModified);
            this.Controls.Add(this.cbShowLog);
            this.Controls.Add(this.cbAutoPermission);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "AutoFilePermission";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.CheckBox cbAutoPermission;
        private System.Windows.Forms.CheckBox cbShowLog;
        private System.Windows.Forms.Label labFilesModified;
        private System.Windows.Forms.Label labLastRecorded;
    }
}

