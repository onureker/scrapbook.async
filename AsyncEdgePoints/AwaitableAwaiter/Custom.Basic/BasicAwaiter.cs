using System;
using System.Diagnostics;
using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.Basic
{
    public struct BasicAwaiter: IAwaiter
    {
        public void OnCompleted(Action continuation)
        {
            Debugger.Break();
            Console.WriteLine(continuation);
        }

        public bool IsCompleted => true;
        public void GetResult()
        {
            Debugger.Break();
        }
    }
}