using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWCF.DataAccess
{
    public class DbHelper
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager
                    .ConnectionStrings["LeisnerWCF.Properties.Settings.ConnectionString"]
                    .ConnectionString;
            }
        }

        public static string ProviderName
        {
            get
            {
                return System.Configuration.ConfigurationManager
                    .ConnectionStrings["LeisnerWCF.Properties.Settings.ConnectionString"]
                    .ProviderName;
            }
        }
    }
}