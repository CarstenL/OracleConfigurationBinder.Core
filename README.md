# OracleConfigurationBinder.Core
Extension method to bind appSettings configuration section to OracleConfiguration

## Possible configuration settings
All setting options and the corresponding description can be found in the [Oracle documentation](https://docs.oracle.com/en/database/oracle/oracle-data-access-components/18.3/odpnt/OracleConfigurationMembers.html)


### Example appSettings.json
```json
{
    "OracleConfiguration": {
        "Connection": {
            "DatabaseEditionName": "Name",
            "DisableOOB": true,
            "DrcpConnectionClass": "Drcp",
            "NamesDirectoryPath": "NamesDirectoryPath",
            "OracleDataSources": [
                {
                    "tnsName": "Tns1",
                    "tnsDescriptor": "Descriptor1"
                },
                {
                    "tnsName": "Tns2",
                    "tnsDescriptor": "Descriptor2"
                }
            ],
            "TcpConnectTimeout": 10,
            "TnsAdmin": "TnsAdmin"
        },
        "SecureConnection": {
            "SqlNetAuthenticationServices": "SqlNetAuthenticationServices",
            "SqlNetEncryptionClient": "SqlNetEncryptionClient",
            "SqlNetEncryptionTypesClient": "SqlNetEncryptionTypesClient",
            "SqlNetCryptoChecksumClient": "SqlNetCryptoChecksumClient",
            "SqlNetCryptoChecksumTypesClient": "SqlNetCryptoChecksumTypesClient",
            "SqlNetWalletOverride": true,
            "SSLServerDNMatch": true,
            "SSLVersion": "SSLVersion",
            "WalletLocation": "WalletLocation"
        },
        "Command": {
            "BindByName": true,
            "CommandTimeout": 10
        },
        "HighAvailability": {
            "DbNotificationAddress": "DbNotificationAddress",
            "DbNotificationPort": 123,
            "HAEvents": false,
            "OnsConfigFile": "OnsConfigFile",
            "OnsMode": "Unspecified",
            "OracleOnsServers": [
                {
                    "serverName": "serverNameA",
                    "nodeList": [
                        {
                            "Name": "nodeNameA",
                            "Port": 1
                        },
                        {
                            "Name": "nodeNameB",
                            "Port": 2
                        }
                    ]
                },
                {
                    "serverName": "serverNameB",
                    "nodeList": [
                        {
                            "Name": "nodeNameC",
                            "Port": 3
                        },
                        {
                            "Name": "nodeNameD",
                            "Port": 4
                        }
                    ]
                }
            ],
            "ServiceRelocationConnectionTimeout": "4"
        },
        "Performance": {
            "FetchSize": 1,
            "LoadBalancing": false,
            "MaxStatementCacheSize": 1,
            "ReceiveBufferSize": 1,
            "SelfTuning": false,
            "SendBufferSize": 1,
            "StatementCacheSize": 1,
            "TcpNoDelay": false
        },
        "Tracing": {
            "TraceFileLocation": "C:\\Temp",
            "TraceLevel": 7,
            "TraceOption": 1
        }
    }
}
```