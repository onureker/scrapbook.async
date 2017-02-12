using System;
using System.Diagnostics;
using System.Threading.Tasks;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.Func
{
    public class FuncAwaiter<TResult>: IAwaiter<TResult>
    {
        private readonly Task<TResult> task;

        public FuncAwaiter(Func<TResult> func)
        {
            this.task = new Task<TResult>(func);
            this.task.Start();
        }

        public bool IsCompleted
        {
            get
            {
                var taskIsCompleted = task.IsCompleted;
                Debugger.Break();
                return taskIsCompleted;
            }
        }

        public TResult GetResult()
        {
            var taskResult = task.Result;
            Debugger.Break();
            return taskResult;
        }

        public void OnCompleted(Action continuation)
        {
            Debugger.Break();
            new Task(continuation).Start();
        }
    }
}