using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwaitableAwaiter.Custom.ButtonAw;
using AwaitableAwaiter.Custom.Func;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter
{
    public static class AwaiterExtensions
    {
        public static IAwaiter<object> GetAwaiter(this Button button)
        {
            return new ButtonAwaiter(button);
        }

        public static IAwaiter<TResult> GetAwaiter<TResult>(this Func<TResult> function)
        {
            return new FuncAwaiter<TResult>(function);
        }

        public static TaskAwaiter GetAwaiter(this Action action)
        {
            Task task = new Task(action);
            task.Start();
            return task.GetAwaiter(); // Returns a TaskAwaiter.
        }
    }
}
