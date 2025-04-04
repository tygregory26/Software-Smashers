using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SoftwareSmashers
{
    internal class dbData
    {
        private static MySqlConnection? connection = null;

        private string server = "172.16.233.77";
        private string username = "group1-csci463";
        private string password = "fjePQu34?";
        private string databaseName = "group1-csci463_ACarThing";

        public dbData()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
            connection.Open();
        }

        public static DataTable? viewLogs()
        {
            try
            {
                string query = "SELECT * FROM `group1-csci463_ACarThing`.user;";

                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);

                return dTable;
            }
            catch (MySqlException ex)
            {
                return null; //QUERY FAILED
            }
        }

    }
}
