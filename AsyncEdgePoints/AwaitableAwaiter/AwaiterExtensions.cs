using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AwaitableAwaiter.Custom.Func;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter
{
    public static class AwaiterExtensions
    {
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
