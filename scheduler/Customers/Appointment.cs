using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Customers
{
    internal class Appointment
    {
        public Appointment() {}
        public Appointment(int appointmentID, int customerID, string name, string title, string description, string location, string contact, 
            string type, string url, DateTime start, DateTime end, DateTime createdDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AppointmentID = appointmentID;
            CustomerID = customerID;
            Name = name;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            Start = start;
            End = end;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        static public BindingList<Appointment> AllAppointments = new BindingList<Appointment>();

        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        private int? _appointmentID    = null;
        private int? _customerID       = null;
        private string _title          = null;
        private string _description    = null;
        private string _location       = null;
        private string _contact        = null;
        private string _type           = null;
        private string _url            = null;
        private DateTime? _start       = null;
        private DateTime? _end         = null;
        private string _createdBy      = null;
        private DateTime? _createdDate = null;
        private DateTime? _lastUpdate  = null;
        private string _lastUpdateBy   = null;


    }

}
