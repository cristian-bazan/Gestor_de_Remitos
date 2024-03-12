using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;

namespace Gestor_de_Remitos.Servicios
{
    public class DB_Helper
    {
        string connectionString = GetConnectionString("config.json");

        private static string GetConnectionString(string configFile)
        {
            string json = File.ReadAllText(configFile);
            dynamic config = JsonConvert.DeserializeObject(json);
            string connectionString = config.ConnectionString;

            return connectionString;
        }
        public DB_Helper()
        {
                
        }

        public string algo()
        {
            return connectionString;
        }
    }

}
