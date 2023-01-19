using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using scheduler.Customers;
using scheduler.User;

namespace scheduler.Database.Query
{
    internal class Update
    {
        //Queries the DB for customer datasets: Customer and Address
        public static bool CustomerData(int customerID, string address, string address2, string city, string country, string postalCode, string phone)
        {
            bool success = false;
            string addressQuery = @"UPDATE address as a
                                    LEFT JOIN city as ci
	                                    ON a.cityId = ci.cityId
                                    LEFT JOIN country as co
	                                    ON ci.countryId = co.countryId
                                    SET 
                                        a.address = @address,    
                                        a.address2 = @address2,
                                        a.postalCode = @postalCode,
                                        a.phone = @phone,
	                                    ci.city = @city,
                                        co.country = @country
                                    WHERE a.addressId = @addressId;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(addressQuery, conn))
                    {
                        command.Parameters.Add("@addressId",  MySqlDbType.UInt32).Value  = Customer.CustomerLookup(customerID).AddressId;
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
                MessageBox.Show($"Failed to update address data due to an exception.\n{ex.GetType().ToString()}: {ex.Message}\n");
                success = false;
            }
            return success;
        }
    }
}
