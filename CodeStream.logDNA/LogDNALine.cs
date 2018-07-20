namespace CodeStream.logDNA
{
    public class LogDNALine
    {
        public LogDNALine(Level level, string line)
        {
            this.level = level.Value;
            this.line = line;
        }
        public string line { get; set; }
        public string level { get; set; }
    }
}