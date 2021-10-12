using Microsoft.CodeAnalysis;

namespace FluentBuilder.SourceGenerators
{
    [Generator]
    public class SutBuilderGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // TODO: #13 Implement SyntaxListener
        }

        public void Execute(GeneratorExecutionContext context)
        {
            // TODO: #27 Implement generator
            context.AddSource("generator-poc", "[assembly: System.Reflection.AssemblyMetadata(\"SutBuilderGeneratorPOC\", \"success!\")]");
        }
    }
}
