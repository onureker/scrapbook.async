﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RuntimeContext.Disassembled
{
    //https://www.codeproject.com/Articles/31971/Understanding-SynchronizationContext-Part-I
    internal struct SynchronizationContextSwitcher : IDisposable
    {
        internal SynchronizationContext savedSC;
        internal SynchronizationContext currSC;
        internal ExecutionContext _ec;

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is SynchronizationContextSwitcher))
                return false;
            SynchronizationContextSwitcher sw = (SynchronizationContextSwitcher)obj;
            return (this.savedSC == sw.savedSC &&
                    this.currSC == sw.currSC && this._ec == sw._ec);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(SynchronizationContextSwitcher c1,
                                       SynchronizationContextSwitcher c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(SynchronizationContextSwitcher c1,
                                       SynchronizationContextSwitcher c2)
        {
            return !c1.Equals(c2);
        }

        void IDisposable.Dispose()
        {
            Undo();
        }

        internal bool UndoNoThrow()
        {
            if (_ec == null)
            {
                return true;
            }

            try
            {
                Undo();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Undo()
        {
            if (_ec == null)
            {
                return;
            }

            ExecutionContext executionContext =
              Thread.CurrentThread.GetExecutionContextNoCreate();
            if (_ec != executionContext)
            {
                throw new InvalidOperationException(Environment.GetResourceString(
                          "InvalidOperation_SwitcherCtxMismatch"));
            }
            if (currSC != _ec.SynchronizationContext)
            {
                throw new InvalidOperationException(Environment.GetResourceString(
                          "InvalidOperation_SwitcherCtxMismatch"));
            }
            BCLDebug.Assert(executionContext != null, " ExecutionContext can't be null");
            // restore the Saved Sync context as current
            executionContext.SynchronizationContext = savedSC;
            // can't reuse this anymore
            _ec = null;
        }
    }

    public delegate void SendOrPostCallback(Object state);

    [Flags]
    enum SynchronizationContextProperties
    {
        None = 0,
        RequireWaitNotification = 0x1
    };

    public class SynchronizationContext
    {
        SynchronizationContextProperties _props = SynchronizationContextProperties.None;

        public SynchronizationContext()
        {
        }

        // protected so that only the derived sync
        // context class can enable these flags
        protected void SetWaitNotificationRequired()
        {
            // Prepare the method so that it can be called
            // in a reliable fashion when a wait is needed.
            // This will obviously only make the Wait reliable
            // if the Wait method is itself reliable. The only thing
            // preparing the method here does is to ensure there
            // is no failure point before the method execution begins.

            RuntimeHelpers.PrepareDelegate(new WaitDelegate(this.Wait));
            _props |= SynchronizationContextProperties.RequireWaitNotification;
        }

        public bool IsWaitNotificationRequired()
        {
            return ((_props &
              SynchronizationContextProperties.RequireWaitNotification) != 0);
        }

        public virtual void Send(SendOrPostCallback d, Object state)
        {
            d(state);
        }

        public virtual void Post(SendOrPostCallback d, Object state)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(d), state);
        }

        public virtual void OperationStarted()
        {
        }

        public virtual void OperationCompleted()
        {
        }

        // Method called when the CLR does a wait operation
        public virtual int Wait(IntPtr[] waitHandles,
                       bool waitAll, int millisecondsTimeout)
        {
            return WaitHelper(waitHandles, waitAll, millisecondsTimeout);
        }

        // Static helper to which the above method
        // can delegate to in order to get the default
        // COM behavior.
        protected static extern int WaitHelper(IntPtr[] waitHandles,
                         bool waitAll, int millisecondsTimeout);

        // set SynchronizationContext on the current thread
        public static void SetSynchronizationContext(SynchronizationContext syncContext)
        {
            SetSynchronizationContext(syncContext,
              Thread.CurrentThread.ExecutionContext.SynchronizationContext);
        }

        internal static SynchronizationContextSwitcher
          SetSynchronizationContext(SynchronizationContext syncContext,
          SynchronizationContext prevSyncContext)
        {
            // get current execution context
            ExecutionContext ec = Thread.CurrentThread.ExecutionContext;
            // create a switcher
            SynchronizationContextSwitcher scsw = new SynchronizationContextSwitcher();

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                // attach the switcher to the exec context
                scsw._ec = ec;
                // save the current sync context using the passed in value
                scsw.savedSC = prevSyncContext;
                // save the new sync context also
                scsw.currSC = syncContext;
                // update the current sync context to the new context
                ec.SynchronizationContext = syncContext;
            }
            catch
            {
                // Any exception means we just restore the old SyncCtx
                scsw.UndoNoThrow(); //No exception will be thrown in this Undo()
                throw;
            }
            // return switcher
            return scsw;
        }

        // Get the current SynchronizationContext on the current thread
        public static SynchronizationContext Current
        {
            get
            {
                ExecutionContext ec = Thread.CurrentThread.GetExecutionContextNoCreate();
                if (ec != null)
                    return ec.SynchronizationContext;
                return null;
            }
        }

        // helper to Clone this SynchronizationContext,
        public virtual SynchronizationContext CreateCopy()
        {
            // the CLR dummy has an empty clone function - no member data
            return new SynchronizationContext();
        }

        private static int InvokeWaitMethodHelper(SynchronizationContext syncContext,
            IntPtr[] waitHandles,
            bool waitAll,
            int millisecondsTimeout)
        {
            return syncContext.Wait(waitHandles, waitAll, millisecondsTimeout);
        }
    }
}