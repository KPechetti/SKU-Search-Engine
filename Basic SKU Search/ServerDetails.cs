using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_SKU_Search
{
    public class ServerDetails
    {
        private static string serverURL;
        private static string serverName;
        
        public static void SetServerURL(string url)
        {
            serverURL = url;
        }

        public static string GetServerURL()
        {
            return serverURL;
        }

        public static void SetServerName(string name)
        {
            serverName = name;
        }

        public static string GetServerName()
        {
            return serverName;
        }
    }
}
