using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _0101SP
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        DateTime startTime = DateTime.Now;

        Process? notepadProcess = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (notepadProcess is null)
            {
                notepadProcess = Process.Start("notepad.exe");
                Thread.Sleep(100);
                SetWindowText(notepadProcess.MainWindowHandle, timeLabel.Text);
            }

            else
            {
                MessageBox.Show("The process has\nalready started", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            notepadProcess?.Kill();
            notepadProcess = null;
        }

        private void timerTick(object sender, EventArgs e)
        {
            this.timeLabel.Text = (DateTime.Now - startTime).ToString().Substring(0, 8);

            if (notepadProcess is not null)
            {
                SetWindowText(notepadProcess.MainWindowHandle, timeLabel.Text);
            }
        }
    }
}