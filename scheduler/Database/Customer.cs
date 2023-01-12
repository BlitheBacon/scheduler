using MySql.Data.MySqlClient;
using scheduler.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Database
{
    internal class Customer
    {
        public static bool PopulateData()
        {
            string customerQuery =
                @"SELECT customer.customerId, customer.customerName, address.addressId, appointment.appointmentId
                  FROM customer
                  LEFT JOIN (
	                  SELECT addressId
                      FROM address
                      ) AS address
                  ON customer.addressId = address.addressId
                  LEFT JOIN (
	                  SELECT appointmentId, customerId
                      FROM appointment
                      ) AS appointment
                  ON customer.customerId = appointment.customerId
                  ORDER BY customerId ASC;";


            using (MySqlConnection conn = new MySqlConnection(DBConnection.connStr))
            {
                using (MySqlCommand command = new MySqlCommand(customerQuery, conn))
                {
                    conn.Open();
                    MySqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        Customers.Customer.CustomerList.Add(new Customers.Customer((int)reader.GetUInt32(0),         //Customer ID
                                                                    reader.GetString(1),         //Customer Name
                                      //Null value handling
                                      (reader.IsDBNull(2)) ? null : (int?)reader.GetUInt32(2),   //Customer Address
                                      (reader.IsDBNull(3)) ? null : (int?)reader.GetUInt32(3))); //Customer Appointment
                    }
                }
            }

            foreach (Customers.Customer customer in Customers.Customer.CustomerList)
                Console.WriteLine($"ID: {customer.CustomerID}, Name: {customer.CustomerName}, Address ID: {customer.AddressID}, Appointment ID: {customer.AppointmentID}");
            return false;
        }
    }
}
