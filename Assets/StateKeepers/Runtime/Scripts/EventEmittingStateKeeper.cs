using System;

namespace MrWatts.Internal.StateKeepers
{
    public sealed class EventEmittingStateKeeper<T> : IStateKeeper<T>
    {
        public T State
        {
            get
            {
                return delegatee.State;
            }
            set
            {
                T oldValue = delegatee.State;
                delegatee.State = value;
                OnValueChanged?.Invoke(this, new StateKeeperValueChangedEventArgs<T>(oldValue, value));
            }
        }

        public event EventHandler<StateKeeperValueChangedEventArgs<T>>? OnValueChanged;

        private readonly IStateKeeper<T> delegatee;

        public EventEmittingStateKeeper(IStateKeeper<T> delegatee)
        {
            this.delegatee = delegatee;
        }
    }
}
