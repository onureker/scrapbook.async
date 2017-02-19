using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SynchronizationContextDeep.Demo01.InvokeBy
{
    //https://www.codeproject.com/Articles/31971/Understanding-SynchronizationContext-Part-I
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnSynchronizationContext_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($"Btn Click: {Thread.CurrentThread.ManagedThreadId}");
            SynchronizationContext uiContext = SynchronizationContext.Current;
            Thread thread = new Thread(RunOnThread);
            thread.Start(uiContext);
        }

        private void RunOnThread(object obj)
        {
            Trace.WriteLine($"RunOnThread: {Thread.CurrentThread.ManagedThreadId}");
            SynchronizationContext uiContext = (SynchronizationContext)obj;
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                //uiContext.Send(UpdateUi, "Line " + i); // synchronous
                uiContext.Post(UpdateUi, "Line " + i); // asynchronous
            }
        }

        private void UpdateUi(object state)
        {
            Trace.WriteLine($"UpdateUI: {Thread.CurrentThread.ManagedThreadId}");
            string text = (string)state;
            lbSynchronizationContext.Items.Add(text);
        }

    }
}
