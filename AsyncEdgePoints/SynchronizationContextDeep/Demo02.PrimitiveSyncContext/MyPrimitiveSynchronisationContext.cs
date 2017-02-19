using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SynchronizationContextDeep.Custom1
{
    class MyPrimitiveSynchronisationContext : SynchronizationContext
    {
        private bool isRunning = true;
        private readonly object syncObject = new object();
        private readonly Queue<Action> actionQueue = new Queue<Action>();

        public override void Send(SendOrPostCallback codeToRun, object state)
        {
            throw new NotImplementedException();
        }

        public override void Post(SendOrPostCallback callback, object state)
        {
            Trace.WriteLine($@"Posted message: {callback} {state}");
            lock (syncObject)
            {
                actionQueue.Enqueue(() => callback(state));
                Monitor.Pulse(syncObject);
            }
        }

        public void RunMessagePump()
        {
            while (IsRunning())
            {
                Action action = GetNextAction();
                action();
            }
        }

        private Action GetNextAction()
        {
            lock (syncObject)
            {
                while (IsRunning() && actionQueue.Count == 0)
                {
                    Monitor.Wait(syncObject);
                }
                return actionQueue.Dequeue();
            }
        }

        private bool IsRunning()
        {
            lock (syncObject)
            {
                return isRunning;
            }
        }

        public void Cancel()
        {
            lock (syncObject)
            {
                isRunning = false;
                Monitor.Pulse(syncObject);
            }
        }

    }
}
