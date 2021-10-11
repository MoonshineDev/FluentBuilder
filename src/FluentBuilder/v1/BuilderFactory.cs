namespace FluentBuilder.v1
{
    /// <summary>
    /// Entry point for FluentBuilder, creates the various tools provided by the package.
    /// </summary>
    public static class BuilderFactory
    {
        // TODO: #13 Setup SyntaxListener to look for method calls of this method, in order to generate the appropriate builders.
        /// <summary>
        /// Create an auto-generated builder of SUT <typeparamref name="TSut"/> instances.
        /// </summary>
        /// <typeparam name="TSut">SUT for which the builder should create.</typeparam>
        /// <returns>New builder of SUT <typeparamref name="TSut"/> instances.</returns>
        public static ISutBuilder<TSut> CreateSutBuilder<TSut>()
        {
            // TODO: #15 Implement factory
            throw new NotImplementedException();
        }

        // TODO: #14 Setup SyntaxListener to look for method calls of this method, in order to generate the appropriate builders.
        /// <summary>
        /// Create an auto-generated builder of <typeparamref name="TSut"/> instances.
        /// </summary>
        /// <typeparam name="T">Type for which the builder should create.</typeparam>
        /// <returns>New builder of <typeparamref name="TSut"/> instances.</returns>
        public static IBuilder<T> CreateBuilder<T>()
        {
            // TODO: #16 Implement factory
            throw new NotImplementedException();
        }
    }
}
