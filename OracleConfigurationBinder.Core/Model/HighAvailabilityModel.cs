using System.Collections.Generic;

namespace OracleConfigurationBinder.Core.Model
{
    public class HighAvailabilityModel
    {
        /// <summary>
        /// This property specifies the address that the provider listens to for all notifications sent by the database for continuous query notification feature.
        /// </summary>
        public string DbNotificationAddress { get; set; } = null;

        /// <summary>
        /// This property specifies the port number that the provider listens to for all notifications sent by the database for continuous query notification, Fast Connection Failover, and/or Runtime Connection Load Balancing features. A value of -1 allows directs the provider to use a random port.
        /// </summary>
        public int DbNotificationPort { get; set; } = -1;

        /// <summary>
        /// This property enables the application to receive Fast Connection Failover events for maintaining application high availability.
        /// Default is true.
        /// </summary>
        public bool HAEvents { get; set; } = true;

        /// <summary>
        /// This property specifies the configuration file to define Oracle Notification Service (ONS) behavior. The file specified should contain the same local port and remote port values as specified in the ons.config file used by the local ONS daemon. This will enable the application to receive events from the local ONS daemon.
        /// </summary>
        public string OnsConfigFile { get; set; } = null;

        /// <summary>
        /// This property specifies the ONS daemon mode as either "local" or "remote".
        /// For local configuration, configure and make available ONS on the node where ODP.NET is running so that ODP.NET can receive events directly from the local ONS daemon.
        /// Remote configuration is used when the application directly receives ONS events from the ONS daemons running on remote machines. One of the advantages of this configuration is that no ONS daemon is needed on the client end and; therefore, there is no need to manage this process.
        /// </summary>
        public OnsConfigMode OnsMode { get; set; } = OnsConfigMode.Unspecified;

        /// <summary>
        /// This property returns a collection of logical ONS servers added through OracleConfiguration.
        /// </summary>
        public IEnumerable<OracleOnsServer> OracleOnsServers { get; set; }

        /// <summary>
        /// This property specifies the time to wait before retrying connecting to a service that becomes unavailable. Default value is 90 seconds. Whenever a database service becomes unavailable, such as due to a service being relocated, an application can encounter numerous connectivity errors during this time. To avoid unnecessary connection attempts to an unavailable service which will result in an error, the driver will block any connection attempts until the service is up or until this property's specified time limit expires from the time when the service DOWN event was received, whichever comes first.
        /// </summary>
        public string ServiceRelocationConnectionTimeout { get; set; } = "90";

    }

    public enum OnsConfigMode { Unspecified = 0, local = 1, remote = 2 }

    public class OracleOnsServer
    {
        /// <summary>
        /// A unique logical name for a list of nodes to be added
        /// </summary>
        public string serverName { get; set; }
        
        /// <summary>
        /// Node names and remote ports for the list of nodes that ODP.NET shares ONS communication with.
        /// </summary>
        public IEnumerable<NodeList> nodeList { get; set; }
    }

    public class NodeList
    {
        /// <summary>
        /// Node name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Node port
        /// </summary>
        public string Port { get; set; }
    }

}
