using System.Threading;
using System.Windows.Forms;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.ButtonAw
{
    public class ButtonAwaitable: IAwaitable<object>
    {
        private readonly Button button;
        private readonly SynchronizationContext uiSynchronizationContext;

        public ButtonAwaitable(Button button, SynchronizationContext uiSynchronizationContext)
        {
            this.button = button;
            this.uiSynchronizationContext = uiSynchronizationContext;
        }

        public IAwaiter<object> GetAwaiter()
        {
            var result = new ButtonAwaiter(button, uiSynchronizationContext);
            return result;
        }
    }
}
