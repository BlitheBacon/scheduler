using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using scheduler.Customers;
using scheduler.User;

namespace scheduler.Database.Query
{
    internal class Select
    {
        //Retrieves all basic customer data: IDs, Names, AddressIDs, and AppointmentIDs
        public static bool CustomerData()
        {
            bool success = false;
            string customerQuery =
                @"SELECT c.customerId, c.customerName, ad.addressId, ap.appointmentId
                  FROM customer as c
                  LEFT JOIN (
	                  SELECT addressId
                      FROM address
                      ) AS ad
                  ON c.addressId = ad.addressId
                  LEFT JOIN (
	                  SELECT appointmentId, customerId
                      FROM appointment
                      ) AS ap
                  ON c.customerId = ap.customerId
                  ORDER BY customerId ASC;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(customerQuery, conn))
                    {
                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();


                        while (reader.Read())
                        {
                            Customer.CustomerDict.Add((int)reader.GetUInt32(0), new Customer(
                                (int)reader.GetUInt32(0),                                      //| column: customerId    | var: customerID
                                     reader.GetString(1),                                      //| column: customerName  | var: customerName
                                     //Null handling
                                     reader.IsDBNull(2) ? null : (int?)reader.GetUInt32(2),    //| column: addressId     | var: addressID 
                                     reader.IsDBNull(3) ? null : (int?)reader.GetUInt32(3)));  //| column: appointmentId | var: appointmentID
                        }
                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to import customer data due to an exception.\n{ex.GetType().ToString()}: {ex.Message}");
                success = false;
            }
            return success;
        }

        //Retrieves customer appointment data relevant to the current active user
        public static bool AppointmentData(uint? userId)
        {
            bool success = false;
            string appointmentQuery = @"SELECT c.customerId, u.userId, a.appointmentId, c.customerName, a.title, a.description, a.location, 
                                               a.contact, a.type, a.url, a.start, a.end, a.createdBy, a.createDate, 
                                               a.lastUpdate, a.lastUpdateBy 
                                        FROM customer as c 
                                        LEFT JOIN ( 
                                            SELECT userId, customerId, appointmentID, title, description, location, 
                                                    contact, type, url, start, end, createdBy, createDate, lastUpdate, lastUpdateBy 
                                            FROM appointment 
                                        ) AS a 
                                        ON c.customerId = a.customerId 
                                        LEFT JOIN ( 
                                            SELECT userId 
                                            FROM user 
                                        ) AS u 
                                        ON a.userId = u.userId 
                                        WHERE u.userId = @userID 
                                        ORDER BY c.customerId ASC;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(appointmentQuery, conn))
                    {
                        command.Parameters.Add("@userID", MySqlDbType.UInt32).Value = userId;

                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            if (ActiveUser.UserInformation.UserId == reader.GetUInt32(1))
                            {
                                Appointment.AllAppointments.Add(new Appointment(
                                    (int)reader.GetUInt32(2),  //| Column: appointmentId  | Var: AppointmentID
                                    (int)reader.GetUInt32(0),  //| Column: customerId     | Var: CustomerID
                                    reader.GetString(3),       //| Column: name           | Var: Name
                                    reader.GetString(4),       //| Column: title          | Var: Title
                                    reader.GetString(5),       //| Column: description    | Var: Description
                                    reader.GetString(6),       //| Column: location       | Var: Location
                                    reader.GetString(7),       //| Column: contact        | Var: Contact
                                    reader.GetString(8),       //| Column: type           | Var: Type
                                    reader.GetString(9),       //| Column: url            | Var: URL
                                    reader.GetDateTime(10),    //| Column: start          | Var: Start
                                    reader.GetDateTime(11),    //| Column: end            | Var: End
                                    reader.GetDateTime(13),    //| Column: createdBy      | Var: CreatedBy
                                    reader.GetString(12),      //| Column: createDate     | Var: CreatedDate
                                    reader.GetDateTime(14),    //| Column: lastUpdate     | Var: LastUpdate
                                    reader.GetString(15)));    //| Column: lastUpdateBy   | Var: LastUpdateBy
                            }
                        }
                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to import appointment data due to an exception.\n{ex.GetType().ToString()}: {ex.Message}\n");
                success = false;
            }
            return success;
        }
        public static bool AddressData(int customerId)
        {
            bool success = false;
            string addressQuery = @"SELECT c.customerId, a.address, a.address2, ci.city, co.country, a.postalCode, a.phone
                                    FROM customer AS c
                                    RIGHT JOIN (
                                        SELECT addressId, address, address2, cityId, postalCode, phone
                                        FROM address
                                    ) as a
                                    ON c.addressId = a.addressId
                                    LEFT JOIN ( 
                                        SELECT city, cityId, countryId FROM city
                                    ) as ci
                                    ON a.cityId = ci.cityId
                                    LEFT JOIN ( 
                                        SELECT country, countryId FROM country
                                    ) as co
                                    ON ci.countryId = co.countryId
                                    WHERE c.customerId = @customerID
                                    ORDER BY a.addressId ASC;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(addressQuery, conn))
                    {
                        command.Parameters.Add("@customerId", MySqlDbType.UInt32).Value = customerId;

                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            if (Customer.CustomerDict[reader.GetInt32(0)] != null)
                            {
                                Customer curCustomer = Customer.CustomerDict[reader.GetInt32(0)]; 
                                curCustomer.PrimaryAddress.AddressOne = reader.GetString(1);      //| Column: address    | Var: addressOne
                                curCustomer.PrimaryAddress.AddressTwo = reader.GetString(2);      //| Column: address2   | Var: addressTwo
                                curCustomer.PrimaryAddress.City= reader.GetString(3);             //| Column: city       | Var: city
                                curCustomer.PrimaryAddress.Country= reader.GetString(4);          //| Column: country    | Var: country
                                curCustomer.PrimaryAddress.PostalCode= reader.GetString(5);       //| Column: postalCode | Var: postalCode
                                curCustomer.PrimaryAddress.PhoneNumber = reader.GetString(6);     //| Column: phone      | Var: phoneNumber
                            }
                        }
                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to import appointment data due to an exception.\n{ex.GetType().ToString()}: {ex.Message}\n");
                success = false;
            }
            return success;
        }
    }
}
