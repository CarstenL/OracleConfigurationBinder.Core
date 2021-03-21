using System.Collections.Generic;

namespace OracleConfigurationBinder.Core.Model
{
    public class ConnectionModel
    {
        /// <summary>
        /// This property specifies the Oracle edition name for the connection object. 
        /// This property is used with the Oracle Edition-Based Redefinition feature.
        /// </summary>
        public string DatabaseEditionName { get; set; }

        /// <summary>
        /// This property specifies whether to enable Oracle Net Services to send or receive out-of-band break messages using urgent data provided by the underlying protocol. 
        /// Default is false.
        /// </summary>
        public bool DisableOOB { get; set; }

        /// <summary>
        /// This property specifies a logical name that identifies the DRCP connection pool that the ODP.NET connection will use.
        /// It will be used as a default if the DRCPConnectionClass property on the OracleConnection object is not set. 
        /// It will be ignored for non-DRCP connections. 
        /// Default value is null.
        /// </summary>
        public string DrcpConnectionClass { get; set; } = null;

        ///// <summary>
        ///// This property specifies whether to default the service name to the hostname in Oracle Easy Connect Naming so that the service name does not need to be specified.
        ///// </summary>
        //public bool HostnameDefaultServiceIsHost { get; set; }

        /// <summary>
        /// This property specifies the naming method order used for client name resolution lookups.
        /// Example: (tnsnames, ldap)
        /// </summary>
        public string NamesDirectoryPath { get; set; }

        /// <summary>
        /// This property returns a collection of TNS entries added through OracleConfiguration.
        /// </summary>
        public IEnumerable<OracleDataSource> OracleDataSources { get; set; }

        /// <summary>
        /// This property specifies the time, in seconds, for a client to establish a TCP connection (PROTOCOL=tcp in the TNS connect address) to the database server before it can time out. 
        /// Default value is 60 seconds.
        /// </summary>
        public int TcpConnectTimeout { get; set; } = 60;

        /// <summary>
        /// This property specifies the tnsnames.ora and/or sqlnet.ora directory location.
        /// </summary>
        public string TnsAdmin { get; set; } = null;
    }

    public class OracleDataSource
    {
        /// <summary>
        /// Network service name used as the ODP.NET connection string Data Source name.
        /// </summary>
        public string tnsName { get; set; }

        /// <summary>
        /// The complete connect descriptor information for this specific net service name.
        /// </summary>
        public string tnsDescriptor { get; set; }
    }
}
