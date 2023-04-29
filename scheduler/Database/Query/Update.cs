using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using scheduler.Customers;
using scheduler.User;

namespace scheduler.Database.Query
{
    internal class Update
    {
        //Queries the DB for Customer and Address records
        public static bool CustomerData(int customerID, string name, string address, string address2, string city, string country, string postalCode, string phone)
        {
            bool success = false;
            string addressQuery = @"UPDATE customer as c
                                    LEFT JOIN address as a
                                        ON c.addressId = a.addressId
                                    LEFT JOIN city as ci
	                                    ON a.cityId = ci.cityId
                                    LEFT JOIN country as co
	                                    ON ci.countryId = co.countryId
                                    SET 
                                        c.customerName = @name,
                                        c.lastUpdate = NOW(),
                                        c.lastUpdateBy = @activeUser,
                                        a.address = @address,    
                                        a.address2 = @address2,
                                        a.postalCode = @postalCode,
                                        a.phone = @phone,
                                        a.lastUpdate = NOW(),
                                        a.lastUpdateBy = @activeUser,
	                                    ci.city = @city,
                                        ci.lastUpdate = NOW(),
                                        ci.lastUpdateBy = @activeUser,
                                        co.country = @country,
                                        co.lastUpdate = NOW(),
                                        co.lastUpdateBy = @activeUser
                                    WHERE a.addressId = @addressId;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(addressQuery, conn))
                    {
                        command.Parameters.Add("@activeUser",  MySqlDbType.VarChar).Value  = ActiveUser.UserInformation.UserName;
                        command.Parameters.Add("@addressId",  MySqlDbType.UInt32).Value  = Customer.CustomerLookup(customerID).AddressId;
                        command.Parameters.Add("@name",    MySqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@address",    MySqlDbType.VarChar).Value = address;
                        command.Parameters.Add("@address2",   MySqlDbType.VarChar).Value = address2;
                        command.Parameters.Add("@city",       MySqlDbType.VarChar).Value = city;
                        command.Parameters.Add("@country",    MySqlDbType.VarChar).Value = country;
                        command.Parameters.Add("@postalCode", MySqlDbType.VarChar).Value = postalCode;
                        command.Parameters.Add("@phone",      MySqlDbType.VarChar).Value = phone;

                        conn.Open();
                        command.ExecuteNonQuery();

                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update address data due to an exception.\n{ex.GetType()}: {ex.Message}\n");
                success = false;
            }
            return success;
        }
        //Queries the DB for Appointment records
        public static bool AppointmentData(int customerID, int appointmentID, string title, string location, string description, string contact, string type, string url, DateTime startDate, DateTime startTime, DateTime endDate, DateTime endTime)
        {
            bool success = false;
            string addressQuery = @"UPDATE appointment as a
                                    LEFT JOIN customer as c
	                                    ON a.customerId = c.customerId
                                    SET
	                                    a.title = @title,
                                        a.location = @location,
                                        a.description = @description,
                                        a.contact = @contact,
                                        a.type = @type,
                                        a.url = @url,
                                        a.start = @start,
                                        a.end = @end,
                                        a.lastUpdate = NOW(),
                                        a.lastUpdateBy = @activeUser
                                    WHERE c.customerId = @customerId AND
                                          a.appointmentId = @appointmentID;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(addressQuery, conn))
                    {
                        command.Parameters.Add("@activeUser", MySqlDbType.VarChar).Value = ActiveUser.UserInformation.UserName;
                        command.Parameters.Add("@customerId", MySqlDbType.UInt32).Value = customerID;
                        command.Parameters.Add("@appointmentId", MySqlDbType.UInt32).Value = appointmentID;
                        command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
                        command.Parameters.Add("@location", MySqlDbType.VarChar).Value = location;
                        command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
                        command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact;
                        command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                        command.Parameters.Add("@url", MySqlDbType.VarChar).Value = url;
                        command.Parameters.Add("@start", MySqlDbType.DateTime).Value = startDate.Date.Add(startTime.ToUniversalTime().TimeOfDay);
                        command.Parameters.Add("@end", MySqlDbType.DateTime).Value = endDate.Date.Add(endTime.ToUniversalTime().TimeOfDay);       
                        
                        conn.Open();                                                          
                        command.ExecuteNonQuery();
                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update address data due to an exception.\n{ex.GetType()}: {ex.Message}\n");
                success = false;
            }
            return success;
        }
    }
}
