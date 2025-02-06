using Cpu.Monitor.App.Contants;

namespace Cpu.Monitor.App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefresh = new Button();
            btnMonitor = new Button();
            cpuPercentLimit = new NumericUpDown();
            label1 = new Label();
            nInterval = new NumericUpDown();
            label2 = new Label();
            nDelay = new NumericUpDown();
            label3 = new Label();
            tInformation = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbProcesses = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)cpuPercentLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nDelay).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(693, 39);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnMonitor
            // 
            btnMonitor.Location = new Point(693, 169);
            btnMonitor.Name = "btnMonitor";
            btnMonitor.Size = new Size(75, 23);
            btnMonitor.TabIndex = 2;
            btnMonitor.Text = "Monitor";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += btnMonitor_Click;
            // 
            // cpuPercentLimit
            // 
            cpuPercentLimit.Location = new Point(536, 81);
            cpuPercentLimit.Name = "cpuPercentLimit";
            cpuPercentLimit.Size = new Size(120, 23);
            cpuPercentLimit.TabIndex = 3;
            cpuPercentLimit.Value = new decimal(new int[] { 95, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 85);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 4;
            label1.Text = "Cpu Percentage Limit:";
            // 
            // nInterval
            // 
            nInterval.Location = new Point(536, 110);
            nInterval.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nInterval.Name = "nInterval";
            nInterval.Size = new Size(120, 23);
            nInterval.TabIndex = 5;
            nInterval.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 118);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Interval:";
            // 
            // nDelay
            // 
            nDelay.Location = new Point(536, 139);
            nDelay.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nDelay.Name = "nDelay";
            nDelay.Size = new Size(120, 23);
            nDelay.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Start Delay:";
            // 
            // tInformation
            // 
            tInformation.Dock = DockStyle.Bottom;
            tInformation.Location = new Point(0, 195);
            tInformation.Name = "tInformation";
            tInformation.Size = new Size(800, 23);
            tInformation.TabIndex = 9;
            tInformation.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(662, 118);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 10;
            label4.Text = "ms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(662, 147);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 11;
            label5.Text = "ms";
            // 
            // cmbProcesses
            // 
            cmbProcesses.FormattingEnabled = true;
            cmbProcesses.Location = new Point(26, 40);
            cmbProcesses.Name = "cmbProcesses";
            cmbProcesses.Size = new Size(630, 23);
            cmbProcesses.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 22);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 13;
            label6.Text = "Find your process:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(662, 85);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 16;
            label7.Text = "%";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 218);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbProcesses);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tInformation);
            Controls.Add(label3);
            Controls.Add(nDelay);
            Controls.Add(label2);
            Controls.Add(nInterval);
            Controls.Add(label1);
            Controls.Add(cpuPercentLimit);
            Controls.Add(btnMonitor);
            Controls.Add(btnRefresh);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)cpuPercentLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)nDelay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRefresh;
        private Button btnMonitor;
        private NumericUpDown cpuPercentLimit;
        private Label label1;
        private NumericUpDown nInterval;
        private Label label2;
        private NumericUpDown nDelay;
        private Label label3;
        private TextBox tInformation;
        private Label label4;
        private Label label5;
        private ComboBox cmbProcesses;
        private Label label6;
        private Label label7;
    }
}
