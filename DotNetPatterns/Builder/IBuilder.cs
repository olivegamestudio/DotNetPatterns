namespace DotNetPatterns.Builder
{
    public interface IBuilder<out T>
    {
        /// <summary>Build instance of type T.</summary>
        /// <returns>Returns an instance of type T.</returns>
        T Build();
    }
}
