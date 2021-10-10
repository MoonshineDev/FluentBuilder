namespace FluentBuilder.v1
{
    /// <summary>
    /// Builder, creates instances of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Type of instance being built.</typeparam>
    public interface IBuilder<T>
    {
        /// <summary>
        /// Builds the <typeparamref name="T"/> instance as specified.
        /// </summary>
        /// <returns>New instance of <typeparamref name="T"/>.</returns>
        public T Build();
    }
}
