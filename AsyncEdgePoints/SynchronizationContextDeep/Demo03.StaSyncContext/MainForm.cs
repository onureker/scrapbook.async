using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SynchronizationContextDeep.Custom2;

namespace SynchronizationContextDeep.Demo03.StaSyncContext
{
    //https://www.codeproject.com/Articles/32113/Understanding-SynchronizationContext-Part-II
    public partial class MainForm : Form
    {
        private static int mCount = 0;
        private static StaSynchronizationContext mStaSyncContext = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStaSynchronizationContext_Click(object sender, EventArgs e)
        {
            mStaSyncContext = new StaSynchronizationContext();
            for (int i = 0; i < 100; i++)
            {
                ThreadPool.QueueUserWorkItem(NonStaThread);

            }
            MessageBox.Show(@"Press any key to dispose SyncContext");
            mStaSyncContext.Dispose();
        }

        private static void NonStaThread(object state)
        {
            int id = Thread.CurrentThread.ManagedThreadId;

            for (int i = 0; i < 10; i++)
            {
                var param = new Params { OriginalThread = id, CallCounter = i };
                mStaSyncContext.Send(RunOnStaThread, param);
                Debug.Assert(param.Output == "Processed", "Unexpected behavior by STA thread");
            }
        }

        private static void RunOnStaThread(object state)
        {
            mCount++;
            Console.WriteLine(mCount);
            int id = Thread.CurrentThread.ManagedThreadId;
            var args = (Params)state;
            Trace.WriteLine("STA id " + id + " original thread " +
                            args.OriginalThread + " call count " + args.CallCounter);
            args.Output = "Processed";

        }

    }
}
