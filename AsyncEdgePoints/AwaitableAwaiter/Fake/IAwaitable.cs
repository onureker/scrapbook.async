using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitableAwaiter.Fake
{
    public interface IAwaitable
    {
        IAwaiter GetAwaiter();
    }

    public interface IAwaitable<out TResult>
    {
        IAwaiter<TResult> GetAwaiter();
    }
}
