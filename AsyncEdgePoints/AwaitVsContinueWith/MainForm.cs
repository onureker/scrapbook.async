using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitVsContinueWith
{
    //https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-3-runtime-context
    public partial class MainForm : Form
    {
        private readonly WebClient webClient;

        public MainForm()
        {
            webClient = new WebClient();
            InitializeComponent();
        }

        //Ok because the await infrastructure resolves the cross-thread issue, 
        //marshaling the continuation code back to the initially captured ExecutionContext and SynchronizationContext.
        private async void btnAwaited_Click(object sender, EventArgs e)
        {
            tbResult.Text = @"Waiting...";
            string html = await webClient.DownloadStringTaskAsync("https://weblogs.asp.net/dixin");
            tbResult.Text = html.Substring(1, 5);
            GC.Collect();
        }

        //System.InvalidOperationException occurs
        //because when the callback code is scheduled to a non-UI thread in the thread pool, it cannot access the UI controls
        private async void btnContinueWith_Click(object sender, EventArgs e)
        {
            try
            {
                tbResult.Text = @"Waiting...";
                Task<string> task = webClient.DownloadStringTaskAsync("https://weblogs.asp.net/dixin");
                Task otherTask = task.ContinueWith(prev =>
                {
                    string html = prev.Result;
                    tbResult.Text = html;
                });
                await otherTask;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
