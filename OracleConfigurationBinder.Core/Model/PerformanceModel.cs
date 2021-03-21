namespace OracleConfigurationBinder.Core.Model
{
    public class PerformanceModel
    {
        /// <summary>
        /// This property specifies the total memory size, in bytes, that the provider allocates to cache data fetched in one database round-trip. 
        /// Default value is 131072.
        /// </summary>
        public int FetchSize { get; set; } = 131072;

        /// <summary>
        /// This property enables the application to receive runtime connection load balancing information. 
        /// Default is true.
        /// </summary>
        public bool LoadBalancing { get; set; } = true;

        /// <summary>
        /// This property specifies the maximum number of statements that can be cached when self-tuning is enabled. 
        /// </summary>
        public int MaxStatementCacheSize { get; set; } = -1;

        /// <summary>
        /// This property specifies the buffer space limit for receive operations of sessions.
        /// </summary>
        public int ReceiveBufferSize { get; set; }

        /// <summary>
        /// This property specifies whether self-tuning is enabled for an ODP.NET application. 
        /// By default, self-tuning (true) is enabled.
        /// </summary>
        public bool SelfTuning { get; set; } = true;

        /// <summary>
        /// This property specifies the buffer space limit for send operations of sessions.
        /// </summary>
        public int SendBufferSize { get; set; }

        /// <summary>
        /// This property specifies the number of cursors or statements to be cached for each database connection. 
        /// This setting corresponds to the connection string Statement Cache Size attribute. 
        /// A value greater than zero enables statement caching. 
        /// Default value is zero.
        /// </summary>
        public int StatementCacheSize { get; set; }

        /// <summary>
        /// This property preempts delays in buffer flushing within the TCP/IP protocol stack. 
        /// Default value is true.
        /// </summary>
        public bool TcpNoDelay { get; set; } = true;
    }
}
