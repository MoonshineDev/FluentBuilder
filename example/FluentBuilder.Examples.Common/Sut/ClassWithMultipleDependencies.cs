using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Dependencies;

namespace FluentBuilder.Examples.Common.Sut
{
    /// <summary>
    /// Simulates a SUT with multiple dependencies
    /// </summary>
    internal class ClassWithMultipleDependencies : IContract
    {
        private readonly IDoSomething _doSomething;
        private readonly IDoSomethingElse _doSomethingElse;
        private readonly IGetSomeUsefulString _getSomeUsefulString;
        private readonly IUseSomeUsefulString _useSomeUsefulString;

        public ClassWithMultipleDependencies(
            IDoSomething doSomething,
            IDoSomethingElse doSomethingElse,
            IGetSomeUsefulString getSomeUsefulString,
            IUseSomeUsefulString useSomeUsefulString)
        {
            _doSomething = doSomething;
            _doSomethingElse = doSomethingElse;
            _getSomeUsefulString = getSomeUsefulString;
            _useSomeUsefulString = useSomeUsefulString;
        }

        public void Run()
        {
            _doSomething.DoSomething();
            _doSomethingElse.DoSomethingElse();
            var usefulString = _getSomeUsefulString.GetSomeUsefulString();
            _useSomeUsefulString.UseSomeUsefulString(usefulString);
        }
    }
}
