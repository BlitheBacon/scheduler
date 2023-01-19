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
        public static BindingList<Appointment> Appointments = new BindingList<Appointment>();

        public Customer() { }
        public Customer(int customerId, string customerName, int? addressId, int? appointmentId)
        {
            this.CustomerId    = customerId;
            this.CustomerName  = customerName;
            this.AddressId     = addressId;
            this.AppointmentId = appointmentId;
        }
        ~Customer() { }

        private int _customerId;
        private string _customerName = "";
        private int? _addressId;
        private int? _appointmentId;


        public Address PrimaryAddress = new Address();
        public Address SecondaryAddress;

        public int CustomerId 
        { 
            get => _customerId; 
            set => _customerId = value; 
        }
        public string CustomerName 
        { 
            get => _customerName; 
            set => _customerName = value; 
        }
        public int? AddressId 
        {
            get => _addressId; 
            set => _addressId = value; 
        }
        public int? AppointmentId 
        { 
            get => _appointmentId; 
            set => _appointmentId = value; 
        }

        public static Customer CustomerLookup(string customerToLookup)
        {
            foreach (var customer in CustomerDict.Values) 
            {
                if (customer.CustomerName == customerToLookup) 
                {
                    return customer;
                }
            }
            return null;
        }
        public static Customer CustomerLookup(int customerToLookup)
        {
            foreach (var customerKey in CustomerDict.Keys) 
            {
                if (customerKey == customerToLookup) 
                {
                    return CustomerDict[customerKey];
                }
            }
            return null;
        }

        public static BindingList<Appointment> FillAppointments(int customerID)
        {
            BindingList<Appointment> temp = new BindingList<Appointment>();
            foreach (var appointment in Appointment.AllAppointments)
            {
                if (appointment.CustomerId == customerID) { temp.Add(appointment); }
            }
            return temp;
        }
    }
}
