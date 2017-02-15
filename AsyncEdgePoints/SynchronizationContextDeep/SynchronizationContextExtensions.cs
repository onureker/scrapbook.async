using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizationContextDeep
{
    //http://blog.stephencleary.com/2009/08/gotchas-from-synchronizationcontext.html
    /// <summary>
    /// Provides extension methods for <see cref="SynchronizationContext"/>.
    /// </summary>
    public static class SynchronizationContextExtensions
    {
        /// <summary>
        /// Synchronously invokes a delegate by passing it to a <see cref="SynchronizationContext"/>, waiting for it to complete.
        /// </summary>
        /// <param name="synchronizationContext">The <see cref="SynchronizationContext"/> to pass the delegate to. May not be null.</param>
        /// <param name="action">The delegate to invoke. May not be null.</param>
        /// <remarks>
        /// <para>This method is guaranteed to not be reentrant.</para>
        /// </remarks>
        public static void SafeSend(this SynchronizationContext synchronizationContext, Action action)
        {
            // The semantics of SynchronizationContext.Send allow it to invoke the delegate directly, but we can't allow that.
            Action forwardDelegate = () => synchronizationContext.Send((state) => action(), null);
            IAsyncResult result = forwardDelegate.BeginInvoke(null, null);
            result.AsyncWaitHandle.WaitOne();
        }

        /// <summary>
        /// Asynchronously invokes a delegate by passing it to a <see cref="SynchronizationContext"/>, returning immediately.
        /// </summary>
        /// <param name="synchronizationContext">The <see cref="SynchronizationContext"/> to pass the delegate to. May not be null.</param>
        /// <param name="action">The delegate to invoke. May not be null.</param>
        /// <remarks>
        /// <para>This method is guaranteed to not be reentrant.</para>
        /// </remarks>
        public static void SafePost(this SynchronizationContext synchronizationContext, Action action)
        {
            // The semantics of SynchronizationContext.Post allow it to invoke the delegate directly, but we can't allow that.
            ThreadPool.QueueUserWorkItem((state) => synchronizationContext.Post((state2) => action(), null));
        }
    }
}
