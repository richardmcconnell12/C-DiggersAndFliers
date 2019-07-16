namespace Animals
{
    public interface IWalker
    {
        string Name { get; set; }
        void Walk();
        void Run();
    }
}