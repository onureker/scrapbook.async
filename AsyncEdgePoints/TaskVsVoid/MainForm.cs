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

namespace TaskVsVoid
{
    //http://stackoverflow.com/questions/12144077/async-await-when-to-return-a-task-vs-void
    //TODO: TaskScheduler.UnobservedTaskException için yeni bir edge point projesi yap
    //http://stackoverflow.com/questions/3284137/taskscheduler-unobservedtaskexception-event-handler-never-being-triggered
    //http://stackoverflow.com/questions/23504664/system-threading-task-why-does-taskscheduler-unobservedtaskexception-event-not
    //http://www.jaylee.org/post/2012/07/08/c-sharp-async-tips-and-tricks-part-2-async-void.aspx
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;
        }

        private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs eventArgs)
        {
            Debugger.Break();
            eventArgs.SetObserved();
            eventArgs.Exception.Handle(ex =>
            {
                Console.WriteLine("Exception type: {0}", ex.GetType());
                return true;
            });
        }

        private async void RunWithVoid()
        {
            //Bu uygulamanın crash olmasına sebep olur..
            await ThrowException();
        }

        private async Task RunWithTask()
        {
            // Bu sadece unobserved exception fırlatır
            await ThrowException();
        }

        private async Task ThrowException()
        {
            throw new NotImplementedException();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            RunWithVoid();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            RunWithTask();
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
