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
            this.cbAutoPermission = new System.Windows.Forms.CheckBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(249, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(267, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(249, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // labMsg
            // 
            this.labMsg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMsg.Location = new System.Drawing.Point(12, 257);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(504, 21);
            this.labMsg.TabIndex = 3;
            this.labMsg.Text = "XXX";
            this.labMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 40);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(504, 185);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.RtbLog_TextChanged);
            // 
            // cbAutoPermission
            // 
            this.cbAutoPermission.Checked = global::AutoFilePermission.Properties.Settings.Default.auto_permission;
            this.cbAutoPermission.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoFilePermission.Properties.Settings.Default, "auto_permission", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAutoPermission.Location = new System.Drawing.Point(385, 12);
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
            this.tbPath.Size = new System.Drawing.Size(367, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.Text = global::AutoFilePermission.Properties.Settings.Default._path;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 287);
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
    }
}

