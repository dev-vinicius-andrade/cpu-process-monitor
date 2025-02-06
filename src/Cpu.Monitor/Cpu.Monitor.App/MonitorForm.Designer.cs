﻿namespace Cpu.Monitor.App
{
    partial class MonitorForm
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
            lblCpuUsage = new Label();
            btnStop = new Button();
            lMonitoredProcessName = new Label();
            SuspendLayout();
            // 
            // lblCpuUsage
            // 
            lblCpuUsage.Location = new Point(0, 15);
            lblCpuUsage.Name = "lblCpuUsage";
            lblCpuUsage.Size = new Size(574, 41);
            lblCpuUsage.TabIndex = 0;
            lblCpuUsage.Text = "label1";
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Bottom;
            btnStop.Location = new Point(0, 59);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(574, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lMonitoredProcessName
            // 
            lMonitoredProcessName.Dock = DockStyle.Top;
            lMonitoredProcessName.Location = new Point(0, 0);
            lMonitoredProcessName.Name = "lMonitoredProcessName";
            lMonitoredProcessName.Size = new Size(574, 15);
            lMonitoredProcessName.TabIndex = 2;
            // 
            // MonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 82);
            Controls.Add(lMonitoredProcessName);
            Controls.Add(btnStop);
            Controls.Add(lblCpuUsage);
            MaximumSize = new Size(590, 121);
            MinimumSize = new Size(590, 121);
            Name = "MonitorForm";
            Text = "MonitorForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblCpuUsage;
        private Button btnStop;
        private Label lMonitoredProcessName;
    }
}