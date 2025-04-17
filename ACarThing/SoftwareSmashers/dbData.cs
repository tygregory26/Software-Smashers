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
                string query = "SELECT * FROM group1-csci463_ACarThing.user;";
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
                string query = "SELECT userID FROM user WHERE email = @Email AND password = @Password LIMIT 1;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

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
                string userQ = "INSERT INTO user (firstName, lastName, email, phoneNumber, password) VALUES (@First, @Last, @Email, @Phone, @Pass);";
                MySqlCommand command = new MySqlCommand(userQ, connection);
                command.Parameters.AddWithValue("@First", firstName);
                command.Parameters.AddWithValue("@Last", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phoneNum);
                command.Parameters.AddWithValue("@Pass", password);
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
            try
            {
                string updateQ = "UPDATE user SET firstName = @First, lastName = @Last, email = @Email, phoneNumber = @Phone, password = @Pass WHERE userID = @ID;";
                MySqlCommand command = new MySqlCommand(updateQ, connection);
                command.Parameters.AddWithValue("@First", firstName);
                command.Parameters.AddWithValue("@Last", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phoneNum);
                command.Parameters.AddWithValue("@Pass", password);
                command.Parameters.AddWithValue("@ID", userID);
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
                string query = "SELECT * FROM vehicle WHERE ownerID = @UserID;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);

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
        // we may be randomizing battery, fuel, oil, and engine temp based on vehicle type
        // make sure to add userID and vehicleID to drivers table (if someone is adding a vehicle it should be assumed they are a driver)
        // see newUser for formatting
        {
            try
            {
                string query = @"INSERT INTO vehicle (make, model, year, vin, vehicleType, batteryLevel, fuelLevel, oilLevel, engineTemp, ownerID, carName)
                                 VALUES (@Make, @Model, @Year, @VIN, @Type, @Battery, @Fuel, @Oil, @Temp, @Owner, @CarName);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Make", make);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@VIN", vin);
                command.Parameters.AddWithValue("@Type", vehicleType);
                command.Parameters.AddWithValue("@Battery", battery);
                command.Parameters.AddWithValue("@Fuel", fuel);
                command.Parameters.AddWithValue("@Oil", oil);
                command.Parameters.AddWithValue("@Temp", engineTemp);
                command.Parameters.AddWithValue("@Owner", userID);
                command.Parameters.AddWithValue("@CarName", carName);
                command.ExecuteNonQuery();

                int insertedVehicleID = (int)new MySqlCommand("SELECT LAST_INSERT_ID();", connection).ExecuteScalar()!;
                string linkQuery = "INSERT INTO drivers (driverLink, vehicleLink) VALUES (@UserID, @VehicleID);";
                MySqlCommand linkCmd = new MySqlCommand(linkQuery, connection);
                linkCmd.Parameters.AddWithValue("@UserID", userID);
                linkCmd.Parameters.AddWithValue("@VehicleID", insertedVehicleID);
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
    }
}
