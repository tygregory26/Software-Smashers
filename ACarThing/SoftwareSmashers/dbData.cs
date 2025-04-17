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
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
                connection.Open();
            }
            catch (TimeoutException toe)
            {
                Console.WriteLine("Timeout: " + toe.Message);
            }
            catch (MySqlException sqle)
            {
                Console.WriteLine("SQL error: " + sqle.Message);
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
                Console.WriteLine("Query failed: " + ex.Message);
            }
            return null;
        }

        public static int? login(string email, string password)
        {
            // using email and password, check to make sure they match and return userID
            try
            {
                string query = "SELECT userID FROM user WHERE email = @Email AND password = @Password;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                object? result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : null;
            }
            catch (MySqlException ex)
            {
                //query failed
                Console.WriteLine("Login failed: " + ex.Message);
            }
            return null;
        }

        public static bool newUser(string firstName, string lastName, string email, string phoneNum, string password)
        {
            // creates a new user in the database, returns true if successful and false if unsuccessful. 
            // we will also need to add another query for creating settings - this would be whatever we want to be set as default settings
            // we could also just call settings(userID) within this function.
            try
            {
                string query = "INSERT INTO user (firstName, lastName, email, phoneNum, password) VALUES (@First, @Last, @Email, @Phone, @Pass);";
                MySqlCommand command = new MySqlCommand(query, connection);
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
                Console.WriteLine("New user failed: " + ex.Message);
            }
            return false;
        }

        public static bool updateUser(string userID, string firstName, string lastName, string email, string phoneNum, string password)
        {
            // updates existing user, returns true if successful and false if unsuccessful. 
            // see newUser for formatting
            try
            {
                string query = "UPDATE user SET firstName = @First, lastName = @Last, email = @Email, phoneNum = @Phone, password = @Pass WHERE userID = @ID;";
                MySqlCommand command = new MySqlCommand(query, connection);
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
                Console.WriteLine("Update failed: " + ex.Message);
            }
            return false;
        }

        public static string settings(int userID)
        {
            // pulls settings info from the database based on userID
            // we should either create a user class or return it all as an array?
            try
            {
                string query = "SELECT settingJSON FROM settings WHERE userID = @ID;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", userID);
                object? result = command.ExecuteScalar();
                return result?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                //query failed
                Console.WriteLine("Settings load failed: " + ex.Message);
            }
            return "";
        }

        public static DataTable? listVehicles(int userID)
        {
            // lists out all vehicles associated with a specific userID
            // see viewLogs for formatting
            try
            {
                string query = "SELECT * FROM vehicle WHERE userID = @ID;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", userID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                //query failed
                Console.WriteLine("Vehicle list failed: " + ex.Message);
            }
            return null;
        }

        public static bool addVehicle(int userID, string make, string model, string year, string vin, int vehicleType, float battery, float fuel, float oil, float engineTemp, string carName)
        {
            // creating a new vehicle attatched to userID
            // we may be randomizing battery, fuel, oil, and engine temp based on vehicle type
            // make sure to add userID and vehicleID to drivers table (if someone is adding a vehicle it should be assumed they are a driver)
            // see newUser for formatting
            try
            {
                string query = @"INSERT INTO vehicle (userID, make, model, year, vin, vehicleType, battery, fuel, oil, engineTemp, carName)
                                 VALUES (@UserID, @Make, @Model, @Year, @VIN, @Type, @Battery, @Fuel, @Oil, @Temp, @CarName);";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Make", make);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@VIN", vin);
                command.Parameters.AddWithValue("@Type", vehicleType);
                command.Parameters.AddWithValue("@Battery", battery);
                command.Parameters.AddWithValue("@Fuel", fuel);
                command.Parameters.AddWithValue("@Oil", oil);
                command.Parameters.AddWithValue("@Temp", engineTemp);
                command.Parameters.AddWithValue("@CarName", carName);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //query failed
                Console.WriteLine("Add vehicle failed: " + ex.Message);
            }
            return false;
        }

        public static DataTable? viewLogs()
        {
            // using carID find all logs associated and display them nicely (we don't need to display id's)
            try
            {
                string query = "SELECT dateLogged, description, mileage FROM logs ORDER BY dateLogged DESC;";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);
                return dTable;
            }
            catch (MySqlException ex)
            {
                //query failed
                Console.WriteLine("Log view failed: " + ex.Message);
            }
            return null;
        }
    }
}
