using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace scheduler.Customers
{
    internal class Customer
    {
        public static Dictionary<int, Customer> CustomerDict = new Dictionary<int, Customer>();
        public static BindingList<Appointment> Appointments = new BindingList<Appointment>();
        public static List<string> Countries = new List<string>();


        public Customer() { }
        public Customer(int customerId, string customerName, int? addressId)
        {
            CustomerId    = customerId;
            CustomerName  = customerName;
            AddressId     = addressId;
        }

        public Address PrimaryAddress = new Address();
        public Address SecondaryAddress;

        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = "";

        public int? AddressId { get; set; }

        //Lookup functions for customers - Overloaded to allow lookup via key or value
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

        //Fills appointments relevant to current customer
        public static BindingList<Appointment> FillAppointments(int customerID)
        {
            foreach (var appointment in Appointment.AllAppointments)
            {
                if (appointment.CustomerId == customerID)
                {
                    Appointments.Add(appointment);
                }
            }
            return Appointments;
        }

        public static void FillCountries()
        {
            var distinctCountries = CustomerDict.Values.Select(x => x.PrimaryAddress.Country).Distinct();

            foreach (var c in distinctCountries)
            {
                Countries.Add(c);
            }
        }

        //Lookup function for appointments
        public static Appointment AppointmentLookup(int appointmentID)
        {
            foreach (var appointment in Appointments)
            {
                if (appointmentID == appointment.AppointmentId)
                {
                    return appointment;
                }
            }
            return null;
        }

        //Clears customer related appointments
        public static void ClearAppointment()
        {
            Appointments.Clear();
        }
    }
}
