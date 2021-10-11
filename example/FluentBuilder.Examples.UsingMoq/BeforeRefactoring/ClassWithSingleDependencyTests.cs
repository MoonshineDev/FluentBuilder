using FluentAssertions;
using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Dependencies;
using FluentBuilder.Examples.Common.Sut;
using Moq;
using Xunit;

namespace FluentBuilder.Examples.UsingMoq.BeforeRefactoring
{
    // TODO: #17 Write summary comment
    public class ClassWithSingleDependencyTests
    {
        private readonly Mock<IDoSomething> _doSomething;
        private readonly IContract _sut;

        public ClassWithSingleDependencyTests()
        {
            _doSomething = new Mock<IDoSomething>();
            _sut = new ClassWithSingleDependency(_doSomething.Object);
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
