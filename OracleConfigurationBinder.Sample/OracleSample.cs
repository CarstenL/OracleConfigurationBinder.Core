using Oracle.ManagedDataAccess.Client;
using System;

namespace OracleConfigurationBinder.Sample
{
    public static class OracleSample
    {

        public static void Sample()
        {
            Console.WriteLine(OracleConfiguration.BindByName);
        }
    }
}
