using System.Diagnostics;

namespace Cpu.Monitor.App
{
    public partial class MonitorForm : Form
    {
        private readonly Action _stopMonitoringCallback;
        private readonly int _processId;
        private readonly int _maxCpuUsage;

        public MonitorForm(Action stopMonitoring, Process selectedProcess, int processId, int maxCpuUsage)
        {
            InitializeComponent();
            _stopMonitoringCallback = stopMonitoring;
            _processId = processId;
            _maxCpuUsage = maxCpuUsage;

            lMonitoredProcessName.Text = $@"Monitoring {selectedProcess.ProcessName} (ID: {processId}) for CPU limit: {maxCpuUsage}%";
        }

        public void UpdateCpuUsage(float cpuUsage, int maxCpuUsage)
        {

            lblCpuUsage.Text = $@"{cpuUsage:F2}%";

            if (cpuUsage < maxCpuUsage * 0.7)
            {
                lblCpuUsage.BackColor = Color.Green;
                lblCpuUsage.ForeColor = Color.White;
            }
            else if (cpuUsage < maxCpuUsage)
            {
                lblCpuUsage.BackColor = Color.Yellow;
                lblCpuUsage.ForeColor = Color.Black;
            }
            else
            {
                lblCpuUsage.BackColor = Color.Red;
                lblCpuUsage.ForeColor = Color.White;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _stopMonitoringCallback?.Invoke();
            this.Close();
        }
    }

}
