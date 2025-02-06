using System.Diagnostics;
using Cpu.Monitor.App.Contants;
using Timer = System.Windows.Forms.Timer;


namespace Cpu.Monitor.App
{
    public partial class Main : Form
    {
        private Process? _selectedProcess;
        private PerformanceCounter? _cpuCounter;
        private Timer? _monitorTimer;
        private int? _maxCpuUsage;
        private MonitorForm? _monitorForm;
        public Main()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void LoadProcesses()
        {
            cmbProcesses.Items.Clear();
            object[] processes = Process.GetProcesses()
                .OrderBy(p => p.ProcessName)
                .Select(p => $"{p.ProcessName} (ID: {p.Id})")
                .ToArray();

            cmbProcesses.Items.AddRange(processes);

            cmbProcesses.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProcesses.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (cmbProcesses.SelectedItem == null)
            {
                MessageBox.Show(@"Please select a process.");
                return;
            }
            _monitorTimer = new Timer { Interval = (int)nInterval.Value };
            _monitorTimer.Tick += MonitorProcess!;
            var selectedText = cmbProcesses.SelectedItem.ToString();
            var processId = int.Parse(selectedText?.Split(["(ID: ", ")"], StringSplitOptions.None)[1] ?? string.Empty);

            try
            {
                _selectedProcess = Process.GetProcessById(processId);
                _maxCpuUsage = (int)cpuPercentLimit.Value;

                _cpuCounter = new PerformanceCounter("Process", "% Processor Time", _selectedProcess.ProcessName, true);
                _cpuCounter.NextValue(); // Initialize
                Hide();
                _monitorForm = new MonitorForm(StopMonitoring, _selectedProcess,processId,_maxCpuUsage??DefaultValues.DefaultCpuPercentLimit);
                _monitorForm.Show();
                _monitorTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error: {ex.Message}");
            }
        }
        private void MonitorProcess(object sender, EventArgs e)
        {
            try
            {
                if(_cpuCounter==null) return;
                if(_selectedProcess==null) return;
                if(_monitorForm==null) return;
                if (_selectedProcess.HasExited)
                {
                    StopMonitoring();
                    MessageBox.Show(@"The monitored process has exited.", @"Process Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var cpuUsage = _cpuCounter.NextValue() / Environment.ProcessorCount;
                _monitorForm?.UpdateCpuUsage(cpuUsage, _maxCpuUsage??DefaultValues.DefaultCpuPercentLimit);
                if (!(cpuUsage > _maxCpuUsage)) return;
                tInformation.Text = $@"{_selectedProcess.ProcessName} exceeded {_maxCpuUsage}%. Terminating process...";
                tInformation.Visible = true;
                _selectedProcess?.Kill();
                _monitorTimer?.Stop();
                StopMonitoring();
            }
            catch (Exception ex)
            {
                StopMonitoring();
            }
        }
        private void StopMonitoring()
        {
            _monitorTimer?.Stop();
            cmbProcesses.SelectedIndex = -1;
            cpuPercentLimit.Value = DefaultValues.DefaultCpuPercentLimit;
            btnMonitor.Enabled = true;
            _monitorForm?.Close();
            Visible= true;
        }
    }
}
