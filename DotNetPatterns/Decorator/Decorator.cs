namespace DotNetPatterns.Decorator
{
    public class Decorator<T>
    {
        T _component;

        public Decorator(T component)
        {
            _component = component;
        }

        public void Set(T component)
        {
            _component = component;
        }
    }
}
