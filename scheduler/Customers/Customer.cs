using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Customers
{
    internal class Customer
    {
        public static Dictionary<int, Customer> CustomerDict = new Dictionary<int, Customer>();
        public BindingList<Appointment> AppointmentList = new BindingList<Appointment>();

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


        public Address primaryAddress = null;
        public Address secondaryAddress = null;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int? AddressID { get; set; }
        public int? AppointmentID { get; set; }
    }
}
