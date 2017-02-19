using System;

namespace SynchronizationContextDeep.Custom2
{
    internal interface IQueueReader<out T> : IDisposable
    {
        T Dequeue();
        void ReleaseReader();
    }
}