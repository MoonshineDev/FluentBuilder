using FluentAssertions;
using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Sut;
using Xunit;

namespace FluentBuilder.Examples.UsingMoq.BeforeRefactoring
{
    // TODO: #17 Write summary comment
    public class ClassWithoutDependenciesTests
    {
        private readonly IContract _sut;

        public ClassWithoutDependenciesTests()
        {
            _sut = new ClassWithoutDependencies();
        }

        [Fact]
        public void SutShouldNotBeNull()
        {
            _sut.Should().NotBeNull();
        }
    }
}
