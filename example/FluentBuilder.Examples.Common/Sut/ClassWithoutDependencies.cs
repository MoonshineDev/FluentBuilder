using FluentBuilder.Examples.Common.Contracts;

namespace FluentBuilder.Examples.Common.Sut
{
    /// <summary>
    /// Simulates a SUT without any dependencies
    /// </summary>
    internal class ClassWithoutDependencies : IContract
    {
        public void Run()
        {
        }
    }
}
