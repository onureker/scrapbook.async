using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.ButtonAw
{
    public class ButtonAwaiter : IAwaiter<object>
    {
        private readonly SynchronizationContext uiSynchronizationContext;
        private readonly TaskCompletionSource<object> tcs;

        public ButtonAwaiter(Button button, SynchronizationContext uiSynchronizationContext)
        {
            this.uiSynchronizationContext = uiSynchronizationContext;
            tcs = new TaskCompletionSource<object>();
            uiSynchronizationContext.Send(() => button.Enabled = true);
            button.Click += ButtonOnClick;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            Button button = (Button) sender;
            tcs.SetResult(button.Tag);
            uiSynchronizationContext.Send(() => button.Enabled = false);
            button.Click -= ButtonOnClick;
        }

        public void OnCompleted(Action continuation)
        {
            Task.Run(continuation);
        }

        public bool IsCompleted => tcs.Task.IsCompleted;

        public object GetResult() => tcs.Task.Result;
    }
}