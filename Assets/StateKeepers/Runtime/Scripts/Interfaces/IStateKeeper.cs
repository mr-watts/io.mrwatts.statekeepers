namespace MrWatts.Internal.StateKeepers
{
    public interface IStateKeeper<T>
    {
        T State { get; set; }
    }
}
