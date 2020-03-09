namespace DesignPatterns.Examples.Flyweight
{
    /// <summary>
    /// Extrinsic State
    /// </summary>
    public class Context
    {
        private readonly string _id;
        private readonly int _star;

        public Context(string id, int star)
        {
            _id = id;
            _star = star;
        }

        public string GetId() => _id;

        public int GetStar() => _star;
    }
}