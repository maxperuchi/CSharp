namespace VUMeter
{
    public interface IPlugin
    {
        void Start();
        void Stop();
        string Name { get; }
        string Description { get; }
        IVU VU { get; }
    }
}
