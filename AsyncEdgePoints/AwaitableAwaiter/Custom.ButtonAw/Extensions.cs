using System.Threading;
using System.Windows.Forms;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.ButtonAw
{
    public static class Extensions
    {
        public static IAwaitable<object> AsAwaitable(this Button button, SynchronizationContext uiSynchronizationContext)
        {
            return new ButtonAwaitable(button, uiSynchronizationContext);
        }

    }
}
