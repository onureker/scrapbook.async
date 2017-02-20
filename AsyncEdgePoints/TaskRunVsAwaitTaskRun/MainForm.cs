using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRunVsAwaitTaskRun
{
    //http://stackoverflow.com/questions/21033150/any-difference-between-await-task-run-return-and-return-task-run
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTaskRunReturn_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 1000).Select(i => i.ToString()).ToList().ForEach(message => LogTraceWithReturn(message));
            MessageBox.Show("OK");
        }

        private void btnTaskRunAwait_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 1000).Select(i => i.ToString()).ToList().ForEach(message => LogTraceWithAwait(message));
            MessageBox.Show("OK");
        }

        public Task LogTraceWithReturn(string message)
        {
            return Task.Run(() =>
            {
                Trace.WriteLine(message);
            });
        }

        public async Task LogTraceWithAwait(string message)
        {
            await Task.Run(() =>
            {
                Trace.WriteLine(message);
            });
        }

    }
}
