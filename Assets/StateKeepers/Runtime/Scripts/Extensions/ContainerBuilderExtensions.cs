using Autofac;

namespace MrWatts.Internal.StateKeepers
{
    public static class ContainerBuilderExtensions
    {
        public static void RegisterTypedStateKeeper<T>(this ContainerBuilder builder, T initialValue = default!)
        {
            builder
                .RegisterType<StateKeeper<T>>()
                .AsSelf()
                .SingleInstance();

            builder
                .Register(b => new EventEmittingStateKeeper<T>(b.Resolve<StateKeeper<T>>()))
                .As<IStateKeeper<T>>()
                .AsSelf()
                .SingleInstance()
                .OnActivating(args => args.Instance.State = initialValue);
        }
    }
}