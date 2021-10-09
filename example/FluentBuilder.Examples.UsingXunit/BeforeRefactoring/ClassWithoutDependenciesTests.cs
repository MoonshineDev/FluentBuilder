using FluentAssertions;
using FluentBuilder.Examples.Common.Contracts;
using FluentBuilder.Examples.Common.Sut;
using Xunit;

namespace FluentBuilder.Examples.UsingXunit.BeforeRefactoring
{
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
