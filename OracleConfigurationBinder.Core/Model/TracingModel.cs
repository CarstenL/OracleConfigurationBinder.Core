namespace OracleConfigurationBinder.Core.Model
{
    public class TracingModel
    {
        /// <summary>
        /// This property specifies the destination directory to output provider traces.
        /// On Windows, the default TraceFileLocation is <Windows user temporary folder>\ODP.NET\core\trace. 
        /// On Linux, the default is <current user temporary folder>/ODP.NET/core/trace. 
        /// If you modify the trace file location, then do not use a write-protected directory, such as C:\ on Windows. 
        /// Write-protection may prevent ODP.NET from being able to write a trace file to that particular directory location.
        /// </summary>
        public string TraceFileLocation { get; set; } = null;

        /// <summary>
        /// This property specifies the generated trace level to trace ODP.NET calls and diagnose provider issues. 
        /// Errors will always be traced. 
        /// Default value is 0 indicating tracing is disabled.
        /// Valid values: 1 = public APIs, 2 = private APIs, 4 = network APIs/data
        /// These values can be bitwise ORed. To enable all traces, set TraceLevel to 7.
        /// </summary>
        public int TraceLevel { get; set; }

        /// <summary>
        /// This property specifies whether to generate a single trace file or multiple trace files for multithreaded applications.
        /// Default value is 0 indicating single trace file for all application threads.
        /// </summary>
        public int TraceOption { get; set; }

    }
}
