namespace FSync.Models
{
    public sealed class Locale
    {
        private readonly string _name;

        public static readonly  Locale EnUS = new Locale("en_US");

        public Locale(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}