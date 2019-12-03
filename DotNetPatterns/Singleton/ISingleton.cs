namespace DotNetPatterns.Singleton
{
    public interface ISingleton<T>
    {
        T GetInstance();
    }
}
