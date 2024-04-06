using BeyondNet.Bootstrapper.Impl;
using Shouldly;

namespace BeyondNet.Bootstrapper.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ConfigureWithCompositeBootstrapperShouldBeTrue()
        {
            var bootstrapper = new DoSomethingBootstrapper();

            new CompositeBootstrapper().Add(bootstrapper).Run();

            bootstrapper.Result.ShouldBe(true);
        }
    }
}
