namespace CodeStream.logDNA
{
    public sealed class Level
    {
        private Level(string value) { Value = value; }
        public string Value { get; private set; }
        public override string ToString()
        {
            return Value;
        }

        public static Level INFO => new Level("INFO");
        public static Level DEBUG => new Level("DEBUG");
        public static Level WARN => new Level("WARN");
        public static Level ERROR => new Level("ERROR");
    }
}