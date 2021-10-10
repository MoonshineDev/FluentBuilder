namespace FluentBuilder.v1
{
    /// <summary>
    /// Builder for SUT classes, creates instances of <typeparamref name="TSut"/>.
    /// </summary>
    /// <typeparam name="TSut">SUT instance.</typeparam>
    public interface ISutBuilder<TSut>
    {
        /// <summary>
        /// Builds the <typeparamref name="TSut"/> instance as specified.
        /// </summary>
        /// <returns>New instance of <typeparamref name="TSut"/>.</returns>
        public TSut Build();
    }
}
