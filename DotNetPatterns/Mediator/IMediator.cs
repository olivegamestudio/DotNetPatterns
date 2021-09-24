namespace DotNetPatterns
{
    public interface IMediator
    {
        void Notify(object sender, string eventName);
    }
}
