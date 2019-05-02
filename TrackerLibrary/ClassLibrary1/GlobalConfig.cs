using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();
            if (database == true)
            {
                // TODO - Set up the SQL Connector properly

                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles == true)
            {
                //TODO - Create the text connections
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
