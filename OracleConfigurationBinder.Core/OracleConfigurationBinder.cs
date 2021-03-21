using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.ManagedDataAccess.Client;
using OracleConfigurationBinder.Core.Model;
using System;
using System.Linq;

namespace OracleConfigurationBinder.Core
{
    public static class OracleConfigurationBinder
    {
        public static void AddOracleConfiguration(this IServiceCollection services, IConfiguration section)
        {
            var model = section.Get<OracleConfigurationModel>();

            ParseToOracle(model);
        }

        private static void ParseToOracle(OracleConfigurationModel model)
        {
            ParseConnectionProperties(model.Connection);
            ParseSecureConnectionProperties(model.SecureConnection);
            ParseCommandProperties(model.Command);
            ParseHighAvailabilityProperties(model.HighAvailability);
            ParsePerformanceProperties(model.Performance);
            ParseTracingProperties(model.Tracing);
        }

        private static void ParseConnectionProperties(ConnectionModel model)
        {
            // set DatabaseEditionName
            OracleConfiguration.DatabaseEditionName = model.DatabaseEditionName;

            // set DisableOOB
            OracleConfiguration.DisableOOB = model.DisableOOB;

            // set DrcpConnectionClass
            OracleConfiguration.DrcpConnectionClass = model.DrcpConnectionClass;

            // set NamesDirectoryPath
            OracleConfiguration.NamesDirectoryPath = model.NamesDirectoryPath;

            // set OracleDataSources
            if (model.OracleDataSources?.Count() > 0)
                model.OracleDataSources.ToList().ForEach(o => OracleConfiguration.OracleDataSources.Add(o.tnsName, o.tnsDescriptor));

            // set TcpConnectionTimeout
            OracleConfiguration.TcpConnectTimeout = model.TcpConnectTimeout;

            // set TnsAdmin
            OracleConfiguration.TnsAdmin = model.TnsAdmin;
        }

        private static void ParseSecureConnectionProperties(SecureConnectionModel model)
        {
            // set SqlNetAuthenticationServices
            OracleConfiguration.SqlNetAuthenticationServices = model.SqlNetAuthenticationServices;

            // set SqlNetEncryptionClient
            OracleConfiguration.SqlNetEncryptionClient = model.SqlNetEncryptionClient;

            // set SqlNetEncryptionTypesClient
            OracleConfiguration.SqlNetEncryptionTypesClient = model.SqlNetEncryptionTypesClient;

            // set SqlNetCryptoChecksumClient
            OracleConfiguration.SqlNetCryptoChecksumClient = model.SqlNetCryptoChecksumClient;

            // set SqlNetCryptoChecksumTypesClient
            OracleConfiguration.SqlNetCryptoChecksumTypesClient = model.SqlNetCryptoChecksumTypesClient;

            // set SqlNetWalletOverride
            OracleConfiguration.SqlNetWalletOverride = model.SqlNetWalletOverride;

            // set SSLServerDNMatch
            OracleConfiguration.SSLServerDNMatch = model.SSLServerDNMatch;

            // set SSLVersion
            OracleConfiguration.SSLVersion = model.SSLVersion;

            // set WalletLocation
            OracleConfiguration.WalletLocation = model.WalletLocation;
        }

        private static void ParseCommandProperties(CommandModel model)
        {
            // set BindByName
            OracleConfiguration.BindByName = model.BindByName;

            // set CommandTimeout
            OracleConfiguration.CommandTimeout = model.CommandTimeout;
        }

        private static void ParseHighAvailabilityProperties(HighAvailabilityModel model)
        {
            // set DbNotificationAddress
            OracleConfiguration.DbNotificationAddress = model.DbNotificationAddress;

            // set DbNotificationPort
            OracleConfiguration.DbNotificationPort = model.DbNotificationPort;

            // set HAEvents
            OracleConfiguration.HAEvents = model.HAEvents;

            // set OnsConfigFile
            OracleConfiguration.OnsConfigFile = model.OnsConfigFile;

            // set OnsConfigMode
            OracleConfiguration.OnsMode = (Oracle.ManagedDataAccess.Client.OnsConfigMode)Enum.Parse(typeof(Oracle.ManagedDataAccess.Client.OnsConfigMode), model.OnsMode.ToString());

            // set OracleOnsServers
            if (model.OracleOnsServers?.Count() > 0)
            {
                foreach (var onsServer in model.OracleOnsServers)
                {
                    string attributes = string.Join(", ", onsServer.nodeList.Select(o => $"{o.Name}:{o.Port}"));
                    OracleConfiguration.OracleOnsServers.Add(onsServer.serverName, attributes);
                }
            }

            // set ServiceRelocationConnectionTimeout
            OracleConfiguration.ServiceRelocationConnectionTimeout = model.ServiceRelocationConnectionTimeout;
        }

        private static void ParsePerformanceProperties(PerformanceModel model)
        {
            // set FetchSize
            OracleConfiguration.FetchSize = model.FetchSize;

            // set LoadBalancing
            OracleConfiguration.LoadBalancing = model.LoadBalancing;

            // set MaxStatementCacheSize
            OracleConfiguration.MaxStatementCacheSize = model.MaxStatementCacheSize;

            // set ReceiveBufferSize
            OracleConfiguration.ReceiveBufferSize = model.ReceiveBufferSize;

            // set SelfTuning
            OracleConfiguration.SelfTuning = model.SelfTuning;

            // set SendBufferSize
            OracleConfiguration.SendBufferSize = model.SendBufferSize;

            // set StatementCacheSize
            OracleConfiguration.StatementCacheSize = model.StatementCacheSize;

            // set TcpNoDelay
            OracleConfiguration.TcpNoDelay = model.TcpNoDelay;
        }

        private static void ParseTracingProperties(TracingModel model)
        {
            // set TraceFileLocation
            OracleConfiguration.TraceFileLocation = model.TraceFileLocation;

            // set TraceLevel
            OracleConfiguration.TraceLevel = model.TraceLevel;

            // set TraceOption
            OracleConfiguration.TraceOption = model.TraceOption;
        }
    }
}
