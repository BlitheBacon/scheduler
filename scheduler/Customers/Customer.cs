using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Customers
{
    internal class Customer
    {
        public static List<Customer> CustomerList = new List<Customer>();

        public Customer(int customerID, string customerName, int? addressID, int? appointmentID)
        {
            CustomerID    = customerID;
            CustomerName  = customerName;
            AddressID     = addressID;
            AppointmentID = appointmentID;
        }

        private int _customerID;
        private string _customerName = "";
        private int? _addressID;
        private int? _appointmentID;


        public List<Appointment> appointmentList = new List<Appointment>();
        public Address primaryAddress = null;
        public Address secondaryAddress = null;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int? AddressID { get; set; }
        public int? AppointmentID { get; set; }
    }
}
