using System;
using System.Threading;

namespace AwaitableAwaiter
{
    public static class SynchronizationContextExtensions
    {
        public static void Send(this SynchronizationContext extended, Action action)
        {
            extended.Send(state => action(), null);
        }
    }
}
