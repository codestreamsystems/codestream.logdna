using System;

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
        void LogError(Exception ex, string requestInfo, string requestContent, string correlationId);
        void LogError(Exception ex, string requestInfo, string requestContent);
        void LogError(Exception ex, string correlationId);
        void LogError(string error, string correlationId);
    }
}