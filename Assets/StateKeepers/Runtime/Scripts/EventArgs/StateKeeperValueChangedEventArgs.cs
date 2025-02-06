using System;

namespace MrWatts.Internal.StateKeepers
{
    public sealed class StateKeeperValueChangedEventArgs<T> : EventArgs
    {
        public T OldValue;
        public T NewValue;

        public StateKeeperValueChangedEventArgs(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}