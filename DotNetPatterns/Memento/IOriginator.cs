namespace DotNetPatterns.Memento
{
    public interface IOriginator<T>
    {
        IMemento<T> Save();

        void Restore(IMemento<T> memento);
    }
}
