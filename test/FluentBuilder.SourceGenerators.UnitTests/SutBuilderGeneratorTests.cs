using FluentAssertions;
using System.Reflection;
using Xunit;

namespace FluentBuilder.SourceGenerators
{
    public class SutBuilderGeneratorTests
    {
        [Theory]
        [InlineData("SutBuilderGeneratorPOC", "success!")]
        public void Assembly_ShouldBeTaggedWithMetadata(string key, string value)
        {
            var metadatas = Assembly
                .GetExecutingAssembly()
                .GetCustomAttributes<AssemblyMetadataAttribute>();

            metadatas.Should().ContainSingle(_ => _.Key == key && _.Value == value);
        }
    }
}
