namespace DotNetPatterns.Prototype
{
    public interface IClone<out T>
    {
        T ShallowCopy();

        T DeepCopy();
    }
}
