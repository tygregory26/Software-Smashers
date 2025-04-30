using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
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
                connection.ConnectionString = "server = " + server + "; uid = " + username + "; pwd = " + password
                        + "; database = " + databaseName;
                connection.Open();
            }
            catch (TimeoutException toe)
            {
                Console.WriteLine(toe.Message);
            }
            catch (MySqlException sqle)
            {
                Console.WriteLine(sqle.Message);
            }
        }

        public static int? login(string email, string password)
        {
            try
            {
                string query = "SELECT userID FROM `group1-csci463_ACarThing`.user WHERE email = '" + email + "' AND password = '" + password + "' LIMIT 1; ";
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
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static Boolean newUser(string firstName, string lastName, string email, string phoneNum, string password)
        {
            Console.WriteLine("database");
            try
            {
                string query = "INSERT INTO `group1-csci463_ACarThing`.user " +
                        "(firstName, lastName, email, phoneNumber, password) VALUES " +
                        "('" + firstName + "', '" + lastName + "', '" + email + "', '" + phoneNum + "', '" + password
                        + "'); ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean updateUser(string userID, string firstName, string lastName, string email, string phoneNum,
                string password)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.user SET " +
                        "firstName = '" + firstName + "', lastName = '" + lastName + "', email = '" + email + "', " +
                        "phoneNumber = '" + phoneNum + "', password = '" + password + "' " +
                        "WHERE userID = " + userID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static DataTable? listVehicles(int userID)
        {
            try
            {
                string query = "SELECT v.* FROM `group1-csci463_ACarThing`.vehicle v " +
                               "JOIN `group1-csci463_ACarThing`.drivers d ON v.carID = d.vehicleLink " +
                               "WHERE d.driverLink = " + userID + ";";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter sqlData = new MySqlDataAdapter(command);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);
                return dTable;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static int addVehicle(int userID, string make, string model, string year, string vin, int vehicleType,
                float battery, float fuel, float oil, float engineTemp, string carName)
        {
            try
            {
                string query = "INSERT INTO `group1-csci463_ACarThing`.vehicle " +
                               "(make, model, year, vin, vehicleType, batteryLevel, fuelLevel, oilLevel, engineTemp, ownerID, carName) VALUES " +
                               "('" + make + "', '" + model + "', '" + year + "', '" + vin + "', " + vehicleType + ", " +
                               battery + ", " + fuel + ", " + oil + ", " + engineTemp + ", " + userID + ", '" + carName + "');";
                MySqlCommand insertCmd = new MySqlCommand(query, connection);
                insertCmd.ExecuteNonQuery();

                int insertedVehicleID = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", connection).ExecuteScalar());

                string query2 = "INSERT INTO `group1-csci463_ACarThing`.drivers (driverLink, vehicleLink) VALUES (" +
                                userID + ", " + insertedVehicleID + ");";
                MySqlCommand linkCmd = new MySqlCommand(query2, connection);
                linkCmd.ExecuteNonQuery();

                return insertedVehicleID;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public static string settings(int userID)
        {
            try
            {
                string query = "SELECT timeZone, notificationsEnabled, unitOfMeasurement, theme FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["timeZone"] + ", " + reader["notificationsEnabled"] + ", " + reader["unitOfMeasurement"] + ", " + reader["theme"];
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static DataTable? viewLogs(int carID)
        {
            try
            {
                string query = "SELECT logEntry, logType, timeStamp " +
                               "FROM `group1-csci463_ACarThing`.Logs " +
                               "WHERE vehicleID = " + carID + " " +
                               "ORDER BY timeStamp DESC;";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, connection);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);
                return dTable;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static string getCarName(int carID)
        {
            try
            {
                string query = "SELECT carName FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static Boolean setCarName(int carID, string name)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET carName = '" + name + "' WHERE carID = "
                        + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean getCarStartStatus(int carID)
        {
            try
            {
                string query = "SELECT isStarted FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean getCarWindowStatus(int carID)
        {
            try
            {
                string query = "SELECT windowsUp FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return !Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean getCarLockStatus(int carID)
        {
            try
            {
                string query = "SELECT doorsLocked FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean getCarArmStatus(int carID)
        {
            try
            {
                string query = "SELECT alarmArmed FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static float getCarTemp(int carID)
        {
            try
            {
                string query = "SELECT engineTemp FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToSingle(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0.0f;
        }

        public static float getOutsideTemp()
        {
            return 72.3f;
        }

        public static int getCarType(int carID)
        {
            try
            {
                string query = "SELECT vehicleType FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public static float getCarBattery(int carID)
        {
            try
            {
                string query = "SELECT batteryLevel FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToSingle(command.ExecuteScalar()) / 100.0f;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0.0f;
        }

        public static float getCarFuel(int carID)
        {
            try
            {
                string query = "SELECT fuelLevel FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToSingle(command.ExecuteScalar()) / 100.0f;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0.0f;
        }

        public static Boolean addDriver(string email, int carID)
        {
            try
            {
                string query = "SELECT userID FROM `group1-csci463_ACarThing`.user WHERE email = '" + email + "'; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int userID = Convert.ToInt32(result);
                    string insert = "INSERT INTO `group1-csci463_ACarThing`.drivers (driverLink, vehicleLink) VALUES ("
                            + userID + ", " + carID + "); ";
                    MySqlCommand insertCmd = new MySqlCommand(insert, connection);
                    insertCmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean checkDriver(int userID, int carID)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM `group1-csci463_ACarThing`.drivers WHERE driverLink = " + userID
                        + " AND vehicleLink = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return (Convert.ToInt32(command.ExecuteScalar()) > 0);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean checkOwner(int userID, int carID)
        {
            try
            {
                string query = "SELECT ownerID FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar()) == userID;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static string getName(int userID)
        {
            try
            {
                string query = "SELECT firstName FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static Boolean swapStartCar(int carID)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET isStarted = " + (getCarStartStatus(carID) ? 0 : 1)
                        + " WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean swapWindow(int carID)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET windowsUp = " + (getCarWindowStatus(carID) ? 0 : 1)
                        + " WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean swapLock(int carID)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET doorsLocked = " + (getCarLockStatus(carID) ? 0 : 1)
                        + " WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean swapArm(int carID)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET alarmArmed = " + (getCarArmStatus(carID) ? 0 : 1)
                        + " WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static string getCarMake(int carID)
        {
            try
            {
                string query = "SELECT make FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static string getCarModel(int carID)
        {
            try
            {
                string query = "SELECT model FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static string getCarYear(int carID)
        {
            try
            {
                string query = "SELECT year FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static string getCarVin(int carID)
        {
            try
            {
                string query = "SELECT vin FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + "; ";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }

        public static string getLastName(int userID)
        {
            try
            {
                string query = "SELECT lastName FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "User";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "User";

        }

        public static string getEmail(int userID)
        {
            try
            {
                string query = "SELECT email FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "user@example.com";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "user@example.com";
        }

        public static string getPhone(int userID)
        {
            try
            {
                string query = "SELECT phoneNumber FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "000-000-0000";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "000-000-0000";
        }

        public static string getTimeZone(int userID)
        {
            try
            {
                string query = "SELECT timeZone FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "UTC";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "UTC";
        }

        public static string getNotifications(int userID)
        {
            try
            {
                string query = "SELECT notificationsEnabled FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "All Notifications";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "All Notifications";
        }

        public static string getLengthUnits(int userID)
        {
            try
            {
                string query = "SELECT unitOfMeasurement FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "metric";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "metric";
        }

        public static string getVolumeUnits(int userID)
        {
            try
            {
                string query = "SELECT unitOfMeasurement FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "metric";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "metric";
        }

        public static string getTempUnits(int userID)
        {
            try
            {
                string query = "SELECT unitOfMeasurement FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "metric";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "metric";
        }

        public static string getTimeUnits(int userID)
        {
            try
            {
                string query = "SELECT unitOfMeasurement FROM `group1-csci463_ACarThing`.user WHERE userID = " + userID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteScalar()?.ToString() ?? "metric";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "metric";
        }

        public static Boolean setSettings(int userID, string timeZone, string notifications, string lengthUnits, string volumeUnits, string tempUnits, string timeUnits)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.user SET " +
                               "timeZone = '" + timeZone + "', " +
                               "notificationsEnabled = " + notifications + ", " +
                               "unitOfMeasurement = '" + lengthUnits + "' " +
                               "WHERE userID = " + userID + ";";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static string editVehicle(int carID, string make, string model, string year, string vin, int vehicleType, string carName)
        {
            try
            {
                string query = "UPDATE `group1-csci463_ACarThing`.vehicle SET " +
                               "make = '" + make + "', " +
                               "model = '" + model + "', " +
                               "year = '" + year + "', " +
                               "vin = '" + vin + "', " +
                               "vehicleType = " + vehicleType + ", " +
                               "carName = '" + carName + "' " +
                               "WHERE carID = " + carID + ";";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                return "Vehicle updated";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Error updating";
        }

        public static Boolean isDriver(string email, int carID)
        {
            try
            {
                string getIDQuery = "SELECT userID FROM `group1-csci463_ACarThing`.user WHERE email = '" + email + "';";
                MySqlCommand getUserIDCmd = new MySqlCommand(getIDQuery, connection);
                int userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar());

                string query = "SELECT COUNT(*) FROM `group1-csci463_ACarThing`.drivers WHERE driverLink = " + userID + " AND vehicleLink = " + carID + ";";
                MySqlCommand command = new MySqlCommand(query, connection);
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean removeDriver(string email, int carID)
        {
            try
            {
                string getIDQuery = "SELECT userID FROM `group1-csci463_ACarThing`.user WHERE email = '" + email + "';";
                MySqlCommand getUserIDCmd = new MySqlCommand(getIDQuery, connection);
                int userID = Convert.ToInt32(getUserIDCmd.ExecuteScalar());

                string deleteQuery = "DELETE FROM `group1-csci463_ACarThing`.drivers WHERE driverLink = " + userID + " AND vehicleLink = " + carID + ";";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean deleteCar(int carID)
        {
            try
            {
                string deleteDrivers = "DELETE FROM `group1-csci463_ACarThing`.drivers WHERE vehicleLink = " + carID + ";";
                MySqlCommand deleteDriversCmd = new MySqlCommand(deleteDrivers, connection);
                deleteDriversCmd.ExecuteNonQuery();

                string deleteLogs = "DELETE FROM `group1-csci463_ACarThing`.Logs WHERE vehicleID = " + carID + ";";
                MySqlCommand deleteLogsCmd = new MySqlCommand(deleteLogs, connection);
                deleteLogsCmd.ExecuteNonQuery();

                string deleteVehicle = "DELETE FROM `group1-csci463_ACarThing`.vehicle WHERE carID = " + carID + ";";
                MySqlCommand deleteVehicleCmd = new MySqlCommand(deleteVehicle, connection);
                deleteVehicleCmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static Boolean createLog(int carID, string message)
        {
            return true;
        }
    }
}
