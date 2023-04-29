using MySql.Data.MySqlClient;
using System.Windows.Forms;
using scheduler.Customers;

namespace scheduler.Database.Query
{
    internal class Delete
    {
        //Queries the DB for customer datasets: Customer and Address
        public static bool CustomerData(int customerId)
        {
            bool success = false;
            string customerQuery = @"DELETE c, a, ci, co
                                    FROM customer as c
	                                    LEFT JOIN address AS a ON c.addressId = a.addressId
                                        LEFT JOIN city AS ci ON a.cityId = ci.cityId
                                        LEFT JOIN country AS co ON ci.countryId = co.countryId
                                    WHERE c.customerId = @customerId;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(customerQuery, conn))
                    {
                        //Creation/Update Name and DateTime
                        command.Parameters.Add("@customerId", MySqlDbType.VarChar).Value = customerId;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
                //Removes the customer from the dictionary rather than another query to the DB
                Customer.CustomerDict.Remove(customerId);

                //Sets then returns the success status
                success = true;
                return success;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"A customer cannot be deleted while having scheduled appointments.");
                success = false;
            }
            return success;
        }
        //Queries the DB for customer datasets: Customer and Address
        public static bool AppointmentData(int appointmentId)
        {
            bool success = false;
            string customerQuery = @"DELETE appointment from appointment
                                    WHERE appointmentId = @appointmentId;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConnection.ConnStr))
                {
                    using (MySqlCommand command = new MySqlCommand(customerQuery, conn))
                    {
                        //Creation/Update Name and DateTime
                        command.Parameters.Add("@appointmentId", MySqlDbType.VarChar).Value = appointmentId;

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }

                //Sets then returns the success status
                success = true;
                return success;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"A customer cannot be deleted while having scheduled appointments.");
                success = false;
            }
            return success;
        }
    }
}
