namespace FSync.Models
{
    public sealed class AccessLevel
    {
        private readonly string _name;

        public static readonly  AccessLevel Public = new AccessLevel("PUBLIC");
        public static readonly  AccessLevel Private = new AccessLevel("PRIVATE");
        public static readonly  AccessLevel Shared = new AccessLevel("SHARED");

        public AccessLevel(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}