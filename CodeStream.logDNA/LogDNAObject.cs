namespace CodeStream.logDNA
{
    public class LogDNAObject<T>
    {
        public string metatype { get; set; }
        public string level { get; set; }
        public LogDNAMeta<T> meta { get; set; }
    }
}