using System.Runtime.CompilerServices;

namespace AwaitableAwaiter.Fake
{
    public interface IAwaiter : INotifyCompletion // or ICriticalNotifyCompletion
    {
        // INotifyCompletion has one method: void OnCompleted(Action continuation);

        // ICriticalNotifyCompletion implements INotifyCompletion,
        // also has this method: void UnsafeOnCompleted(Action continuation);

        bool IsCompleted { get; }

        void GetResult();
    }


    public interface IAwaiter<out TResult> : INotifyCompletion // or ICriticalNotifyCompletion
    {
        bool IsCompleted { get; }

        TResult GetResult();
    }
}