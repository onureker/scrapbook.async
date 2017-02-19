using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SynchronizationContextDeep.Custom1;
using SynchronizationContextDeep.Custom2;

namespace SynchronizationContextDeep.Demo02.PrimitiveSyncContext
{
    //https://www.gamlor.info/wordpress/2010/10/c-5-0-async-feature-be-aware-of-the-synchronization-context/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMyPrimitiveSynchronisationContext_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($@"Form ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            var uiContext = SynchronizationContext.Current;
            MyPrimitiveSynchronisationContext customContext = new MyPrimitiveSynchronisationContext();
            SynchronizationContext.SetSynchronizationContext(customContext);
            customContext.Post(obj => MainProgramm(), null); // The first thing to process is our main application
            customContext.RunMessagePump(); // Then we kick of the message pump
            SynchronizationContext.SetSynchronizationContext(uiContext);
        }

        private async void MainProgramm()
        {
            Trace.WriteLine($@"MainProgramm ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            var client = new WebClient();
            var webContentHomePage = await client.DownloadStringTaskAsync("http://www.gamlor.info/wordpress/");
            Trace.WriteLine($"Downloaded {webContentHomePage.Length} characters, continue with the work");
            Trace.WriteLine($@"MainProgramm ThreadId: {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
