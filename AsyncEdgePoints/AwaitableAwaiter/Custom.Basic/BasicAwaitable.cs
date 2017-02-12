using AwaitableAwaiter.Fake;

namespace AwaitableAwaiter.Custom.Basic
{
    public struct BasicAwaitable : IAwaitable
    {
        public IAwaiter GetAwaiter()
        {
            return new BasicAwaiter();
        }
    }
}
