using System;
using Newtonsoft.Json;
using RedBear.LogDNA;

namespace CodeStream.logDNA
{
    public class LogDNALogger : ILogDNALogger
    {
        private readonly IApiClient logdna;
        private readonly string app;

        public LogDNALogger(IApiClient logdna, string app)
        {
            this.logdna = logdna;
            this.app = app;
        }

        public void LogObject<T>(Level level, LogDNAMeta<T> meta)
        {
            var obj = new LogDNAObject<T>
            {
                level = level.Value, 
                metatype = meta.Message.GetType().Name,
                meta = meta
            };
            logdna.AddLine(new LogLine(app, JsonConvert.SerializeObject(obj), DateTime.UtcNow));
        }

        public void LogObjectInfo<T>(LogDNAMeta<T> meta)
        {
            LogObject<T>(Level.INFO, meta);
        }
        public void LogObjectError<T>(LogDNAMeta<T> meta)
        {
            LogObject<T>(Level.ERROR, meta);
        }
        public void LogObjectWarn<T>(LogDNAMeta<T> meta)
        {
            LogObject<T>(Level.WARN, meta);
        }
        public void LogObjectDebug<T>(LogDNAMeta<T> meta)
        {
            LogObject<T>(Level.DEBUG, meta);
        }

        public void LogLine(Level level, string line)
        {
            var l = new LogDNALine(Level.INFO, line);
            logdna.AddLine(new LogLine(app, JsonConvert.SerializeObject(l), DateTime.UtcNow));
        }
        public void LogLineInfo(string line)
        {
            LogLine(Level.INFO, line);
        }
        public void LogLineDebug(string line)
        {
            LogLine(Level.DEBUG, line);
        }
        public void LogLineWarn(string line)
        {
            LogLine(Level.WARN, line);
        }
        public void LogLineError(string line)
        {
            LogLine(Level.ERROR, line);
        }

        public void LogError(Exception ex, string requestInfo, string requestContent, string correlationId)
        {
            LogObjectError(new LogDNAMeta<ExceptionInfo>(new ExceptionInfo(ex, requestInfo, requestContent, correlationId)));
        }

        public void LogError(Exception ex, string requestInfo, string requestContent)
        {
            LogObjectError(new LogDNAMeta<ExceptionInfo>(new ExceptionInfo(ex, requestInfo, requestContent)));
        }

        public void LogError(Exception ex, string correlationId)
        {
            LogObjectError(new LogDNAMeta<ExceptionInfo>(new ExceptionInfo(ex, correlationId)));
        }
    }
}