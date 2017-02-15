using System;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.Func
{
    public class FuncAwaitable<TResult>: IAwaitable<TResult>
    {
        private readonly Func<TResult> func;

        public FuncAwaitable(Func<TResult> func)
        {
            this.func = func;
        }

        public IAwaiter<TResult> GetAwaiter()
        {
            return new FuncAwaiter<TResult>(func);
        }
    }
}
