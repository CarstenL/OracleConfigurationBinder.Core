namespace OracleConfigurationBinder.Core.Model
{
    public class SecureConnectionModel
    {
        /// <summary>
        /// This property enables one or more authentication services, such as TCP/IP with SSL.
        /// Valid Values: NTS, TCPS, or NONE.
        /// Example: (nts, tcps)
        /// </summary>
        public string SqlNetAuthenticationServices { get; set; }

        /// <summary>
        /// This property specifies the encryption client behavior.
        /// accepted - to enable the security service if required or requested by the database.
        /// rejected - to disable the security service, even if required by the database.
        /// requested - to enable the security service if the database allows it.
        /// required - to enable the security service and disallow the connection if the database is not enabled for the security service.
        /// Default value is accepted.
        /// </summary>
        public string SqlNetEncryptionClient { get; set; } = null;

        /// <summary>
        /// This property specifies encryption algorithms that the client can use.
        /// Valid Values: AES128, AES192, AES256, 3DES112, 3DES168
        /// Example: (aes128, aes192)
        /// </summary>
        public string SqlNetEncryptionTypesClient { get; set; }

        /// <summary>
        /// This property specifies the checksum client behavior.
        /// accepted -  to enable the security service if required or requested by the database.
        /// rejected - to disable the security service, even if required by the database.
        /// requested - to enable the security service if the database allows it.
        /// required - to enable the security service and disallow the connection if the database is not enabled for the security service.
        /// Default value is accepted.
        /// </summary>
        public string SqlNetCryptoChecksumClient { get; set; } = null;

        /// <summary>
        /// This property specifies the crypto-checksum algorithms the client can use.
        /// Valid Values: SHA1, SHA256, SHA384, SHA512
        /// Example: (SHA1, SHA256, SHA512)
        /// </summary>
        public string SqlNetCryptoChecksumTypesClient { get; set; }

        /// <summary>
        /// This property specifies whether the client overrides the strong authentication credential with the stored wallet password credential for the database connection.
        /// </summary>
        public bool SqlNetWalletOverride { get; set; }

        /// <summary>
        /// This property enforces the database server distinguished name (DN) matches its service name. Default value is false.
        /// true - to enforce a match. If the DN matches the service name, then the connection succeeds. If the DN does not match the service name, then the connection fails.
        /// false - to not enforce a match. If the DN does not match the service name, then the connection is successful, but an error is logged to the sqlnet.log file.
        /// </summary>
        public bool SSLServerDNMatch { get; set; }

        /// <summary>
        /// This property enforces the connection to use a specific SSL/TLS version. The default value is an undetermined version.
        /// </summary>
        public string SSLVersion { get; set; } = "0";

        /// <summary>
        /// This property specifies the location of wallets. Wallets are certificates, keys, and trustpoints processed by SSL/TLS.
        /// Remarks: Microsoft Certificate Store (MCS) and file system wallets are supported.
        /// </summary>
        public string WalletLocation { get; set; }

    }
}
