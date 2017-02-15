using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RuntimeContext.Extensions
{
    public static class ActionExtensions
    {
        public static Task InvokeWith(this Action action, SynchronizationContext synchronizationContext, ExecutionContext executionContext)
        {
            var func = new Func<object>(() =>
            {
                action();
                return null;
            });

            var result = func.InvokeWith(synchronizationContext, executionContext);
            return result;
        }
    }
}
