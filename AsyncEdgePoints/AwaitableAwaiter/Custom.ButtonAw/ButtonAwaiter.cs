using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.ButtonAw
{
    public class ButtonAwaiter : IAwaiter<object>
    {
        private readonly TaskCompletionSource<object> tcs;

        public ButtonAwaiter(Button button)
        {
            tcs = new TaskCompletionSource<object>();
            //button.Enabled = true;
            button.Click += ButtonOnClick;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            Button button = (Button) sender;
            tcs.SetResult(button.Tag);
            //button.Enabled = false;
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