namespace DotNetPatterns
{
    public class Singleton<T> : ISingleton<T>
    {
        static T _instance;

        public T GetInstance()
        {
            if (_instance == null)
            {
                _instance = default;
            }

            return _instance;
        }
    }
}
