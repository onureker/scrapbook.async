using System;

namespace SynchronizationContextDeep.Custom2
{
    internal interface IQueueWriter<in T> : IDisposable
    {
        void Enqueue(T data);
    }
}