using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.ButtonAw
{
    public static class ButtonExtensions
    {
        public static SynchronizationContext UiSynchronizationContext;

        public static IAwaiter<object> GetAwaiter(this Button button)
        {
            return new ButtonAwaiter(button, UiSynchronizationContext);
        }

        public static Task<object> GetTask(this Button button)
        {
            var tcs = new TaskCompletionSource<object>();
            UiSynchronizationContext.Send(() => button.Enabled = true);
            button.Click += (sender, args) =>
            {
                tcs.SetResult(button.Tag);
                UiSynchronizationContext.Send(() => button.Enabled = false);
            };

            return tcs.Task;
        }

    }
}
