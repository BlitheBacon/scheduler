using MySql.Data.MySqlClient;
using scheduler.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using scheduler.User;

namespace scheduler.Database.Query
{
    internal class Insert
    {
        //Queries the DB for customer datasets: Customer and Address
        public static bool CustomerData(string userName, string customerName, string address, string address2, string city, string country, string postalCode, string phone)
        {
            bool success = false;
            int newCustomerId;
            string customerQuery = @"BEGIN;
                                        INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy)
                                            VALUES (@country, Now(), @userName, Now(), @userName);
                                        INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)
                                            VALUES (@city, LAST_INSERT_ID(), Now(), @userName, Now(), @userName);
                                        INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                                            VALUES (@address, @address2, LAST_INSERT_ID(), @postalCode, @phone, Now(), @userName, Now(), @userName);
                                        INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                                            VALUES (@customerName, LAST_INSERT_ID(), @active, Now(), @userName, Now(), @userName);
                                        SELECT * FROM customer WHERE customerId = LAST_INSERT_ID();
                                    COMMIT;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(customerQuery, conn))
                    {
                        //Creation/Update Name and DateTime
                        command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
                        command.Parameters.Add("@createDate", MySqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@lastUpdate", MySqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@createdBy", MySqlDbType.VarChar).Value = userName;
                        command.Parameters.Add("@lastUpdateBy", MySqlDbType.VarChar).Value = userName;

                        //Country Parameters
                        command.Parameters.Add("@country", MySqlDbType.VarChar).Value = country;

                        //City Parameters
                        command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

                        //Address Parameters
                        command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                        command.Parameters.Add("@address2", MySqlDbType.VarChar).Value = address2;
                        command.Parameters.Add("@postalCode", MySqlDbType.VarChar).Value = postalCode;
                        command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

                        //Customer Parameters
                        command.Parameters.Add("@customerName", MySqlDbType.VarChar).Value = customerName;
                        command.Parameters.Add("@active", MySqlDbType.Int16).Value = 1;

                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        //Populates the customer dictionary with the newly created entry rather than query the DB again
                        while (reader.Read())
                        {
                            Customer.CustomerDict.Add(reader.GetInt32(0), new Customer(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3)
                            ));
                        }

                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.AddressOne = address;
                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.AddressTwo = address2;
                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.City = city;
                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.Country = country;
                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.PhoneNumber = phone;
                        Customer.CustomerDict[reader.GetInt32(0)].PrimaryAddress.PostalCode = postalCode;
                    }
                }
                //Assigns and returns the success result
                return success = true;
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
