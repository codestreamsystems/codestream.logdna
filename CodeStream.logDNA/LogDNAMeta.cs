namespace CodeStream.logDNA
{
    public class LogDNAMeta<T>
    {
        public LogDNAMeta(T message)
        {
            Message = message;
        }
        public string LoggedOnUser { get; set; }
        public bool MessageSucceeded { get; set; }
        public T Message { get; set; }
        public string MessageFailures { get; set; }
        public long ExecutionMilliseconds { get; set; }
    }
}