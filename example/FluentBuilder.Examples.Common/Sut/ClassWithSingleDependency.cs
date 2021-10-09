using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Dependencies;

namespace FluentBuilder.Examples.Common.Sut
{
    /// <summary>
    /// Simulates a SUT with a single dependency
    /// </summary>
    internal class ClassWithSingleDependency : IContract
    {
        private readonly IDoSomething _doSomething;

        public ClassWithSingleDependency(IDoSomething doSomething)
        {
            _doSomething = doSomething;
        }

        public void Run()
        {
            _doSomething.DoSomething();
        }
    }
}
