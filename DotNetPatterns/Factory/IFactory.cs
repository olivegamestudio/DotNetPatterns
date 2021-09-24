namespace DotNetPatterns.Decorator
{
    interface IFactory<out T>
    {
        T Create();
    }
}
