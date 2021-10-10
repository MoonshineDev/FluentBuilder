namespace FluentBuilder.v1
{
    /// <summary>
    /// Entry point for FluentBuilder, creates the various tools provided by the package.
    /// </summary>
    public static class BuilderFactory
    {
        // TODO: Setup SyntaxListener to look for method calls of this method, in order to generate the appropriate builders.
        /// <summary>
        /// Create an auto-generated builder for the SUT class <typeparamref name="TSut"/>.
        /// </summary>
        /// <typeparam name="TSut">SUT class for which the builder should create.</typeparam>
        /// <returns>Builder of SUT class <typeparamref name="TSut"/> instances.</returns>
        public static ISutBuilder<TSut> CreateSutBuilder<TSut>()
        {
            // TODO: Implement factory
            throw new NotImplementedException();
        }
    }
}
