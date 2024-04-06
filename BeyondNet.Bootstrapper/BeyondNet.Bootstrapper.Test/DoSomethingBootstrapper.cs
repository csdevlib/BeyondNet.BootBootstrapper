
using BeyondNet.Bootstrapper.Interfaces;

namespace BeyondNet.Bootstrapper.Test
{
    public class DoSomethingBootstrapper : IBootstrapper<bool>
    {
        public void Run()
        {
            Result = true;
        }

        public bool Result { get; private set; }
    }
}
