namespace MrWatts.Internal.StateKeepers
{
    public sealed class StateKeeper<T> : IStateKeeper<T>
    {
        public T State { get; set; }

        public StateKeeper(T initialValue = default)
        {
            State = initialValue;
        }
    }
}
