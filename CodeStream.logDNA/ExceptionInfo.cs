using System;
using System.Diagnostics;

namespace CodeStream.logDNA
{
    public class ExceptionInfo
    {
        public ExceptionInfo(Exception exception)
        {
            Exception = exception;
            DemystifiedException = exception.ToStringDemystified();
        }
        public ExceptionInfo(Exception exception, string requestInfo, string requestContent) : this(exception)
        {
            RequestInfo = requestInfo;
            RequestContent = requestContent;
        }
        public ExceptionInfo(Exception exception, string requestInfo, string requestContent, string correlationId) : this(exception)
        {
            RequestInfo = requestInfo;
            RequestContent = requestContent;
            CorrelationId = correlationId;
        }

        public ExceptionInfo(Exception exception, string correlationId) : this(exception)
        {
            CorrelationId = correlationId;
        }

        public Exception Exception { get; set; }
        public string RequestInfo { get; set; }
        public string RequestContent { get; set; }
        public string DemystifiedException { get; set; }
        public string CorrelationId { get; set; }
    }
}