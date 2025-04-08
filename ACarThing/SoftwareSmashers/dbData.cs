using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public static DataTable? example()
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
                //query failed
            }
            return null;
        }

        public static int? login(string email, string password)
        // using email and password, check to make sure they match and return userID
        {
            try
            {
                string query = "";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return Convert.ToInt32(reader["userID"]);
                    }
                }
            }
            catch (MySqlException ex)
            {
                //query failed
            }
            return null;
        }

        public static Boolean newUser(string firstName, string lastName, string email, string phoneNum, string password)
        // creates a new user in the database, returns true if successful and false if unsuccessful. 
        // we will also need to add another query for creating settings - this would be whatever we want to be set as default settings
        // we could also just call settings(userID) within this function.
        {
            try
            {
                string userQ = "";
                MySqlCommand command = new MySqlCommand(userQ, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //query failed
            }
            return false;
        }

        public static Boolean updateUser(string userID, string firstName, string lastName, string email, string phoneNum, string password)
        // updates existing user, returns true if successful and false if unsuccessful. 
        // see newUser for formatting
        {
            return false;
        }

        public static string settings(int userID)
        // pulls settings info from the database based on userID
        // we should either create a user class or return it all as an array?
        {
            return "";
        }

        public static DataTable? listVehicles(int userID)
        // lists out all vehicles associated with a specific userID
        // see viewLogs for formatting
        {
            return null;
        }

        public static Boolean addVehicle(int userID, string make, string model, string year, string vin, int vehicleType, float battery, float fuel, float oil, float engineTemp, string carName)
        // creating a new vehicle attatched to userID
        // we may be randomizing battery, fuel, oil, and engine temp based on vehicle type
        // make sure to add userID and vehicleID to drivers table (if someone is adding a vehicle it should be assumed they are a driver)
        // see newUser for formatting
        {
            return false;
        }


        public static DataTable? viewLogs()
        // using carID find all logs associated and display them nicely (we don't need to display id's)
        {
            try
            {
                string query = "";

                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);

                return dTable;
            }
            catch (MySqlException ex)
            {
                return null; //query failed
            }
        }

    }
}
