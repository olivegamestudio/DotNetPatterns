namespace DotNetPatterns.Decorator
{
    public interface IFactory<out T>
    {
        T Create();
    }
}
