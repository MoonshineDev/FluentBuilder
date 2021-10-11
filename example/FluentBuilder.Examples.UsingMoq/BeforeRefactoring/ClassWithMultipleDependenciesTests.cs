using FluentAssertions;
using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Dependencies;
using FluentBuilder.Examples.Common.Sut;
using Moq;
using Xunit;

namespace FluentBuilder.Examples.UsingMoq.BeforeRefactoring
{
    // TODO: #17 Write summary comment
    public class ClassWithMultipleDependenciesTests
    {
        private readonly Mock<IDoSomething> _doSomething;
        private readonly Mock<IDoSomethingElse> _doSomethingElse;
        private readonly Mock<IGetSomeUsefulString> _getSomeUsefulString;
        private readonly Mock<IUseSomeUsefulString> _useSomeUsefulString;
        private readonly IContract _sut;

        public ClassWithMultipleDependenciesTests()
        {
            _doSomething = new Mock<IDoSomething>();
            _doSomethingElse = new Mock<IDoSomethingElse>();
            _getSomeUsefulString = new Mock<IGetSomeUsefulString>();
            _useSomeUsefulString = new Mock<IUseSomeUsefulString>();
            _sut = new ClassWithMultipleDependencies(
                _doSomething.Object,
                _doSomethingElse.Object,
                _getSomeUsefulString.Object,
                _useSomeUsefulString.Object);
        }

        [Fact]
        public void SutShouldNotBeNull()
        {
            _sut.Should().NotBeNull();
        }

        // TODO: #18 Add tests to expose setup usage
        // TODO: #19 Add tests to expose verify usage
    }
}
