namespace Animals
{
    public interface IDigger
    {
        string Name { get; set; }
        void Dig();
        void Walk();
        void Run();
    }
}