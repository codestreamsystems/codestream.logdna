namespace CodeStream.logDNA
{
    public interface ILogDNALogger
    {
        void LogObject<T>(Level level, LogDNAMeta<T> meta);
        void LogObjectInfo<T>(LogDNAMeta<T> meta);
        void LogObjectError<T>(LogDNAMeta<T> meta);
        void LogObjectWarn<T>(LogDNAMeta<T> meta);
        void LogObjectDebug<T>(LogDNAMeta<T> meta);
        void LogLine(Level level, string line);
        void LogLineInfo(string line);
        void LogLineDebug(string line);
        void LogLineWarn(string line);
        void LogLineError(string line);

    }
}