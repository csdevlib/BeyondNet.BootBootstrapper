namespace BeyondNet.Bootstrapper.Interfaces
{
    public interface IBootstrapper<out T> : IBootstrapper
    {
        T Result { get; }
    }

    public interface IBootstrapper
    {
        void Run();
    }
}
