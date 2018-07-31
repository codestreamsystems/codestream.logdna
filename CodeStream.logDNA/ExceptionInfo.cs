using System;
using System.Diagnostics;

namespace CodeStream.logDNA
{
    public class ExceptionInfo
    {
        public ExceptionInfo(Exception exception, string requestInfo, string requestContent)
        {
            Exception = exception;
            RequestInfo = requestInfo;
            RequestContent = requestContent;
            DemystifiedException = exception.ToStringDemystified();
        }

        public Exception Exception { get; set; }
        public string RequestInfo { get; set; }
        public string RequestContent { get; set; }
        public string DemystifiedException { get; set; }
    }
}