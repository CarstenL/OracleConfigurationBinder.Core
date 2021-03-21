namespace OracleConfigurationBinder.Core.Model
{
    public class OracleConfigurationModel
    {
        public ConnectionModel Connection { get; set; }
        public SecureConnectionModel SecureConnection { get; set; }
        public CommandModel Command { get; set; }
        public HighAvailabilityModel HighAvailability { get; set; }
        public PerformanceModel Performance { get; set; }
        public TracingModel Tracing { get; set; }
    }
}
