namespace DotNetPatterns
{
    public interface IClone<out T>
    {
        T ShallowCopy();

        T DeepCopy();
    }
}
