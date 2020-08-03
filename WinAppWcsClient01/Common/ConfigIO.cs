using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWcsClient01.Common
{
    class ConfigIO
    {
        public static string GetConnectionString(string connectionName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }

        public static string GetAppConfig(string appConfigKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == appConfigKey)
                {
                    return ConfigurationManager.AppSettings[appConfigKey].ToString();
                }
            }
            return null;
        }
    }
}
