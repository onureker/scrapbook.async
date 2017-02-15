using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SynchronizationContextDeep.Custom2;

namespace SynchronizationContextDeep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //https://www.codeproject.com/Articles/31971/Understanding-SynchronizationContext-Part-I
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
            for (int i = 0; i < 1000; i++)
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

        //https://www.gamlor.info/wordpress/2010/10/c-5-0-async-feature-be-aware-of-the-synchronization-context/
        private void btnMyPrimitiveSynchronisationContext_Click(object sender, EventArgs e)
        {
            var uiContext = SynchronizationContext.Current;
            MyPrimitiveSynchronisationContext customContext = new MyPrimitiveSynchronisationContext();
            SynchronizationContext.SetSynchronizationContext(customContext);
            customContext.Post(obj => MainProgramm(), null); // The first thing to process is our main application
            customContext.RunMessagePump(); // Then we kick of the message pump
            SynchronizationContext.SetSynchronizationContext(uiContext);
        }

        private async void MainProgramm()
        {
            Trace.WriteLine($@"We are on Thread No {Thread.CurrentThread.ManagedThreadId}");
            var client = new WebClient();
            var webContentHomePage = await client.DownloadStringTaskAsync("http://www.gamlor.info/wordpress/");
            Trace.WriteLine($"Downloaded {webContentHomePage.Length} characters, continue with the work");
            Trace.WriteLine($"We are on Thread No {Thread.CurrentThread.ManagedThreadId} ");
        }

        //https://www.codeproject.com/Articles/32113/Understanding-SynchronizationContext-Part-II
        private static int mCount = 0;
        private static StaSynchronizationContext mStaSyncContext = null;
        private void btnStaSynchronizationContext_Click(object sender, EventArgs e)
        {
            mStaSyncContext = new StaSynchronizationContext();
            for (int i = 0; i < 100; i++)
            {
                ThreadPool.QueueUserWorkItem(NonStaThread);

            }
            Console.WriteLine("Processing");
            Console.WriteLine("Press any key to dispose SyncContext");
            Console.ReadLine();
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

        private void btnWCFSynchronizationContext_Click(object sender, EventArgs e)
        {
            //TODO:
            //https://www.codeproject.com/Articles/32119/Understanding-SynchronizationContext-Part-III
        }
    }
}
