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
    //https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-3-runtime-context
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Ok because the await infrastructure resolves the cross-thread issue, 
        //marshaling the continuation code back to the initially captured ExecutionContext and SynchronizationContext.
        private async void btnAwaited_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            string html = await new WebClient().DownloadStringTaskAsync("https://weblogs.asp.net/dixin");
            textBox1.Text = html.Substring(1, 5);
        }

        //System.InvalidOperationException occurs
        //because when the callback code is scheduled to a non-UI thread in the thread pool, it cannot access the UI controls
        private void btnContinueWith_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = string.Empty;
                new WebClient().DownloadStringTaskAsync("https://weblogs.asp.net/dixin").ContinueWith(task =>
                {
                    string html = task.Result;
                    textBox1.Text = html;
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
