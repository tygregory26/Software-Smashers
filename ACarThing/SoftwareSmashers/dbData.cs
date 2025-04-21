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
            try {
                connection = new MySqlConnection();
                connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
                connection.Open();
            } catch (TimeoutException toe)
            {
                // Do something  ??
            } catch (MySqlException sqle)
            {
                // also do something here
            }
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
                string query = "SELECT userID FROM `group1-csci463_ACarThing`.user WHERE email = '" + email + "' AND password = '" + password + "' LIMIT 1;";
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
        {
            Console.WriteLine("database");
            try
            {
                string query = "INSERT INTO `group1-csci463_ACarThing`.user " +
                               "(firstName, lastName, email, phoneNumber, password) VALUES " +
                               "('" + firstName + "', '" + lastName + "', '" + email + "', '" + phoneNum + "', '" + password + "');";
                MySqlCommand command = new MySqlCommand(query, connection);
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
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.user SET " +
                               "firstName = '" + firstName + "', lastName = '" + lastName + "', email = '" + email + "', " +
                               "phoneNumber = '" + phoneNum + "', password = '" + password + "' " +
                               "WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //query failed
            }
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
            try
            {
                string query = "SELECT * FROM `group1-csci463_ACarThing`.vehicle WHERE ownerID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
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

        public static Boolean addVehicle(int userID, string make, string model, string year, string vin, int vehicleType, float battery, float fuel, float oil, float engineTemp, string carName)
        // creating a new vehicle attatched to userID
        {
            try
            {
                string query = "INSERT INTO `group1-csci463_ACarThing`.vehicle " +
                               "(make, model, year, vin, vehicleType, batteryLevel, fuelLevel, oilLevel, engineTemp, ownerID, carName) VALUES " +
                               "('" + make + "', '" + model + "', '" + year + "', '" + vin + "', " + vehicleType + ", " + battery + ", " + fuel + ", " + oil + ", " + engineTemp + ", " + userID + ", '" + carName + "');";
                MySqlCommand insertCmd = new MySqlCommand(query, connection);
                insertCmd.ExecuteNonQuery();

                int insertedVehicleID = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", connection).ExecuteScalar());

                string query2 = "INSERT INTO `group1-csci463_ACarThing`.drivers (driverLink, vehicleLink) VALUES (" + userID + ", " + insertedVehicleID + ");";
                MySqlCommand linkCmd = new MySqlCommand(query2, connection);
                linkCmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                //query failed
            }
            return false;
        }

        public static DataTable? viewLogs()
        // using carID find all logs associated and display them nicely (we don't need to display id's)
        {
            return null;
        }

        public static string viewVehicle()
        // using carID return required info from the database (look at IndividualCar for info required)
        {
            return "";
        }

        public static string editVehicle()
        // using carID return required info from the database (look at NewCar for info required)
        {
            return "";
        }

        public static Boolean checkDriver(int userID, int carID)
        // check if the userID is a driver of carID
        {
            return false;
        }

        internal static string getName(int userID)
        // get the first name associated with userID
        {
            return "Test";
        }
    }
}
