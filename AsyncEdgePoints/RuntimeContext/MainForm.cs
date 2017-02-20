using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuntimeContext.Extensions;

namespace RuntimeContext
{
    //TODO: https://nirmalyabhattacharyya.com/2013/08/31/executioncontext-synchronizationcontext-and-callcontext/   
    //TODO: https://blogs.msdn.microsoft.com/pfxteam/2012/06/15/executioncontext-vs-synchronizationcontext/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWithExecutionContext_Click(object sender, EventArgs e)
        {
            ExecutionContext executionContext = ExecutionContext.Capture();
            Func<string> func = () => "Onur";
            var result = func.InvokeWith(executionContext);
            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SynchronizationContext synchronizationContext = SynchronizationContext.Current;
            ExecutionContext executionContext = ExecutionContext.Capture();
            Func<string> func = () => "Onur";
            var task = func.InvokeWith(synchronizationContext, executionContext);
            MessageBox.Show(task.Result);
        }
    }
}
